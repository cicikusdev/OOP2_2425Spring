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
    public partial class FormUserPanel : Form
    {
        private User currentUser;

        public FormUserPanel(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void btnGoToPersonalInfo_Click(object sender, EventArgs e)
        {
            FormPersonalInfo personalInfo = new FormPersonalInfo(currentUser, this);
            personalInfo.Show();
            this.Hide();
        }

        private void btnGoToPhoneBook_Click(object sender, EventArgs e)
        {
            FormPhoneBook phoneBook = new FormPhoneBook(this, currentUser);
            phoneBook.Show();
            this.Hide();

        }

        private void btnGoToNotes_Click(object sender, EventArgs e)
        {
             FormNotes notes = new FormNotes(currentUser, this);
            notes.Show();
            this.Hide();

        }

        private void btnGoToSalaryCalculator_Click(object sender, EventArgs e)
        {
            FormSalaryCalculator salaryForm = new FormSalaryCalculator(currentUser, this);
            salaryForm.Show();
            this.Hide();

        }

        private void btnGoToReminders_Click(object sender, EventArgs e)
        {
            nFormReminder reminders = new nFormReminder(this);
            reminders.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        private void FormUserPanel_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
