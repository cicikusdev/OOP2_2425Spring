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
    public partial class FormPhoneBook : Form
    {
        public FormPhoneBook()
        {
            InitializeComponent();
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

        public static FormPhoneBook from_csv_array(string[] csv_array)
        {
            if (csv_array.Length != 7)
            {
                throw new ArgumentException("CSV formatı doğru değil");
            }
            return new FormPhoneBook
            {
                id = Guid.Parse(csv_array[0]),
                user_id = Guid.Parse(csv_array[1]),
                user_name = csv_array[2],
                user_surname = csv_array[3],
                phone_number = csv_array[4],
                email = csv_array[5],
                address = csv_array[6],
                description = csv_array[7]
            };

        }
    }
}
