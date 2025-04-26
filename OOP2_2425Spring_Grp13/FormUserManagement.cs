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
    public partial class FormUserManagement : Form
    {
        private List<User> users;
        private User currentUser;
        public FormUserManagement(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            users = FileHelper.LoadUsersFromFile();

            cmbUserType.Items.Add("admin");
            cmbUserType.Items.Add("user");
            cmbUserType.Items.Add("part-time-user");

            LoadUsers();
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

            if (selectedUser != null)
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
                e.Cancel = true;
            }
        }
    }
}
