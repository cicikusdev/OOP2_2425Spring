namespace OOP2_2425Spring_Grp13
{
    partial class FormPhoneBook
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
            this.dgv_phonebook = new System.Windows.Forms.DataGridView();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phonebook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_phonebook
            // 
            this.dgv_phonebook.AllowUserToAddRows = false;
            this.dgv_phonebook.AllowUserToDeleteRows = false;
            this.dgv_phonebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_phonebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phonebook.Location = new System.Drawing.Point(40, 27);
            this.dgv_phonebook.MultiSelect = false;
            this.dgv_phonebook.Name = "dgv_phonebook";
            this.dgv_phonebook.ReadOnly = true;
            this.dgv_phonebook.RowHeadersWidth = 51;
            this.dgv_phonebook.RowTemplate.Height = 24;
            this.dgv_phonebook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phonebook.Size = new System.Drawing.Size(479, 278);
            this.dgv_phonebook.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(551, 51);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 22);
            this.tb_name.TabIndex = 1;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(551, 105);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 22);
            this.tb_surname.TabIndex = 2;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(551, 160);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(100, 22);
            this.tb_phone.TabIndex = 3;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(551, 218);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 22);
            this.tb_email.TabIndex = 4;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(551, 283);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(100, 22);
            this.tb_address.TabIndex = 5;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(548, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(24, 16);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Ad";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(548, 86);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(47, 16);
            this.label_surname.TabIndex = 7;
            this.label_surname.Text = "Soyad";
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Location = new System.Drawing.Point(548, 141);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(53, 16);
            this.label_no.TabIndex = 8;
            this.label_no.Text = "Telefon";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(548, 199);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 16);
            this.label_email.TabIndex = 9;
            this.label_email.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres";
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Location = new System.Drawing.Point(552, 325);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(63, 16);
            this.label_desc.TabIndex = 11;
            this.label_desc.Text = "Açıklama";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(551, 344);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(100, 22);
            this.tb_desc.TabIndex = 12;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(551, 388);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 23);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(662, 388);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(551, 417);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 23);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "Kullanıcı Sil";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // FormPhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
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
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.dgv_phonebook);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FormPhoneBook";
            this.Text = "FormPhoneBook";
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
        private System.Windows.Forms.TextBox tb_phone;
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
    }
}