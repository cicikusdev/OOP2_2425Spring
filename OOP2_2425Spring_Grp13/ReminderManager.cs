using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace oopsonhali
{
    public class ReminderManager
    {
        private static readonly string DataDirectory =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "oopsonhali");

        private static readonly string FilePath =
            Path.Combine(DataDirectory, "reminders.csv");

        public List<IReminder> Reminders { get; private set; } = new();

        private readonly System.Timers.Timer checkTimer;

        public ReminderManager()
        {
            if (!Directory.Exists(DataDirectory))
                Directory.CreateDirectory(DataDirectory);

            LoadRemindersFromFile();

            checkTimer = new System.Timers.Timer(10000);
            checkTimer.Elapsed += CheckReminders;
            checkTimer.Start();
        }

        public void AddReminder(IReminder reminder)
        {
            reminder.Id = Reminders.Any() ? Reminders.Max(r => r.Id) + 1 : 1;
            Reminders.Add(reminder);
            SaveRemindersToFile();
        }

        public void UpdateReminder(IReminder updated)
        {
            var idx = Reminders.FindIndex(r => r.Id == updated.Id);
            if (idx >= 0)
            {
                Reminders[idx] = updated;
                SaveRemindersToFile();
            }
        }

        public void DeleteReminder(int id)
        {
            Reminders.RemoveAll(r => r.Id == id);
            SaveRemindersToFile();
        }

        private void LoadRemindersFromFile()
        {
            Reminders.Clear();
            if (!File.Exists(FilePath)) return;
            try
            {
                var lines = File.ReadAllLines(FilePath).Skip(1);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length < 6) continue;
                    if (!DateTime.TryParse($"{parts[2]} {parts[3]}", out var dt)) continue;

                    IReminderFactory factory = parts[1] == "Meeting"
                        ? new MeetingFactory()
                        : new TaskFactory();

                    var r = factory.CreateReminder();
                    r.Id = int.Parse(parts[0]);
                    r.ReminderDateTime = dt;
                    r.Summary = parts[4];
                    r.Description = parts[5];
                    Reminders.Add(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yüklerken hata: {ex.Message}", "Load Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveRemindersToFile()
        {
            try
            {
                using var writer = new StreamWriter(FilePath, false);
                writer.WriteLine("Id,Type,Date,Time,Summary,Description");
                foreach (var r in Reminders)
                {
                    var type = r is MeetingReminder ? "Meeting" : "Task";
                    writer.WriteLine($"{r.Id},{type},{r.ReminderDateTime:yyyy-MM-dd},{r.ReminderDateTime:HH:mm},{r.Summary},{r.Description}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kaydederken hata: {ex.Message}", "Save Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckReminders(object? sender, System.Timers.ElapsedEventArgs e)
        {
            var now = DateTime.Now;
            foreach (var r in Reminders)
            {
                if (Math.Abs((r.ReminderDateTime - now).TotalSeconds) < 1)
                {
                    r.Notify();
                    ShowReminderEffect(r.Summary);
                }
            }
        }

        private void ShowReminderEffect(string summary)
        {
            var form = Form.ActiveForm;
            if (form == null) return;

            form.Invoke(() =>
            {
                var original = form.Text;
                form.Text = $"Reminder: {summary}";
                var oLoc = form.Location;
                var rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    form.Location = new System.Drawing.Point(oLoc.X + rnd.Next(-5, 5),
                                                           oLoc.Y + rnd.Next(-5, 5));
                    System.Threading.Thread.Sleep(50);
                }
                form.Location = oLoc;
                form.Text = original;
            });
        }
    }
}
