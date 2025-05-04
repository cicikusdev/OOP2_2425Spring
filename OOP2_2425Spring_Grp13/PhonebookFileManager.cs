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

            try // Added try-catch for better error handling during parsing
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    // Handle potential empty lines
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Split while ignoring commas within quotes (simple approach)
                    // A more robust CSV parser is better for complex cases,
                    // but this might work for your current save format.
                    // Let's assume the split works correctly with the quotes for now
                    // and focus on the main add issue.
                    var parts = line.Split(',');

                    if (parts.Length >= 8)
                    {
                        FormPhoneBook formPhoneBook = new FormPhoneBook();
                        try // Added inner try-catch for parsing specific lines
                        {
                            // Trim quotes when parsing - assuming each field is quoted
                            // If fields might NOT be quoted, this needs adjustment.
                            // Let's try trimming quotes first for the string fields.
                            // GUIDs might handle quotes or just need trimming if parse fails.

                            formPhoneBook.id = Guid.Parse(parts[0].Trim('"'));
                            formPhoneBook.user_id = Guid.Parse(parts[1].Trim('"'));
                            formPhoneBook.user_name = parts[2].Trim('"');
                            formPhoneBook.user_surname = parts[3].Trim('"');
                            formPhoneBook.phone_number = parts[4].Trim('"');
                            formPhoneBook.email = parts[5].Trim('"');
                            formPhoneBook.address = parts[6].Trim('"');
                            formPhoneBook.description = parts[7].Trim('"');

                            // *** ADD THE OBJECT TO THE LIST ***
                            phonebook.Add(formPhoneBook);
                        }
                        catch (FormatException ex)
                        {
                            // Handle cases where a specific line fails parsing (e.g., bad GUID format)
                            Console.WriteLine($"Error parsing line: {line}. Error: {ex.Message}");
                            // Optionally log the error or skip the line
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            // Handle cases where a line has fewer than 8 parts unexpectedly
                            Console.WriteLine($"Error splitting line: {line}. Expected 8 parts, got {parts.Length}. Error: {ex.Message}");
                            // Optionally log the error or skip the line
                        }
                    }
                    else
                    {
                        // Handle lines that don't have the expected number of parts
                        Console.WriteLine($"Skipping malformed line: {line}. Expected 8 parts, got {parts.Length}.");
                        // Optionally log the error
                    }
                }
            }
            catch (Exception ex) // Catch potential errors during file reading
            {
                Console.WriteLine($"Error reading or processing file {filePath}: {ex.Message}");
                // Depending on requirements, you might re-throw the exception or handle it gracefully
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
