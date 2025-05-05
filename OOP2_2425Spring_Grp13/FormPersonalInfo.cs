using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP2_2425Spring_Grp13
{
    public partial class FormPersonalInfo : Form
    {
        private User currentUser;
        private Stack<User> undoStack = new Stack<User>();
        private Stack<User> redoStack = new Stack<User>();
        
        public FormPersonalInfo(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            LoadUserInfo();
            UpdateSalary();
        }
        private void LoadUserInfo()
        {
            txtName.Text = currentUser.Name;
            txtSurname.Text = currentUser.Surname;
            txtPhone.Text = currentUser.PhoneNumber;
            txtAddress.Text = currentUser.Address;
            txtEmail.Text = currentUser.Email;
            txtPassword.Text = currentUser.Password;
            if (!string.IsNullOrEmpty(currentUser.ProfilePhotoBase64))
            {
                byte[] imageBytes = Convert.FromBase64String(currentUser.ProfilePhotoBase64);
                using (var ms = new MemoryStream(imageBytes))
                {
                    pictureBoxProfile.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCurrentStateForUndo();

            currentUser.Name = txtName.Text;
            currentUser.Surname = txtSurname.Text;
            currentUser.PhoneNumber = txtPhone.Text;
            currentUser.Address = txtAddress.Text;
            currentUser.Email = txtEmail.Text;
            currentUser.Password = txtPassword.Text;
            // Fotoğraf kaydı vs

            var allUsers = FileHelper.LoadUsersFromFile();
            var userInList = allUsers.Find(u => u.Email == currentUser.Email);
            if (userInList != null)
            {
                // Update the user
                userInList.Name = currentUser.Name;
                userInList.Surname = currentUser.Surname;
                userInList.PhoneNumber = currentUser.PhoneNumber;
                userInList.Address = currentUser.Address;
                userInList.Password = currentUser.Password;
                userInList.ProfilePhotoBase64 = currentUser.ProfilePhotoBase64;
                FileHelper.SaveUsersToFile(allUsers);
            }

            MessageBox.Show("Profile Updated!");
        }

        private void SaveCurrentStateForUndo()
        {
            undoStack.Push(new User
            {
                Name = currentUser.Name,
                Surname = currentUser.Surname,
                PhoneNumber = currentUser.PhoneNumber,
                Address = currentUser.Address,
                Email = currentUser.Email,
                Password = currentUser.Password,
                ProfilePhotoBase64 = currentUser.ProfilePhotoBase64,
                UserType = currentUser.UserType
            });
        }

        private void FormPersonalInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z && undoStack.Count > 0)
            {
                var lastState = undoStack.Pop();
                redoStack.Push(currentUser);
                currentUser = lastState;
                LoadUserInfo();
            }
            else if (e.Control && e.KeyCode == Keys.Y && redoStack.Count > 0)
            {
                var redoState = redoStack.Pop();
                undoStack.Push(currentUser);
                currentUser = redoState;
                LoadUserInfo();
            }
        }

        private void FormPersonalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select a Profile Photo";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Fotoğrafı göster
                    pictureBoxProfile.Image = Image.FromFile(ofd.FileName);

                    // Fotoğrafı base64'e çevir ve kaydet
                    byte[] imageBytes = File.ReadAllBytes(ofd.FileName);
                    currentUser.ProfilePhotoBase64 = Convert.ToBase64String(imageBytes);
                }
            }
        }

        public void UpdateSalary()
        {
            lblSalaryAmount.Text = $"{currentUser.UserSalary} TL";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
