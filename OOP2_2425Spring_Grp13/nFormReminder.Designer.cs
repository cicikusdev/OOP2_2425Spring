using System;
using System.Windows.Forms;
using System.Drawing;

namespace OOP2_2425Spring_Grp13
{
    partial class nFormReminder
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSummary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.listView1.Location = new System.Drawing.Point(27, 37);
            // Discarding main's Margin
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 227); // Favor ozgur's size
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
            this.groupBox1.ForeColor = System.Drawing.Color.White; // Favor ozgur's ForeColor
            this.groupBox1.Location = new System.Drawing.Point(50, 30); // Favor ozgur's Location
            // Discarding main's Margin
            this.groupBox1.Name = "groupBox1";
            // Discarding main's Padding
            this.groupBox1.Size = new System.Drawing.Size(720, 284); // Favor ozgur's Size
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reminder Details";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255))))); // Favor ozgur's ForeColor
            this.label4.Location = new System.Drawing.Point(341, 147); // Favor ozgur's Location
            // Discarding main's Margin
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28); // Adjusted size for Segoe UI 12F
            this.label4.TabIndex = 14;
            this.label4.Text = "Summary"; // Text is the same
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255))))); // Favor ozgur's ForeColor
            this.label3.Location = new System.Drawing.Point(340, 96); // Favor ozgur's Location
            // Discarding main's Margin
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 28); // Adjusted size for Segoe UI 12F
            this.label3.TabIndex = 13;
            this.label3.Text = "Type"; // Text is the same
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255))))); // Favor ozgur's ForeColor
            this.label2.Location = new System.Drawing.Point(489, 29); // Favor ozgur's Location
            // Discarding main's Margin
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28); // Adjusted size for Segoe UI 12F
            this.label2.TabIndex = 12;
            this.label2.Text = "Description"; // Text is the same
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255))))); // Favor ozgur's ForeColor
            this.label1.Location = new System.Drawing.Point(480, 120); // Favor ozgur's Location
            // Discarding main's Margin
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28); // Adjusted size for Segoe UI 12F (empty text)
            this.label1.TabIndex = 11;
            this.label1.Text = ""; // Text is the same (empty)
            //
            // btnClear
            //
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7))))); // Favor ozgur's BackColor
            this.btnClear.FlatAppearance.BorderSize = 0; // Favor ozgur's BorderSize
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Favor ozgur's FlatStyle
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.btnClear.ForeColor = System.Drawing.Color.White; // Favor ozgur's ForeColor
            this.btnClear.Location = new System.Drawing.Point(582, 227); // Favor ozgur's Location
            // Discarding main's Margin
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 30); // Favor ozgur's Size
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Fields"; // Text is the same
            this.btnClear.UseVisualStyleBackColor = false; // Favor ozgur's UseVisualStyleBackColor
            //
            // btnUpdate
            //
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255))))); // Favor ozgur's BackColor
            this.btnUpdate.FlatAppearance.BorderSize = 0; // Favor ozgur's BorderSize
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Favor ozgur's FlatStyle
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.btnUpdate.ForeColor = System.Drawing.Color.White; // Favor ozgur's ForeColor
            this.btnUpdate.Location = new System.Drawing.Point(502, 227); // Favor ozgur's Location
            // Discarding main's Margin
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 30); // Favor ozgur's Size
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update"; // Text is the same
            this.btnUpdate.UseVisualStyleBackColor = false; // Favor ozgur's UseVisualStyleBackColor
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))); // Favor ozgur's BackColor
            this.btnDelete.FlatAppearance.BorderSize = 0; // Favor ozgur's BorderSize
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Favor ozgur's FlatStyle
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.btnDelete.ForeColor = System.Drawing.Color.White; // Favor ozgur's ForeColor
            this.btnDelete.Location = new System.Drawing.Point(422, 227); // Favor ozgur's Location
            // Discarding main's Margin
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 30); // Favor ozgur's Size
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete"; // Text is the same
            this.btnDelete.UseVisualStyleBackColor = false; // Favor ozgur's UseVisualStyleBackColor
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69))))); // Favor ozgur's BackColor
            this.btnAdd.FlatAppearance.BorderSize = 0; // Favor ozgur's BorderSize
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Favor ozgur's FlatStyle
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Favor ozgur's Font
            this.btnAdd.ForeColor = System.Drawing.Color.White; // Favor ozgur's ForeColor
            this.btnAdd.Location = new System.Drawing.Point(341, 227); // Favor ozgur's Location
            // Discarding main's Margin
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 30); // Favor ozgur's Size
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add"; // Text is the same
            this.btnAdd.UseVisualStyleBackColor = false; // Favor ozgur's UseVisualStyleBackColor
            //
            // tbDescription
            //
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250))))); // Favor ozgur's BackColor
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Favor ozgur's BorderStyle
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12F); // Favor ozgur's Font
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); // Favor ozgur's ForeColor
            this.tbDescription.Location = new System.Drawing.Point(489, 52); // Favor ozgur's Location
            // Discarding main's Margin
            this.tbDescription.Multiline = true; // Multiline is the same
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(200, 147); // Favor ozgur's Size
            this.tbDescription.TabIndex = 6;
            //
            // tbSummary
            //
            this.tbSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250))))); // Favor ozgur's BackColor
            this.tbSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Favor ozgur's BorderStyle
            this.tbSummary.Font = new System.Drawing.Font("Segoe UI", 12F); // Favor ozgur's Font
            this.tbSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); // Favor ozgur's ForeColor
            this.tbSummary.Location = new System.Drawing.Point(340, 170); // Favor ozgur's Location
            // Discarding main's Margin
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(120, 29); // Favor ozgur's Size
            this.tbSummary.TabIndex = 5;
            //
            // cbReminderType
            //
            this.cbReminderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250))))); // Favor ozgur's BackColor
            this.cbReminderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // DropDownStyle is the same
            this.cbReminderType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); // Favor ozgur's ForeColor
            this.cbReminderType.Location = new System.Drawing.Point(340, 120); // Favor ozgur's Location
            // Discarding main's Margin
            this.cbReminderType.Name = "cbReminderType";
            this.cbReminderType.Size = new System.Drawing.Size(159, 24); // Size is the same
            this.cbReminderType.TabIndex = 4;
            //
            // dateTimePickerTime
            //
            this.dateTimePickerTime.CustomFormat = "HH:mm"; // CustomFormat is the same
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom; // Format is the same
            this.dateTimePickerTime.Location = new System.Drawing.Point(340, 70); // Adjusted Location based on ozgur's layout
            // Discarding main's Margin
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true; // ShowUpDown is the same
            this.dateTimePickerTime.Size = new System.Drawing.Size(159, 22); // Size is the same
            this.dateTimePickerTime.TabIndex = 3;
            //
            // dateTimePickerDate
            //
            this.dateTimePickerDate.CustomFormat = "dd.MM.yyyy"; // CustomFormat is the same
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom; // Format is the same
            this.dateTimePickerDate.Location = new System.Drawing.Point(340, 37); // Adjusted Location based on ozgur's layout
            // Discarding main's Margin
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(159, 22); // Size is the same
            this.dateTimePickerDate.TabIndex = 2;
            //
            // nFormReminder
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // AutoScaleDimensions is the same
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // AutoScaleMode is the same
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34))))); // Favor ozgur's BackColor
            this.ClientSize = new System.Drawing.Size(820, 346); // Favor ozgur's ClientSize
            this.Controls.Add(this.groupBox1); // Controls collection addition is the same
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4); // Kept margin from main
            this.Name = "nFormReminder"; // Name is the same
            this.Text = "Reminder Management"; // Favor ozgur's descriptive text
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nFormReminder_FormClosing); // Kept FormClosing event from main
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