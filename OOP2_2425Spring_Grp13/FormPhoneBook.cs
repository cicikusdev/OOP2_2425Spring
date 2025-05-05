using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP2_2425Spring_Grp13
{
    public partial class FormPhoneBook : Form
    {
        private Form previous_form;
        private List<FormPhoneBook> phonebook_list;

        

        public FormPhoneBook()
        {
            InitializeComponent();
        }
        public FormPhoneBook(Form previous_form)
        {
            InitializeComponent();
            this.previous_form = previous_form;
        }
        
        public Guid id { get; set; }
        public Guid user_id { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string description { get; set; }


        public string[] to_csv_array()
        {
            return new string[]
            {
                id.ToString(),
                user_id.ToString(),
                user_name,
                user_surname,
                phone_number,
                email,
                address,
                description
            };

        }

        public static FormPhoneBook from_csv_array(string[] csv_array, Form previous_form)
        {
            if (csv_array.Length != 8)
            {
                throw new ArgumentException("CSV formatı doğru değil");
            }

            FormPhoneBook formPhoneBook = new FormPhoneBook(previous_form);
            formPhoneBook.id = Guid.Parse(csv_array[0]);
            formPhoneBook.user_id = Guid.Parse(csv_array[1]);
            formPhoneBook.user_name = csv_array[2];
            formPhoneBook.user_surname = csv_array[3];
            formPhoneBook.phone_number = csv_array[4];
            formPhoneBook.email = csv_array[5];
            formPhoneBook.address = csv_array[6];
            formPhoneBook.description = csv_array[7];

            return formPhoneBook;
        }
    
       //public void load_phonelist()
       // {
       //     dgv_phonebook.DataSource = null; // DataGridView'ı temizle
       //     dgv_phonebook.DataSource = phonebook_list; // Yeni listeyi ata

       // }

        private void FormPhoneBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_surname.Clear();
            tb_phone.Clear();
            tb_email.Clear();
            tb_address.Clear();
            tb_desc.Clear();

        }

        private bool IsUserExists() // Artık parametreye gerek yok, text box'ları kullanacak
        {
            // Eğer liste henüz yüklenmediyse veya boşsa, kullanıcı mevcut değildir.
            if (phonebook_list == null || phonebook_list.Count == 0)
            {
                return false;
            }

            // Bellekteki listede, formdaki textbox'larla eşleşen bir kayıt var mı kontrol et
            return phonebook_list.Any(user => user.user_name == tb_name.Text.Trim() &&
                                             user.user_surname == tb_surname.Text.Trim() &&
                                             user.phone_number == tb_phone.Text.Trim() &&
                                             user.address == tb_address.Text.Trim() &&
                                             user.email == tb_email.Text.Trim()); 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text) || string.IsNullOrWhiteSpace(tb_surname.Text) ||
                string.IsNullOrWhiteSpace(tb_phone.Text) || string.IsNullOrWhiteSpace(tb_email.Text) ||
                string.IsNullOrWhiteSpace(tb_address.Text) || string.IsNullOrWhiteSpace(tb_desc.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_name.Text) || tb_name.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ad sadece harf ve boşluk içerebilir.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_surname.Text) || tb_surname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Soyad sadece harf ve boşluk içerebilir.");
                return;
            }


            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(tb_email.Text.Trim(), emailPattern))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin.");
                return;
            }

            if (IsUserExists())
            {
                MessageBox.Show("Bu kullanıcı zaten mevcut.");
                return;
            }

            FormPhoneBook new_entry = new FormPhoneBook();


            new_entry.user_id = Guid.NewGuid(); // Generate new user ID
            new_entry.id = Guid.NewGuid();
            new_entry.user_name = tb_name.Text.Trim();
            new_entry.user_surname = tb_surname.Text.Trim();
            new_entry.phone_number = tb_phone.Text.Trim();
            new_entry.email = tb_email.Text.Trim();
            new_entry.address = tb_address.Text.Trim();
            new_entry.description = tb_desc.Text.Trim();

            if (phonebook_list != null)
            {
                phonebook_list.Add(new_entry);
                PhonebookFileManager.SavePhonebookToFile(phonebook_list);
                MessageBox.Show("Kayıt başarıyla kaydedildi.");
                dgv_phonebook.DataSource = null; // DataGridView'ı temizle
                dgv_phonebook.DataSource = phonebook_list; // Yeni listeyi ata
                dgv_phonebook.Refresh(); // DataGridView'ı yenile
            }
            else
            {
                MessageBox.Show("Kullanıcı listesi yüklenemedi.");
            }

        }


        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_phonebook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek için bir kullanıcı seçin.");
                return;
            }

            var selected_entry = dgv_phonebook.SelectedRows[0].DataBoundItem as FormPhoneBook;

            if (selected_entry != null && phonebook_list != null)
            {
                phonebook_list.Remove(selected_entry);
                PhonebookFileManager.SavePhonebookToFile(phonebook_list);
                MessageBox.Show("Kullanıcı başarıyla silindi.");
                dgv_phonebook.DataSource = null; // DataGridView'ı temizle
                dgv_phonebook.DataSource = phonebook_list; // Yeni listeyi ata
                dgv_phonebook.Refresh(); // DataGridView'ı yenile
            }
            else
            {
                MessageBox.Show("Silinecek kullanıcı bulunamadı.");
            }
                        
        }

        private void FormPhoneBook_Load(object sender, EventArgs e)
        {

            dgv_phonebook.AutoGenerateColumns = false; // DataGridView'da otomatik sütun oluşturmayı kapat

            dgv_phonebook.Columns.Clear(); // Mevcut sütunları temizle

            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "idColumn", HeaderText = "ID", DataPropertyName = "id", Visible = false });
            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "userIdColumn", HeaderText = "User ID", DataPropertyName = "user_id", Visible = false });

            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "UserNameColumn", HeaderText = "Ad", DataPropertyName = "user_name" });
            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "UserSurnameColumn", HeaderText = "Soyad", DataPropertyName = "user_surname" });
            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PhoneNumberColumn", HeaderText = "Telefon", DataPropertyName = "phone_number" });
            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "EmailColumn", HeaderText = "E-posta", DataPropertyName = "email" });
            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "AddressColumn", HeaderText = "Adres", DataPropertyName = "address" });
            dgv_phonebook.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DescriptionColumn", HeaderText = "Açıklama", DataPropertyName = "description" });


            phonebook_list = PhonebookFileManager.LoadPhonebookFromFile();
            if (phonebook_list != null)
            {
                dgv_phonebook.DataSource = phonebook_list; // DataGridView'a listeyi ata
                dgv_phonebook.Refresh(); // DataGridView'ı yenile
            }
            else
            {
                MessageBox.Show("Kullanıcı listesi yüklenemedi.");
            }
        }

       
    }
}
