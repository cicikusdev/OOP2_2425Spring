using System;
using System.Windows.Forms;
using System.Drawing;

namespace OOP2_2425Spring_Grp13
{
    partial class FormLogin
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

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.label1.Location = new System.Drawing.Point(150, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32); // Adjusted size for Segoe UI 14F
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            //
            // txtEmail
            //
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.Location = new System.Drawing.Point(250, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 34); // Adjusted size for Segoe UI 12F
            this.txtEmail.TabIndex = 1;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5); // Kept margin
            // Note: Padding property is not a standard Windows Forms property directly set in InitializeComponent like this.
            // If padding is needed, it's usually handled by a container or custom control.
            // I will keep the BorderStyle setting.
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enter += new System.EventHandler(this.TxtField_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtField_Leave);
            //
            // txtPassword
            //
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(250, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 34); // Adjusted size for Segoe UI 12F
            this.txtPassword.TabIndex = 3;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5); // Kept margin
            // Note: Padding property is not a standard Windows Forms property directly set in InitializeComponent like this.
            // If padding is needed, it's usually handled by a container or custom control.
            // I will keep the BorderStyle setting.
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Enter += new System.EventHandler(this.TxtField_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.TxtField_Leave);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.label2.Location = new System.Drawing.Point(150, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32); // Adjusted size for Segoe UI 14F
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            //
            // btnLogin
            //
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(180, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            //
            // btnRegister
            //
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(330, 210);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            //
            // FormLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

        // Animasyon ve etkileşim efektleri
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == "btnLogin")
                btn.BackColor = Color.FromArgb(0, 123, 255);
            else
                btn.BackColor = Color.FromArgb(40, 167, 69);
        }

        // TextBox için fokus etkisi
        private void TxtField_Enter(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void TxtField_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.BackColor = Color.FromArgb(248, 249, 250);
        }
    }
}