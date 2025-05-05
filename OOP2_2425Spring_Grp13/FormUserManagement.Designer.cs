using System;
using System.Windows.Forms;
using System.Drawing;

namespace OOP2_2425Spring_Grp13
{
    partial class FormUserManagement
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnChangeType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendNewPassword = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(9, 8);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(548, 167);
            this.dgvUsers.TabIndex = 0;
            // 
            // cmbUserType
            // 
            this.cmbUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(166, 194);
            this.cmbUserType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(159, 21);
            this.cmbUserType.TabIndex = 1;
            // 
            // btnChangeType
            // 
            this.btnChangeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnChangeType.FlatAppearance.BorderSize = 0;
            this.btnChangeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeType.ForeColor = System.Drawing.Color.White;
            this.btnChangeType.Location = new System.Drawing.Point(351, 189);
            this.btnChangeType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(182, 29);
            this.btnChangeType.TabIndex = 2;
            this.btnChangeType.Text = "Change User Type";
            this.btnChangeType.UseVisualStyleBackColor = true;
            this.btnChangeType.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select A User Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(9, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password:";
            // 
            // btnSendNewPassword
            // 
            this.btnSendNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSendNewPassword.FlatAppearance.BorderSize = 0;
            this.btnSendNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSendNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnSendNewPassword.Location = new System.Drawing.Point(138, 243);
            this.btnSendNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendNewPassword.Name = "btnSendNewPassword";
            this.btnSendNewPassword.Size = new System.Drawing.Size(125, 29);
            this.btnSendNewPassword.TabIndex = 6;
            this.btnSendNewPassword.Text = "Send New Password";
            this.btnSendNewPassword.UseVisualStyleBackColor = true;
            this.btnSendNewPassword.Click += new System.EventHandler(this.btnSendNewPassword_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 304);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(264, 11);
            this.progressBar1.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(459, 243);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(74, 29);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Delete";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(352, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Delete User:";
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(566, 366);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSendNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeType);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUserManagement";
            this.Text = "User Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUserManagement_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnChangeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendNewPassword;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
    }
}
