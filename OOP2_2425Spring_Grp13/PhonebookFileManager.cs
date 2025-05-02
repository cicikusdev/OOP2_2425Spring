using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace OOP2_2425Spring_Grp13
{
    internal class PhonebookFileManager
    {
        private static string filePath = "phonebook.csv";
        public static List<FormPhoneBook> LoadPhonebookFromFile()
        {
            List<FormPhoneBook> phonebook = new List<FormPhoneBook>();
            if (!File.Exists(filePath))
                return phonebook;
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 8)
                {
                    phonebook.Add(new FormPhoneBook
                    {
                        id = Guid.Parse(parts[0]),
                        user_id = Guid.Parse(parts[1]),
                        user_name = parts[2],
                        user_surname = parts[3],
                        phone_number = parts[4],
                        email = parts[5],
                        address = parts[6],
                        description = parts[7]
                    });
                }
            }
            return phonebook;
        }
        public static void SavePhonebookToFile(List<FormPhoneBook> phonebook)
        {
            List<string> lines = new List<string>();
            foreach (var entry in phonebook)
            {
                lines.Add($"\"{entry.id}\",\"{entry.user_id}\",\"{entry.user_name}\",\"{entry.user_surname}\",\"{entry.phone_number}\",\"{entry.email}\",\"{entry.address}\",\"{entry.description}\"");
            }
            File.WriteAllLines(filePath, lines);
        }
        public static void UpdatePhonebookEntry(FormPhoneBook updatedEntry)
        {
            var phonebook = LoadPhonebookFromFile();
            var entryIndex = phonebook.FindIndex(entry => entry.id == updatedEntry.id);

            if (entryIndex >= 0)
            {
                phonebook[entryIndex] = updatedEntry;
                SavePhonebookToFile(phonebook);
            }
        }

        public static void DeletePhonebookEntry(Guid entryId)
        {
            var phonebook = LoadPhonebookFromFile();
            var entryIndex = phonebook.FindIndex(entry => entry.id == entryId);
            if (entryIndex >= 0)
            {
                phonebook.RemoveAt(entryIndex);
                SavePhonebookToFile(phonebook);
            }
        }
        public static List<FormPhoneBook> GetAllPhoneBooks()
        {
            return LoadPhonebookFromFile();
        }
        public static FormPhoneBook GetPhonebookEntryById(Guid entryId)
        {
            var phonebook = LoadPhonebookFromFile();
            return phonebook.FirstOrDefault(entry => entry.id == entryId);
        }


    }
}
