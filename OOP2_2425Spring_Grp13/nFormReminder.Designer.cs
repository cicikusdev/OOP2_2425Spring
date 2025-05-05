namespace OOP2_2425Spring_Grp13
{
    partial class nFormReminder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSummary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.cbReminderType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnTime,
            this.columnType,
            this.columnSummary});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 250);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 70;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.Width = 70;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 70;
            // 
            // columnSummary
            // 
            this.columnSummary.Text = "Summary";
            this.columnSummary.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbSummary);
            this.groupBox1.Controls.Add(this.cbReminderType);
            this.groupBox1.Controls.Add(this.dateTimePickerTime);
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(50, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reminder Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(582, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(483, 41);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(200, 141);
            this.tbDescription.TabIndex = 6;
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(340, 162);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(120, 20);
            this.tbSummary.TabIndex = 5;
            // 
            // cbReminderType
            // 
            this.cbReminderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReminderType.Location = new System.Drawing.Point(340, 113);
            this.cbReminderType.Name = "cbReminderType";
            this.cbReminderType.Size = new System.Drawing.Size(120, 21);
            this.cbReminderType.TabIndex = 4;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "HH:mm";
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTime.Location = new System.Drawing.Point(340, 65);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerTime.TabIndex = 3;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(340, 30);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Summary";
            // 
            // nFormReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 366);
            this.Controls.Add(this.groupBox1);
            this.Name = "nFormReminder";
            this.Text = "nFormReminder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnSummary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.ComboBox cbReminderType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}