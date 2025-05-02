using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = users.Find(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Name}!");

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
                MessageBox.Show("Incorrect Email or Password!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and Password cannot be empty!");
                return;
            }

            // eğer sistemde hiç kullanıcı yoksa --> Admin yap
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
            MessageBox.Show("User Registered Successfully!");

            txtEmail.Clear();
            txtPassword.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
