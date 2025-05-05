using System;
using System.Windows.Forms;
using System.Drawing;

namespace OOP2_2425Spring_Grp13
{
    partial class FormUserPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToPersonalInfo = new System.Windows.Forms.Button();
            this.btnGoToPhoneBook = new System.Windows.Forms.Button();
            this.btnGoToNotes = new System.Windows.Forms.Button();
            this.btnGoToSalaryCalculator = new System.Windows.Forms.Button();
            this.btnGoToReminders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Control Panel";
            // 
            // btnGoToPersonalInfo
            // 
            this.btnGoToPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGoToPersonalInfo.FlatAppearance.BorderSize = 0;
            this.btnGoToPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.btnGoToPersonalInfo.Location = new System.Drawing.Point(118, 87);
            this.btnGoToPersonalInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToPersonalInfo.Name = "btnGoToPersonalInfo";
            this.btnGoToPersonalInfo.Size = new System.Drawing.Size(165, 57);
            this.btnGoToPersonalInfo.TabIndex = 5;
            this.btnGoToPersonalInfo.Text = "Personal Information";
            this.btnGoToPersonalInfo.UseVisualStyleBackColor = false;
            this.btnGoToPersonalInfo.Click += new System.EventHandler(this.btnGoToPersonalInfo_Click);
            this.btnGoToPersonalInfo.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnGoToPersonalInfo.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnGoToPhoneBook
            // 
            this.btnGoToPhoneBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGoToPhoneBook.FlatAppearance.BorderSize = 0;
            this.btnGoToPhoneBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToPhoneBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToPhoneBook.ForeColor = System.Drawing.Color.White;
            this.btnGoToPhoneBook.Location = new System.Drawing.Point(298, 87);
            this.btnGoToPhoneBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToPhoneBook.Name = "btnGoToPhoneBook";
            this.btnGoToPhoneBook.Size = new System.Drawing.Size(165, 57);
            this.btnGoToPhoneBook.TabIndex = 4;
            this.btnGoToPhoneBook.Text = "Phone Book";
            this.btnGoToPhoneBook.UseVisualStyleBackColor = false;
            this.btnGoToPhoneBook.Click += new System.EventHandler(this.btnGoToPhoneBook_Click);
            this.btnGoToPhoneBook.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnGoToPhoneBook.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnGoToNotes
            // 
            this.btnGoToNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGoToNotes.FlatAppearance.BorderSize = 0;
            this.btnGoToNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToNotes.ForeColor = System.Drawing.Color.White;
            this.btnGoToNotes.Location = new System.Drawing.Point(118, 185);
            this.btnGoToNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToNotes.Name = "btnGoToNotes";
            this.btnGoToNotes.Size = new System.Drawing.Size(165, 57);
            this.btnGoToNotes.TabIndex = 3;
            this.btnGoToNotes.Text = "Notes";
            this.btnGoToNotes.UseVisualStyleBackColor = false;
            this.btnGoToNotes.Click += new System.EventHandler(this.btnGoToNotes_Click);
            this.btnGoToNotes.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnGoToNotes.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnGoToSalaryCalculator
            // 
            this.btnGoToSalaryCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGoToSalaryCalculator.FlatAppearance.BorderSize = 0;
            this.btnGoToSalaryCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToSalaryCalculator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToSalaryCalculator.ForeColor = System.Drawing.Color.White;
            this.btnGoToSalaryCalculator.Location = new System.Drawing.Point(298, 185);
            this.btnGoToSalaryCalculator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToSalaryCalculator.Name = "btnGoToSalaryCalculator";
            this.btnGoToSalaryCalculator.Size = new System.Drawing.Size(165, 57);
            this.btnGoToSalaryCalculator.TabIndex = 2;
            this.btnGoToSalaryCalculator.Text = "Salary Calculator";
            this.btnGoToSalaryCalculator.UseVisualStyleBackColor = false;
            this.btnGoToSalaryCalculator.Click += new System.EventHandler(this.btnGoToSalaryCalculator_Click);
            this.btnGoToSalaryCalculator.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnGoToSalaryCalculator.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnGoToReminders
            // 
            this.btnGoToReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnGoToReminders.FlatAppearance.BorderSize = 0;
            this.btnGoToReminders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToReminders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToReminders.ForeColor = System.Drawing.Color.White;
            this.btnGoToReminders.Location = new System.Drawing.Point(208, 282);
            this.btnGoToReminders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToReminders.Name = "btnGoToReminders";
            this.btnGoToReminders.Size = new System.Drawing.Size(165, 57);
            this.btnGoToReminders.TabIndex = 1;
            this.btnGoToReminders.Text = "Reminders";
            this.btnGoToReminders.UseVisualStyleBackColor = false;
            this.btnGoToReminders.Click += new System.EventHandler(this.btnGoToReminders_Click);
            this.btnGoToReminders.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnGoToReminders.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(510, 309);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // FormUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToReminders);
            this.Controls.Add(this.btnGoToSalaryCalculator);
            this.Controls.Add(this.btnGoToNotes);
            this.Controls.Add(this.btnGoToPhoneBook);
            this.Controls.Add(this.btnGoToPersonalInfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUserPanel";
            this.Text = "User Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUserPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToPersonalInfo;
        private System.Windows.Forms.Button btnGoToPhoneBook;
        private System.Windows.Forms.Button btnGoToNotes;
        private System.Windows.Forms.Button btnGoToSalaryCalculator;
        private System.Windows.Forms.Button btnGoToReminders;
        private System.Windows.Forms.Button btnExit;

        // Animasyon ve hover efektleri
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Check if it's the Exit button, or others
            if (btn.Name != "btnExit")
            {
                // Change the color of the button to blue on hover (for non-Exit buttons)
                btn.BackColor = Color.FromArgb(219, 219, 219);
            }
            else
            {
                // Exit button has red color on hover
                btn.BackColor = Color.FromArgb(255, 82, 82);
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // If it's the "Exit" button, we want it to stay red
            if (btn.Name == "btnExit")
            {
                btn.BackColor = Color.FromArgb(220, 53, 69);  // Exit button remains red
            }
            else
            {
                // All other buttons will keep their specific colors (no blue)
                if (btn.Name == "btnGoToPersonalInfo")
                    btn.BackColor = Color.FromArgb(0, 123, 255);  // Blue for Personal Information
                else if (btn.Name == "btnGoToPhoneBook")
                    btn.BackColor = Color.FromArgb(0, 123, 255);  // Blue for Phone Book
                else if (btn.Name == "btnGoToNotes")
                    btn.BackColor = Color.FromArgb(40, 167, 69);  // Green for Notes
                else if (btn.Name == "btnGoToSalaryCalculator")
                    btn.BackColor = Color.FromArgb(40, 167, 69);  // Green for Salary Calculator
                else if (btn.Name == "btnGoToReminders")
                    btn.BackColor = Color.FromArgb(255, 193, 7);  // Yellow for Reminders
            }
        }


    }
}
