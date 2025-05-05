// SalaryCalculatorForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// SalaryParameters ve SalaryCalculator sınıflarının namespace'ini ekleyin
using OOP2_2425Spring_Grp13; // Eğer aynı namespace'te değillerse

namespace OOP2_2425Spring_Grp13
{
    public partial class FormSalaryCalculator : Form
    {
        private User currentUser;
        public FormSalaryCalculator(User _currentUser)
        {
            InitializeComponent();
            PopulateCityComboBox();
            PopulatePositionComboBox();
            PopulateEducationCheckList();
            this.currentUser = _currentUser;
        }

        private void PopulateCityComboBox()
        {
            cmbCity.Items.AddRange(new string[]
            {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya",
                "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir",
                "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis",
                "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum",
                "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan",
                "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir",
                "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu",
                "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis",
                "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin",
                "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu",
                "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop",
                "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon",
                "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"
            });
        }

        private void PopulatePositionComboBox()
        {
            cmbPosition.Items.AddRange(new string[]
            {
                "Team Leader/Group Manager/Technical Manager/Software Architect",
                "Project Manager",
                "Director/Project Director",
                "CTO/General Manager",
                "IT Supervisor/Manager (<=5 people)",
                "IT Supervisor/Manager (>5 people)"
            });
        }

        private void PopulateEducationCheckList()
        {
            clbEducation.Items.AddRange(new string[]
            {
                "Master's degree in related field",
                "PhD in related field",
                "Associate Professorship in related field",
                "Master's degree in unrelated field",
                "PhD/Associate Professorship in unrelated field"
            });
        }


        private double GetExperienceFactor()
        {
            int experience = (int)numericExperience.Value;
            if (experience >= 2 && experience <= 4) return 0.60;
            if (experience >= 5 && experience <= 9) return 1.00;
            if (experience >= 10 && experience <= 14) return 1.20;
            if (experience >= 15 && experience <= 20) return 1.35;
            if (experience > 20) return 1.50;
            return 0;
        }

        private double GetLocationFactor()
        {
            if (cmbCity.SelectedItem == null) return 0;

            Dictionary<string, double> locationFactors = new Dictionary<string, double>
            {
                { "Istanbul", 0.30 },
                { "Ankara", 0.20 },
                { "Izmir", 0.20 },
                { "Kocaeli, Sakarya, Duzce, Bolu, Yalova", 0.10 },
                { "Edirne, Kirklareli, Tekirdag", 0.10 },
                { "Trabzon, Ordu, Giresun, Rize, Artvin, Gumushane", 0.05 },
                { "Bursa, Eskisehir, Bilecik", 0.05 },
                { "Aydin, Denizli, Mugla", 0.05 },
                { "Adana, Mersin", 0.05 },
                { "Balikesir, Canakkale", 0.05 },
                { "Antalya, Isparta, Burdur", 0.05 }
            };

            return locationFactors.TryGetValue(cmbCity.SelectedItem.ToString(), out double value) ? value : 0;
        }

        private double GetEducationFactor()
        {
            double factor = 0;
            foreach (var item in clbEducation.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "Master's degree in related field": factor += 0.10; break;
                    case "PhD in related field": factor += 0.30; break;
                    case "Associate Professorship in related field": factor += 0.35; break;
                    case "Master's degree in unrelated field": factor += 0.05; break;
                    case "PhD/Associate Professorship in unrelated field": factor += 0.15; break;
                }
            }
            return factor;
        }

        private double GetLanguageFactor()
        {
            double factor = 0;
            if (rbCertifiedEnglish.Checked) factor += 0.20;
            if (rbEnglishGraduate.Checked) factor += 0.20;
            if (int.TryParse(numericOtherLanguage.Value.ToString(), out int otherLangs))
            {
                factor += 0.05 * otherLangs;
            }
            return factor;
        }

        private double GetManagerialFactor()
        {
            string position = cmbPosition.Text;
            switch (position)
            {
                case "Team Leader/Group Manager/Technical Manager/Software Architect": return 0.50;
                case "Project Manager": return 0.75;
                case "Director/Project Director": return 0.85;
                case "CTO/General Manager": return 1.00;
                case "IT Supervisor/Manager (<=5 people)": return 0.40;
                case "IT Supervisor/Manager (>5 people)": return 0.60;
                default: return 0;
            }
        }

        private double GetFamilyFactor()
        {
            double factor = 0;
            if (cbWife.Checked) factor += 0.20;
            int childCount = (int)numericChildren.Value;

            if (childCount > 0)
            {
                if (childCount <= 1) factor += 0.20;
                else if (childCount <= 2) factor += 0.30;
                else factor += 0.40;
            }

            return factor;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float baseSalary = 22104.67f;

            double experienceFactor = GetExperienceFactor();
            double locationFactor = GetLocationFactor();
            double educationFactor = GetEducationFactor();
            double languageFactor = GetLanguageFactor();
            double managerialFactor = GetManagerialFactor();
            double familyFactor = GetFamilyFactor();

            double totalFactor = 1 + experienceFactor + locationFactor + educationFactor + languageFactor + managerialFactor + familyFactor;
            double finalSalary = baseSalary * totalFactor;

            labelCalculatedSalary.Text = $" Calculated Salary: {finalSalary:F2} TL";
            if(currentUser.UserType == "admin" || currentUser.UserType == "user")
            {
                currentUser.UserSalary = (float)finalSalary;
            }
            else if(currentUser.UserType == "part-time-user")
            {
                currentUser.UserSalary = (float)finalSalary / 2;
            }
            else
            {
                currentUser.UserSalary = 0f;
            }
        }

        
    }


}
