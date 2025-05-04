namespace oopsonhali
{
    partial class ReminderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker timePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            comboBoxType = new ComboBox();
            txtSummary = new TextBox();
            txtDescription = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            timePicker1 = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(12, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(460, 200);
            dataGridView1.TabIndex = 0;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Location = new Point(12, 12);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(100, 28);
            comboBoxType.TabIndex = 1;
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(12, 39);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(312, 27);
            txtSummary.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 65);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(312, 60);
            txtDescription.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(118, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // timePicker1
            // 
            timePicker1.Format = DateTimePickerFormat.Time;
            timePicker1.Location = new Point(224, 12);
            timePicker1.Name = "timePicker1";
            timePicker1.ShowUpDown = true;
            timePicker1.Size = new Size(100, 27);
            timePicker1.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 131);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 131);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            // 
            // ReminderForm
            // 
            ClientSize = new Size(492, 378);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxType);
            Controls.Add(txtSummary);
            Controls.Add(txtDescription);
            Controls.Add(dateTimePicker1);
            Controls.Add(timePicker1);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "ReminderForm";
            Text = "Reminder Manager";
            Load += ReminderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
