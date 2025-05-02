namespace OOP2_2425Spring_Grp13
{
    partial class FormUserPanel
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
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Panel";
            // 
            // btnGoToPersonalInfo
            // 
            this.btnGoToPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToPersonalInfo.Location = new System.Drawing.Point(175, 111);
            this.btnGoToPersonalInfo.Name = "btnGoToPersonalInfo";
            this.btnGoToPersonalInfo.Size = new System.Drawing.Size(169, 65);
            this.btnGoToPersonalInfo.TabIndex = 2;
            this.btnGoToPersonalInfo.Text = "Personal Information";
            this.btnGoToPersonalInfo.UseVisualStyleBackColor = true;
            this.btnGoToPersonalInfo.Click += new System.EventHandler(this.btnGoToPersonalInfo_Click);
            // 
            // btnGoToPhoneBook
            // 
            this.btnGoToPhoneBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToPhoneBook.Location = new System.Drawing.Point(412, 111);
            this.btnGoToPhoneBook.Name = "btnGoToPhoneBook";
            this.btnGoToPhoneBook.Size = new System.Drawing.Size(169, 65);
            this.btnGoToPhoneBook.TabIndex = 3;
            this.btnGoToPhoneBook.Text = "Phone Book";
            this.btnGoToPhoneBook.UseVisualStyleBackColor = true;
            this.btnGoToPhoneBook.Click += new System.EventHandler(this.btnGoToPhoneBook_Click);
            // 
            // btnGoToNotes
            // 
            this.btnGoToNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToNotes.Location = new System.Drawing.Point(175, 226);
            this.btnGoToNotes.Name = "btnGoToNotes";
            this.btnGoToNotes.Size = new System.Drawing.Size(169, 65);
            this.btnGoToNotes.TabIndex = 4;
            this.btnGoToNotes.Text = "Notes";
            this.btnGoToNotes.UseVisualStyleBackColor = true;
            this.btnGoToNotes.Click += new System.EventHandler(this.btnGoToNotes_Click);
            // 
            // btnGoToSalaryCalculator
            // 
            this.btnGoToSalaryCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToSalaryCalculator.Location = new System.Drawing.Point(412, 226);
            this.btnGoToSalaryCalculator.Name = "btnGoToSalaryCalculator";
            this.btnGoToSalaryCalculator.Size = new System.Drawing.Size(169, 65);
            this.btnGoToSalaryCalculator.TabIndex = 5;
            this.btnGoToSalaryCalculator.Text = "Salary Calculator";
            this.btnGoToSalaryCalculator.UseVisualStyleBackColor = true;
            this.btnGoToSalaryCalculator.Click += new System.EventHandler(this.btnGoToSalaryCalculator_Click);
            // 
            // btnGoToReminders
            // 
            this.btnGoToReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToReminders.Location = new System.Drawing.Point(294, 342);
            this.btnGoToReminders.Name = "btnGoToReminders";
            this.btnGoToReminders.Size = new System.Drawing.Size(169, 65);
            this.btnGoToReminders.TabIndex = 6;
            this.btnGoToReminders.Text = "Reminders";
            this.btnGoToReminders.UseVisualStyleBackColor = true;
            this.btnGoToReminders.Click += new System.EventHandler(this.btnGoToReminders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(686, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 26);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToReminders);
            this.Controls.Add(this.btnGoToSalaryCalculator);
            this.Controls.Add(this.btnGoToNotes);
            this.Controls.Add(this.btnGoToPhoneBook);
            this.Controls.Add(this.btnGoToPersonalInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormUserPanel";
            this.Text = "FormUserPanel";
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
    }
}