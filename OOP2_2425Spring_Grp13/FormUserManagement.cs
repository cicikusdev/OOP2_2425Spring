using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using System.Configuration; // Ayar dosyasını kullanmak istersen bunu ekle

namespace OOP2_2425Spring_Grp13
{
    public partial class FormUserManagement : Form
    {
        // --- Sabitler ve Ayarlar ---
        // Kullanıcı tiplerini ve DataGridView kolon adını sabit olarak tanımlamak,
        // yazım hatalarını azaltır ve kodu daha okunabilir yapar.
        private const string UserTypeAdmin = "admin";
        private const string UserTypeUser = "user";
        private const string UserTypePartTime = "part-time-user";
        private const string EmailColumnName = "Email"; // DataGridView'deki e-posta kolonu adı

        // E-posta gönderimi için ayarlar (Daha iyisi: Bunları app.config gibi bir ayar dosyasından okumak)
        // TODO: Bu bilgileri koddan çıkarıp bir ayar dosyasına taşı!
        private const string SmtpHost = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string SenderEmail = "umayece2@gmail.com"; // Gönderen e-posta adresi
        private const string SenderName = "Admin Panel";
        // TODO: "UYGULAMA_SIFRESI" yerine gerçek Google Uygulama Şifreni yazmalısın!
        private const string SenderAppPassword = "kkro xvww xyrl qduu";

        private List<User> users;
        private User currentUser; // Bu formu açan yönetici kullanıcı
        private Form previousForm;

