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
        public static List<FormPhoneBook> LoadPhonebookFromFile(int userId)
        {
            List<FormPhoneBook> phonebook = new List<FormPhoneBook>();
            if (!File.Exists(filePath))
                return phonebook;

            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split(',');

                    if (parts.Length >= 8)
                    {
                        try
                        {
                            FormPhoneBook formPhoneBook = new FormPhoneBook
                            {
                                id = Guid.Parse(parts[0].Trim('"')),
                                user_id = Guid.Parse(parts[1].Trim('"')),
                                user_name = parts[2].Trim('"'),
                                user_surname = parts[3].Trim('"'),
                                phone_number = parts[4].Trim('"'),
                                email = parts[5].Trim('"'),
                                address = parts[6].Trim('"'),
                                description = parts[7].Trim('"')
                            };

                            // Sadece belirtilen userId'ye ait kayıtları ekle
                            if (formPhoneBook.user_id == Guid.Parse(userId.ToString()))
                            {
                                phonebook.Add(formPhoneBook);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error parsing line: {line}. Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Skipping malformed line: {line}. Expected 8 parts, got {parts.Length}.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading or processing file {filePath}: {ex.Message}");
            }

            return phonebook;
        }



        public static void SavePhonebookToFile(List<FormPhoneBook> phonebook)
        {
            List<string> lines = new List<string>();

            // Mevcut dosyayı oku
            if (File.Exists(filePath))
            {
                lines.AddRange(File.ReadAllLines(filePath));
            }

            // Yeni kayıtları ekle veya güncelle
            foreach (var entry in phonebook)
            {
                var existingLineIndex = lines.FindIndex(line => line.StartsWith($"\"{entry.id}\""));
                var newLine = $"\"{entry.id}\",\"{entry.user_id}\",\"{entry.user_name}\",\"{entry.user_surname}\",\"{entry.phone_number}\",\"{entry.email}\",\"{entry.address}\",\"{entry.description}\"";

                if (existingLineIndex >= 0)
                {
                    // Mevcut kaydı güncelle
                    lines[existingLineIndex] = newLine;
                }
                else
                {
                    // Yeni kayıt ekle
                    lines.Add(newLine);
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        public static void UpdatePhonebookEntry(FormPhoneBook updatedEntry, int userId)
        {
            var phonebook = LoadPhonebookFromFile(userId);
            var entryIndex = phonebook.FindIndex(entry => entry.id == updatedEntry.id);

            if (entryIndex >= 0)
            {
                phonebook[entryIndex] = updatedEntry;
                SavePhonebookToFile(phonebook);
            }
        }

        public static void DeletePhonebookEntry(Guid entryId)
        {
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath).ToList();
            var lineIndex = lines.FindIndex(line => line.StartsWith($"\"{entryId}\""));

            if (lineIndex >= 0)
            {
                lines.RemoveAt(lineIndex);
                File.WriteAllLines(filePath, lines);
            }
        }

        public static List<FormPhoneBook> GetAllPhoneBooks(int userId)
        {
            return LoadPhonebookFromFile(userId);
        }


    }
}
