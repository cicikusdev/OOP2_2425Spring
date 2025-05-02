using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace OOP2_2425Spring_Grp13
{
    public partial class FormUserManagement : Form
    {
        private List<User> users;
        private User currentUser;
        private Form previousForm;
        public FormUserManagement(User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            users = FileHelper.LoadUsersFromFile();

            cmbUserType.Items.Add("admin");
            cmbUserType.Items.Add("user");
            cmbUserType.Items.Add("part-time-user");

            LoadUsers();
            this.previousForm = previousForm;
        }
        private void LoadUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users;
        }
        private void btnChangeType_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            var selectedEmail = dgvUsers.SelectedRows[0].Cells["Email"].Value.ToString();
            var selectedUser = users.Find(u => u.Email == selectedEmail);

            if (dgvUsers.SelectedRows.Count != 0 || cmbUserType.SelectedItem != null)
            {
                selectedUser.UserType = cmbUserType.SelectedItem?.ToString();
                FileHelper.SaveUsersToFile(users);
                LoadUsers();
                MessageBox.Show("User type updated successfully!");
            }
        }
        private void FormUserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Kapatmayı iptal et
            }
            else
            {
                previousForm.Show(); // Geldiği formu geri aç
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private async void btnSendNewPassword_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user.");
                return;
            }

            var selectedEmail = dgvUsers.SelectedRows[0].Cells["Email"].Value.ToString();
            var user = users.Find(u => u.Email == selectedEmail);

            if (user != null)
            {
                string newPassword = GenerateRandomPassword(); // Şifreyi üret
                user.Password = newPassword;

                progressBar1.Value = 0;
                for (int i = 0; i <= 100; i += 20)
                {
                    await Task.Delay(100);
                    progressBar1.Value = i;
                }

                try
                {
                    SendEmail(user.Email, newPassword); // Maili gönder
                    FileHelper.SaveUsersToFile(users);  // CSV'ye kaydet
                    LoadUsers(); // Grid güncelle
                    MessageBox.Show("Password sent successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send email: " + ex.Message);
                }
            }
        }

        private string GenerateRandomPassword()
        {
            return Guid.NewGuid().ToString().Substring(0, 8); // 8 karakterlik random
        }

        private void SendEmail(string toEmail, string newPassword)
        {
            var fromAddress = new MailAddress("seningmail@gmail.com", "Admin Panel");
            var toAddress = new MailAddress(toEmail);
            const string subject = "Your New Password";
            string body = $"Your new password is: {newPassword}";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587, // SSL için 465 portu kullanılıyor
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("seningmail@gmail.com", "UYGULAMA_SIFRESI") // Uygulama şifresi
             };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