        public FormUserManagement(User currentUser, Form previousForm)
        {
            InitializeComponent();
            this.currentUser = currentUser; // Giriş yapan yönetici bilgisini sakla (belki ileride lazım olur)
            this.previousForm = previousForm;

            // Kullanıcı tiplerini ComboBox'a ekle
            cmbUserType.Items.Add(UserTypeAdmin);
            cmbUserType.Items.Add(UserTypeUser);
            cmbUserType.Items.Add(UserTypePartTime);
            // Başlangıçta seçili olmasın veya varsayılan bir tip seçilsin
            cmbUserType.SelectedIndex = -1; // Hiçbiri seçili değil
           
            LoadUsers(); // Kullanıcıları yükle
            
        }

        
        private void LoadUsers()
        {
            try
            {
                users = FileHelper.LoadUsersFromFile();
                // DataGridView'i güncellemenin daha güvenli yolu: BindingSource kullanmak
                // Ama şimdilik mevcut yapıyı koruyalım.
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;

                // Gerekirse kolon ayarları burada yapılabilir (örn. şifre kolonunu gizlemek)
                // if (dgvUsers.Columns.Contains("Password"))
                // {
                //     dgvUsers.Columns["Password"].Visible = false;
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcılar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata durumunda belki formu kapatmak veya başka bir işlem yapmak gerekebilir.
                users = new List<User>(); // Hata durumunda boş liste ata
                dgvUsers.DataSource = null;
            }
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            // 1. Kullanıcı seçili mi?
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen tipini değiştirmek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Yeni kullanıcı tipi seçili mi?
            if (cmbUserType.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yeni kullanıcı tipini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili kullanıcıyı bul
            // Kolon adını sabit (EmailColumnName) kullanarak daha güvenli hale getirdik.
            var selectedEmail = dgvUsers.SelectedRows[0].Cells[EmailColumnName].Value.ToString();
            var selectedUser = users.FirstOrDefault(u => u.Email.Equals(selectedEmail, StringComparison.OrdinalIgnoreCase)); // Büyük/küçük harf duyarsız karşılaştırma

            if (selectedUser != null)
            {
                string newType = cmbUserType.SelectedItem.ToString();

                // Mevcut tip ile aynıysa uyarı verilebilir (isteğe bağlı)
                if (selectedUser.UserType.Equals(newType, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Kullanıcının tipi zaten seçili olan tip ile aynı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Değişikliği yap
                selectedUser.UserType = newType;

                try
                {
                    FileHelper.SaveUsersToFile(users); // Değişikliği dosyaya kaydet
                    LoadUsers(); // DataGridView'i yenile (veya sadece DataSource'u resetle)
                    MessageBox.Show("Kullanıcı tipi başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kullanıcı tipi güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Hata durumunda değişikliği geri almak gerekebilir (opsiyonel)
                    LoadUsers(); // Eski hali geri yükle
                }
            }
            else
            {
                MessageBox.Show("Seçilen kullanıcı listede bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buton event handler'ını async Task yapıyoruz
        private async void btnSendNewPassword_Click(object sender, EventArgs e)
        {
            // 1. Kullanıcı seçili mi?
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen şifresini yenilemek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili kullanıcıyı bul
            var selectedEmail = dgvUsers.SelectedRows[0].Cells[EmailColumnName].Value.ToString();
            var userToSend = users.FirstOrDefault(u => u.Email.Equals(selectedEmail, StringComparison.OrdinalIgnoreCase));

            if (userToSend != null)
            {
                // İşlem başladığını belirt (örn. butonu disable et, imleci değiştir)
                btnSendNewPassword.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                progressBar1.Style = ProgressBarStyle.Marquee; // Sürekli hareket eden progress bar

                try
                {
                    string newPassword = GenerateRandomPassword();
                   
                  
                    // Bu kod sadece yeni şifre üretip gönderiyor
                    
                    userToSend.Password = newPassword; // Yeni şifreyi ata (muhtemelen hash'lenmiş hali atanmalı)

                    // E-postayı asenkron olarak gönder
                    await SendEmailAsync(userToSend.Email, newPassword);

                    // E-posta gönderimi başarılıysa dosyayı kaydet
                    FileHelper.SaveUsersToFile(users);
                    LoadUsers(); // Grid'i güncelle
                    MessageBox.Show("Yeni şifre başarıyla kullanıcıya e-posta ile gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException smtpEx) // SMTP özel hataları
                {
                    // Daha detaylı SMTP hata mesajları gösterilebilir
                    MessageBox.Show($"E-posta gönderilemedi (SMTP Hatası): {smtpEx.Message}\nStatusCode: {smtpEx.StatusCode}", "E-posta Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Diğer genel hatalar
                {
                    MessageBox.Show($"Şifre gönderilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Hata durumunda şifre değişikliğini geri al (opsiyonel)
                    LoadUsers();
                }
                finally
                {
                    // İşlem bittiğinde UI'ı normale döndür
                    btnSendNewPassword.Enabled = true;
                    this.Cursor = Cursors.Default;
                    progressBar1.Style = ProgressBarStyle.Blocks; // Normal progress bar
                    progressBar1.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Seçilen kullanıcı listede bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateRandomPassword(int length = 8) // Şifre uzunluğunu parametre olarak almak daha esnek
        {
            // Daha güvenli veya okunaklı şifreler için farklı yöntemler kullanılabilir
            // Örneğin: Büyük harf, küçük harf, rakam, özel karakter içermesini sağlamak
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // Eski yöntem: Guid.NewGuid().ToString().Substring(0, length); (Daha az rastgele olabilir)
        }

        // E-posta gönderme fonksiyonunu async Task yapalım
        private async Task SendEmailAsync(string toEmail, string newPassword)
        {
            // MailAddress nesnelerini oluştur
            var fromAddress = new MailAddress(SenderEmail, SenderName);
            var toAddress = new MailAddress(toEmail);

            // E-posta içeriği
            const string subject = "Yeni Şifreniz";
            string body = $"Merhaba,\n\nYeni şifreniz aşağıdadır:\n\n{newPassword}\n\nİyi günler."; // E-posta içeriğini biraz daha bilgilendirici yapalım

            // SMTP İstemcisi Ayarları
            var smtp = new SmtpClient
            {
                Host = SmtpHost,
                Port = SmtpPort,
                EnableSsl = true, // Gmail için SSL/TLS gerekli
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, SenderAppPassword) // Gönderen e-posta ve Uygulama Şifresi
                // Timeout ayarı eklemek de faydalı olabilir:
                // Timeout = 20000 // 20 saniye (milisaniye cinsinden)
            };

            // MailMessage nesnesi (using ile kullanmak Dispose edilmesini garantiler)
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = false // E-posta içeriği düz metin
            })
            {
                // E-postayı asenkron olarak gönder
                await smtp.SendMailAsync(message);
            }
        }

        private void FormUserManagement_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnSil_Click(object sender, EventArgs e)
        {
          
            // 1. Kullanıcı seçili mi?
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili kullanıcıyı bul
            var selectedEmail = dgvUsers.SelectedRows[0].Cells[EmailColumnName].Value.ToString();
            var userToDelete = users.FirstOrDefault(u => u.Email.Equals(selectedEmail, StringComparison.OrdinalIgnoreCase));

            if (userToDelete != null)
            {
                // Kullanıcı kendini silmeye çalışıyor mu kontrol et
                //if (userToDelete.Email.Equals(currentUser.Email, StringComparison.OrdinalIgnoreCase))
                //{
                //    MessageBox.Show("Kendinizi silemezsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                // Silme işlemi onayı
                DialogResult result = MessageBox.Show(
                    $"{userToDelete.Email} adresli kullanıcıyı silmek istediğinizden emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Kullanıcıyı listeden kaldır
                        users.Remove(userToDelete);

                        // Değişiklikleri dosyaya kaydet
                        FileHelper.SaveUsersToFile(users);

                        // DataGridView'i yenile
                        LoadUsers();

                        MessageBox.Show("Kullanıcı başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kullanıcı silinirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Hata durumunda listeyi tekrar yükle
                        LoadUsers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seçilen kullanıcı listede bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
