using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_2425Spring_Grp13
{
    public partial class nFormReminder : Form
    {
        private List<Reminder> reminders = new List<Reminder>();
        private string filePath = "reminders.csv";
        private ReminderNotifier notifier;

        private System.Windows.Forms.Timer reminderTimer;
        private List<string> triggeredReminders = new List<string>();
        private Form previousForm;

        public nFormReminder(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            // DateTimePicker ayarları
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.CustomFormat = "dd.MM.yyyy";

            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerTime.CustomFormat = "HH:mm";
            dateTimePickerTime.ShowUpDown = true;

            // ListView ayarları
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = View.Details;

            cbReminderType.Items.AddRange(new string[] { "Meeting", "Task" });

            notifier = new ReminderNotifier(this);

            this.Load += nFormReminder_Load;
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnClear.Click += btnClear_Click;
            listView1.DoubleClick += listView1_DoubleClick;

            // Timer başlat
            reminderTimer = new System.Windows.Forms.Timer();
            reminderTimer.Interval = 60000; // 60 saniye
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        private void nFormReminder_Load(object sender, EventArgs e)
        {
            LoadReminders();
        }

        private void LoadReminders()
        {
            reminders.Clear();
            listView1.Items.Clear();

            if (!File.Exists(filePath)) return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(';');
                if (parts.Length < 5) continue;

                Reminder reminder;
                if (parts[2] == "Meeting")
                    reminder = new Meeting();
                else
                    reminder = new TaskReminder();

                reminder.Date = DateTime.Parse(parts[0]);
                reminder.Time = parts[1];
                reminder.Type = parts[2];
                reminder.Summary = parts[3];
                reminder.Description = parts[4];

                reminders.Add(reminder);

                var item = new ListViewItem(new[] {
                    reminder.Date.ToString("dd.MM.yyyy"),
                    reminder.Time,
                    reminder.Type,
                    reminder.Summary
                });

                listView1.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbReminderType.SelectedItem == null)
            {
                MessageBox.Show("Please select a reminder type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbSummary.Text) || string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                MessageBox.Show("Summary ve Description alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IReminderFactory factory;
            if (cbReminderType.SelectedItem.ToString() == "Meeting")
                factory = new MeetingFactory();
            else
                factory = new TaskFactory();

            var reminder = factory.CreateReminder();
            reminder.Date = dateTimePickerDate.Value.Date;
            reminder.Time = dateTimePickerTime.Value.ToString("HH:mm");
            reminder.Type = cbReminderType.SelectedItem.ToString();
            reminder.Summary = tbSummary.Text;
            reminder.Description = tbDescription.Text;

            reminders.Add(reminder);

            File.AppendAllText(filePath, $"{reminder.Date:dd.MM.yyyy};{reminder.Time};{reminder.Type};{reminder.Summary};{reminder.Description}\n");

            var item = new ListViewItem(new[] {
                reminder.Date.ToString("dd.MM.yyyy"),
                reminder.Time,
                reminder.Type,
                reminder.Summary
            });

            listView1.Items.Add(item);

            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            int index = listView1.SelectedItems[0].Index;
            reminders.RemoveAt(index);
            listView1.Items.RemoveAt(index);

            File.WriteAllLines(filePath, reminders.Select(r =>
                $"{r.Date:dd.MM.yyyy};{r.Time};{r.Type};{r.Summary};{r.Description}"));

            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            if (string.IsNullOrWhiteSpace(tbSummary.Text) || string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                MessageBox.Show("Summary ve Description alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = listView1.SelectedItems[0].Index;

            Reminder r = reminders[index];

            r.Date = dateTimePickerDate.Value.Date;
            r.Time = dateTimePickerTime.Value.ToString("HH:mm");
            r.Type = cbReminderType.SelectedItem.ToString();
            r.Summary = tbSummary.Text;
            r.Description = tbDescription.Text;

            listView1.Items[index].SubItems[0].Text = r.Date.ToString("dd.MM.yyyy");
            listView1.Items[index].SubItems[1].Text = r.Time;
            listView1.Items[index].SubItems[2].Text = r.Type;
            listView1.Items[index].SubItems[3].Text = r.Summary;

            File.WriteAllLines(filePath, reminders.Select(rm =>
                $"{rm.Date:dd.MM.yyyy};{rm.Time};{rm.Type};{rm.Summary};{rm.Description}"));

            ClearFields();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            dateTimePickerDate.Value = DateTime.Now;
            dateTimePickerTime.Value = DateTime.Now;
            cbReminderType.SelectedIndex = -1;
            tbSummary.Clear();
            tbDescription.Clear();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            int index = listView1.SelectedItems[0].Index;
            Reminder r = reminders[index];

            dateTimePickerDate.Value = r.Date;
            dateTimePickerTime.Value = DateTime.ParseExact(r.Time, "HH:mm", null);
            cbReminderType.SelectedItem = r.Type;
            tbSummary.Text = r.Summary;
            tbDescription.Text = r.Description;
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            foreach (var reminder in reminders)
            {
                string id = $"{reminder.Date:dd.MM.yyyy}_{reminder.Time}_{reminder.Summary}";

                if (!triggeredReminders.Contains(id))
                {
                    TimeSpan difference = now - reminder.DateTimeFull;
                    if (difference.TotalSeconds >= 0 && difference.TotalSeconds < 60)
                    {
                        triggeredReminders.Add(id);
                        notifier.Notify(reminder.Summary);
                    }
                }
            }
        }

        // Reminder abstract base class
        public abstract class Reminder
        {
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public string Type { get; set; }
            public string Summary { get; set; }
            public string Description { get; set; }

            public abstract string GetTypeName();

            public DateTime DateTimeFull => Date.Date + TimeSpan.Parse(Time);
        }

        // Task
        public class TaskReminder : Reminder
        {
            public override string GetTypeName() => "Task";
        }

        public class TaskFactory : IReminderFactory
        {
            public Reminder CreateReminder() => new TaskReminder();
        }

        // Meeting
        public class Meeting : Reminder
        {
            public override string GetTypeName() => "Meeting";
        }

        public class MeetingFactory : IReminderFactory
        {
            public Reminder CreateReminder() => new Meeting();
        }

        public interface IReminderFactory
        {
            Reminder CreateReminder();
        }

        public class ReminderNotifier
        {
            private Form form;

            public ReminderNotifier(Form form)
            {
                this.form = form;
            }

            public async void Notify(string summary)
            {
                form.Invoke((MethodInvoker)delegate {
                    form.Text = summary;
                });

                var originalLocation = form.Location;
                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {
                    form.Invoke((MethodInvoker)delegate {
                        form.Location = new Point(originalLocation.X + rnd.Next(-10, 10), originalLocation.Y + rnd.Next(-10, 10));
                    });
                    await Task.Delay(50);
                }

                form.Invoke((MethodInvoker)delegate {
                    form.Location = originalLocation;
                });
            }
        }

        private void nFormReminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Kapatmayı iptal et
            }
            else
            {

                previousForm?.Show(); // Null kontrolü ekleyelim
            }
        }
    }
}
