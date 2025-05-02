namespace OOP2_2425Spring_Grp13
{
    partial class FormAdminPanel
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
            this.btnGoToUserManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // btnGoToUserManagement
            // 
            this.btnGoToUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoToUserManagement.Location = new System.Drawing.Point(231, 151);
            this.btnGoToUserManagement.Name = "btnGoToUserManagement";
            this.btnGoToUserManagement.Size = new System.Drawing.Size(169, 65);
            this.btnGoToUserManagement.TabIndex = 1;
            this.btnGoToUserManagement.Text = "User Management";
            this.btnGoToUserManagement.UseVisualStyleBackColor = true;
            this.btnGoToUserManagement.Click += new System.EventHandler(this.btnGoToUserManagement_Click);
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.btnGoToUserManagement);
            this.Controls.Add(this.label1);
            this.Name = "FormAdminPanel";
            this.Text = "FormAdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToUserManagement;
    }
}