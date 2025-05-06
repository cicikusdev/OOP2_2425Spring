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
            this.StartPosition = FormStartPosition.CenterScreen; // Form ekranın ortasında başlasın

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

            // Check email format
            if (!EmailGecerliMi(email))
            {
                MessageBox.Show("Invalid e-mail format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find user
            var user = users.Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                // Open panel based on user type
                if (user.UserType == "admin")
                {
                    FormAdminPanel adminPanel = new FormAdminPanel(user);
                    adminPanel.Show();
                }
                else
                {
                    FormUserPanel userPanel = new FormUserPanel(user);
                    userPanel.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect e-mail or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check empty fields
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("E-mail and password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check email format
            if (!EmailGecerliMi(email))
            {
                MessageBox.Show("Invalid e-mail format! Please enter a valid e-mail address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if email already exists
            if (users.Any(u => u.Email == email))
            {
                MessageBox.Show("This email is already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // First user becomes admin
            string userType = users.Count == 0 ? "admin" : "user";

            User newUser = new User
            {
                Name = "Name", // Placeholder
                Surname = "Surname",
                PhoneNumber = "",
                Address = "",
                Email = email,
                Password = password,
                UserType = userType,
                ProfilePhotoBase64 = "",
            };

            users.Add(newUser);
            FileHelper.SaveUsersToFile(users);
            users = FileHelper.LoadUsersFromFile();
            MessageBox.Show("User registered successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Email ve şifre kutularını temizlemiyoruz ki login için tekrar girilmesin
            // txtEmail.Clear();
            // txtPassword.Clear();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
