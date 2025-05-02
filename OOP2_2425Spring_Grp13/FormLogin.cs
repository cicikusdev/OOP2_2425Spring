using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OOP2_2425Spring_Grp13
{
    public partial class FormLogin : Form
    {
        List<User> users;
        public FormLogin()
        {
            InitializeComponent();
            users = FileHelper.LoadUsersFromFile();
        }

        private bool EmailGecerliMi(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Önce email formatını kontrol et
            if (!EmailGecerliMi(email))
            {
                MessageBox.Show("Email formatı hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sonra kullanıcı kontrolü yap
            var user = users.Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                // Kullanıcı bulundu, tipine göre paneli aç
                if (user.UserType == "admin")
                {
                    FormAdminPanel adminPanel = new FormAdminPanel(user);
                    adminPanel.Show();
                }
                else
                {
                    FormUserPanel userPanel = new FormUserPanel(user); // kullanıcı bilgisi ile açıyoruz
                    userPanel.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and Password cannot be empty!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email format kontrolü
            if (!EmailGecerliMi(email))
            {
                MessageBox.Show("Email formatı hatalı! Lütfen geçerli bir email giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı daha önce kayıt oldu mu kontrolü
            if (users.Any(u => u.Email == email))
            {
                MessageBox.Show("This email is already registered!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Eğer sistemde hiç kullanıcı yoksa --> Admin yap
            string userType = users.Count == 0 ? "admin" : "user";

            User newUser = new User
            {
                Name = "Name",    // Şimdilik sabit, daha sonra ek inputlar açarız
                Surname = "Surname",
                PhoneNumber = "",
                Address = "",
                Email = email,
                Password = password,
                UserType = userType,
                ProfilePhotoBase64 = ""
            };

            users.Add(newUser);
            FileHelper.SaveUsersToFile(users);
            users = FileHelper.LoadUsersFromFile();
            MessageBox.Show("User Registered Successfully!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}
