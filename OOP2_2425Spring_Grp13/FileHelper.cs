using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_2425Spring_Grp13
{
    public class FileHelper
    {
        private static string filePath = "users.csv";

        public static List<User> LoadUsersFromFile()
        {
            List<User> users = new List<User>();

            if (!File.Exists(filePath))
                return users;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length >= 8)
                {
                    users.Add(new User
                    {
                        Name = parts[0].Trim('"'),
                        Surname = parts[1].Trim('"'),
                        PhoneNumber = parts[2].Trim('"'),
                        Address = parts[3].Trim('"'),
                        Email = parts[4].Trim('"'),
                        Password = parts[5].Trim('"'),
                        UserType = parts[6].Trim('"'),
                        ProfilePhotoBase64 = parts[7].Trim('"')
                    });
                }
            }

            return users;
        }

        public static void SaveUsersToFile(List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (var user in users)
            {
                lines.Add($"\"{user.Name}\",\"{user.Surname}\",\"{user.PhoneNumber}\",\"{user.Address}\",\"{user.Email}\",\"{user.Password}\",\"{user.UserType}\",\"{user.ProfilePhotoBase64}\"");
            }

            File.WriteAllLines(filePath, lines);
        }

    }
}
