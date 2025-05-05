using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OOP2_2425Spring_Grp13
{
    public partial class FormNotes : Form
    {
        private User currentUser;
        private List<(string note, DateTime dateTime)> notes = new List<(string, DateTime)>();
        private Form previousForm;

        public FormNotes(User currentUser, Form previousForm)
        {
            InitializeComponent();
            // Başlangıçta her iki buton da pasif
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // tbNoteDetailed'i sadece okunabilir yap
            tbNoteDetailed.ReadOnly = true;  // Kullanıcı tarafından yazılamaz

            // OwnerDraw özelliğini etkinleştir
            lbNotes.DrawMode = DrawMode.OwnerDrawFixed;
            lbNotes.MeasureItem += lbNotes_MeasureItem;
            lbNotes.DrawItem += lbNotes_DrawItem;

            // Uygulama başladığında CSV'den notları yükle
            LoadNotesFromCSV("notes.csv");
            this.currentUser = currentUser;
            this.previousForm = previousForm;
        }

        // ListBox'taki öğelerin boyutunu ayarlama (Öğeler arasına boşluk eklemek)
        private void lbNotes_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Öğelerin yüksekliğini ayarlıyoruz, böylece öğeler arasında boşluk olacak
            e.ItemHeight = 30; // Yüksekliği artırarak boşluk ekliyoruz (isteğe bağlı)
        }

        // ListBox'taki öğeleri çizme
        private void lbNotes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                // Öğeyi çiziyoruz
                string text = lbNotes.Items[e.Index].ToString();
                e.DrawBackground();
                e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        // Add butonu tıklanma işlemi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string note = tbNote.Text.Trim();

            // Eğer not boş değilse, listeye ekle
            if (!string.IsNullOrEmpty(note))
            {
                DateTime currentDateTime = DateTime.Now; // Geçerli tarih ve saat
                notes.Add((note, currentDateTime));  // Notu ve tarih/saat bilgisini listeye ekler
                lbNotes.Items.Add(note); // ListBox'a sadece notu ekler
                tbNote.Clear(); // TextBox'ı temizler

                // Notları CSV'ye kaydet
                SaveNotesToCSV("notes.csv");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir not giriniz.");
            }

            // Her yeni eklemede butonları kontrol et
            CheckButtons();
        }

        // Update butonu tıklanma işlemi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string note = tbNote.Text.Trim();

            if (lbNotes.SelectedIndex != -1 && !string.IsNullOrEmpty(note))
            {
                // Seçilen notu güncelle
                int selectedIndex = lbNotes.SelectedIndex;
                DateTime currentDateTime = DateTime.Now; // Geçerli tarih ve saat
                notes[selectedIndex] = (note, currentDateTime);  // Listeyi günceller
                lbNotes.Items[selectedIndex] = note; // ListBox'ı günceller
                tbNote.Clear(); // TextBox'ı temizler

                // Notları CSV'ye kaydet
                SaveNotesToCSV("notes.csv");
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir not seçin ve geçerli bir not girin.");
            }

            // Butonları kontrol et
            CheckButtons();
        }

        // Delete butonu tıklanma işlemi
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbNotes.SelectedIndex != -1)
            {
                // Seçilen notu sil
                int selectedIndex = lbNotes.SelectedIndex;
                notes.RemoveAt(selectedIndex); // Listeden sil
                lbNotes.Items.RemoveAt(selectedIndex); // ListBox'tan sil
                tbNoteDetailed.Clear(); // Detaylı TextBox'ı temizle

                // Notları CSV'ye kaydet
                SaveNotesToCSV("notes.csv");
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir not seçin.");
            }

            // Butonları kontrol et
            CheckButtons();
        }

        // ListBox'tan bir not seçildiğinde detayları TextBox'ta gösterme
        private void lbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNotes.SelectedIndex != -1)
            {
                // Seçilen notu ve tarih/saat bilgisini al
                var selectedNote = notes[lbNotes.SelectedIndex];
                string noteText = selectedNote.note;
                string dateTimeText = $"Added on: {selectedNote.dateTime.ToString("yyyy-MM-dd HH:mm:ss")}";

                // TextBox içinde notu ve tarih bilgisini göster
                tbNoteDetailed.Text = noteText + "\r\n\r\n" + dateTimeText; // 2 satır boşluk bırak
            }

            // Butonları kontrol et
            CheckButtons();
        }

        // TextBox içinde bir şey yazıldığında, Update butonunun aktif olmasını sağla
        private void tbNote_TextChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        // Butonların aktiflik durumunu kontrol eden fonksiyon
        private void CheckButtons()
        {
            // Eğer bir öğe seçiliyse ve TextBox'ta yazı varsa, Update butonunu aktif et
            if (lbNotes.SelectedIndex != -1 && !string.IsNullOrEmpty(tbNote.Text.Trim()))
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }

            // Eğer bir öğe seçiliyse, Delete butonunu aktif et
            if (lbNotes.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        // CSV dosyasına notları kaydetme
        public void SaveNotesToCSV(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var note in notes)
                    {
                        // CSV formatında tarih ve notu yazıyoruz
                        string line = $"\"{note.dateTime:yyyy-MM-dd HH:mm:ss}\",\"{note.note}\"";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving notes to file: {ex.Message}");
            }
        }

        // CSV dosyasından notları okuma
        public void LoadNotesFromCSV(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(',');

                            if (parts.Length == 2)
                            {
                                DateTime dateTime = DateTime.Parse(parts[0].Trim('"'));
                                string note = parts[1].Trim('"');

                                notes.Add((note, dateTime));
                                lbNotes.Items.Add(note);  // ListBox'a da ekliyoruz
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes from file: {ex.Message}");
            }
        }

        private void FormNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Kapatmayı iptal et
            }
            else
            {

                previousForm?.Show(); // Null kontrolü ekleyelim
            }
        }
    }
}
