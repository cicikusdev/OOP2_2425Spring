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
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(149, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // btnGoToUserManagement
            // 
            this.btnGoToUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGoToUserManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGoToUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnGoToUserManagement.Location = new System.Drawing.Point(151, 177);
            this.btnGoToUserManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToUserManagement.Name = "btnGoToUserManagement";
            this.btnGoToUserManagement.Size = new System.Drawing.Size(172, 53);
            this.btnGoToUserManagement.TabIndex = 1;
            this.btnGoToUserManagement.Text = "User Management";
            this.btnGoToUserManagement.UseVisualStyleBackColor = false;
            this.btnGoToUserManagement.Click += new System.EventHandler(this.btnGoToUserManagement_Click);
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 366);
            this.Controls.Add(this.btnGoToUserManagement);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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