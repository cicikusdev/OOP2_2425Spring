using System;
using System.Windows.Forms;
using System.Drawing;

namespace OOP2_2425Spring_Grp13
{
    partial class FormPhoneBook
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
            this.dgv_phonebook = new System.Windows.Forms.DataGridView();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_no = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.tb_phone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phonebook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_phonebook
            // 
            this.dgv_phonebook.AllowUserToAddRows = false;
            this.dgv_phonebook.AllowUserToDeleteRows = false;
            this.dgv_phonebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phonebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phonebook.Location = new System.Drawing.Point(30, 46);
            this.dgv_phonebook.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_phonebook.MultiSelect = false;
            this.dgv_phonebook.Name = "dgv_phonebook";
            this.dgv_phonebook.ReadOnly = true;
            this.dgv_phonebook.RowHeadersWidth = 51;
            this.dgv_phonebook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phonebook.Size = new System.Drawing.Size(359, 226);
            this.dgv_phonebook.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_name.Location = new System.Drawing.Point(413, 46);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(151, 29);
            this.tb_name.TabIndex = 1;
            this.tb_name.Enter += new System.EventHandler(this.TxtField_Enter);
            this.tb_name.Leave += new System.EventHandler(this.TxtField_Leave);
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_surname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_surname.Location = new System.Drawing.Point(413, 103);
            this.tb_surname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(151, 29);
            this.tb_surname.TabIndex = 2;
            this.tb_surname.Enter += new System.EventHandler(this.TxtField_Enter);
            this.tb_surname.Leave += new System.EventHandler(this.TxtField_Leave);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_email.Location = new System.Drawing.Point(413, 219);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(151, 26);
            this.tb_email.TabIndex = 18;
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_address.Location = new System.Drawing.Point(413, 274);
            this.tb_address.Margin = new System.Windows.Forms.Padding(2);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(151, 26);
            this.tb_address.TabIndex = 17;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(416, 23);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(60, 21);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Name:";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_surname.ForeColor = System.Drawing.Color.White;
            this.label_surname.Location = new System.Drawing.Point(416, 80);
            this.label_surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(82, 21);
            this.label_surname.TabIndex = 7;
            this.label_surname.Text = "Surname:";
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_no.ForeColor = System.Drawing.Color.White;
            this.label_no.Location = new System.Drawing.Point(415, 137);
            this.label_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(63, 21);
            this.label_no.TabIndex = 8;
            this.label_no.Text = "Phone:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(415, 195);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(57, 21);
            this.label_email.TabIndex = 9;
            this.label_email.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(415, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address:";
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_desc.ForeColor = System.Drawing.Color.White;
            this.label_desc.Location = new System.Drawing.Point(416, 305);
            this.label_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(102, 21);
            this.label_desc.TabIndex = 11;
            this.label_desc.Text = "Description:";
            // 
            // tb_desc
            // 
            this.tb_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_desc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_desc.Location = new System.Drawing.Point(413, 328);
            this.tb_desc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(151, 29);
            this.tb_desc.TabIndex = 12;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(254, 328);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 29);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(333, 328);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 29);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(175, 328);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 29);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "Delete";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_phone.Location = new System.Drawing.Point(413, 161);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_phone.Mask = "(999) 000-0000";
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(151, 29);
            this.tb_phone.TabIndex = 16;
            // 
            // FormPhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(611, 384);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_no);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.dgv_phonebook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPhoneBook";

            this.Text = "Phone Book";

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPhoneBook_FormClosed);
            this.Load += new System.EventHandler(this.FormPhoneBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phonebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_phonebook;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.MaskedTextBox tb_phone;

        // Animasyon ve hover efektleri
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(0, 123, 255);
        }

        // TextBox için fokus efekti
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
