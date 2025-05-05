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
    public partial class FormAdminPanel : Form
    {
        private User currentUser;
        public FormAdminPanel(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void btnGoToUserManagement_Click(object sender, EventArgs e)
        {
            FormUserManagement userManagement = new FormUserManagement(currentUser, this);
            this.Hide();
            userManagement.Show();
        }

        private void FormAdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Kapatmayı iptal et
            }
            else
            {
                Application.Exit(); // Uygulamayı tamamen kapat
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }
    }
}
