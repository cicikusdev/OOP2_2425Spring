using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kullanıcı nesnesi, kaydolanları yönetmek için vs

namespace OOP2_2425Spring_Grp13
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; } // admin mi user mı part-time-user mı kontrol
        public string ProfilePhotoBase64 { get; set; }
    }
}
