#nullable disable

using System;
using System.Linq;
using System.Windows.Forms;

namespace oopsonhali
{
    public partial class ReminderForm : Form
    {
        private ReminderManager manager = new ReminderManager();
        private IReminder selectedReminder = null;

        public ReminderForm()
        {
            InitializeComponent();
            SetupDataGridView();

            comboBoxType.Items.Add("Meeting");
            comboBoxType.Items.Add("Task");
            comboBoxType.SelectedIndex = 0;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

            LoadRemindersToGrid();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Summary", "Summary");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void LoadRemindersToGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var r in manager.Reminders)
            {
                dataGridView1.Rows.Add(
                    r.Id,
                    r is MeetingReminder ? "Meeting" : "Task",
                    r.ReminderDateTime.ToShortDateString(),
                    r.ReminderDateTime.ToShortTimeString(),
                    r.Summary,
                    r.Description
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var factory = comboBoxType.SelectedItem.ToString() == "Meeting"
                ? (IReminderFactory)new MeetingFactory()
                : new TaskFactory();

            var rem = factory.CreateReminder();
            rem.Summary = txtSummary.Text.Trim();
            rem.Description = txtDescription.Text.Trim();
            rem.ReminderDateTime = dateTimePicker1.Value.Date + timePicker1.Value.TimeOfDay;

            manager.AddReminder(rem);
            LoadRemindersToGrid();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReminder == null) return;
            selectedReminder.Summary = txtSummary.Text.Trim();
            selectedReminder.Description = txtDescription.Text.Trim();
            selectedReminder.ReminderDateTime = dateTimePicker1.Value.Date + timePicker1.Value.TimeOfDay;

            manager.UpdateReminder(selectedReminder);
            LoadRemindersToGrid();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReminder == null) return;
            manager.DeleteReminder(selectedReminder.Id);
            LoadRemindersToGrid();
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            selectedReminder = manager.Reminders.FirstOrDefault(r => r.Id == id);
            if (selectedReminder != null)
            {
                comboBoxType.SelectedItem = selectedReminder is MeetingReminder ? "Meeting" : "Task";
                txtSummary.Text = selectedReminder.Summary;
                txtDescription.Text = selectedReminder.Description;
                dateTimePicker1.Value = selectedReminder.ReminderDateTime.Date;
                timePicker1.Value = DateTime.Today.Add(selectedReminder.ReminderDateTime.TimeOfDay);
            }
        }

        private void ClearFields()
        {
            txtSummary.Clear();
            txtDescription.Clear();
            selectedReminder = null;
            comboBoxType.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now.Date;
            timePicker1.Value = DateTime.Now;
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
