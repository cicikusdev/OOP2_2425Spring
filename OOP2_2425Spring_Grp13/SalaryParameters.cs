// SalaryParameters.cs
using System;

namespace OOP2_2425Spring_Grp13
{
    /// <summary>
    /// Maaş hesaplaması için gerekli parametreleri tutan sınıf.
    /// BMO politikalarına göre güncellenmelidir.
    /// </summary>
    public class SalaryParameters
    {
        // Kullanıcı ID'si (hangi kullanıcıya ait olduğunu belirtmek için)
        // Bu ID, User sınıfındaki ID ile eşleşmelidir.
        public Guid UserId { get; set; }

        // Varsayımsal Maaş Parametreleri (BMO politikalarına göre güncellenecek)
        // Lütfen BMO linklerindeki gerçek kriterleri buraya yansıtın.

        /// <summary>
        /// Mesleki Deneyim Yılı.
        /// </summary>
        public int YearsOfExperience { get; set; }

        /// <summary>
        /// Eğitim Düzeyi (Örn: Lisans, Yüksek Lisans, Doktora).
        /// </summary>
        public EducationLevel EducationLevel { get; set; } // Aşağıda enum olarak tanımlanacak

        /// <summary>
        /// Sahip olunan Sertifikalar (Etki edenler).
        /// </summary>
        public bool HasCertifications { get; set; } // Basit bir evet/hayır, detaylandırılabilir

        /// <summary>
        /// Bulunulan Şehir (Büyükşehir/Diğer gibi faktörler etkileyebilir).
        /// </summary>
        public string City { get; set; } // Basit bir string, enum yapılabilir

        /// <summary>
        /// Kullanıcı Tipi (Admin, User, Part-time-user).
        /// Maaş hesaplamasında Part-time için %50 indirim uygulanacak.
        /// </summary>
        public string UserType { get; set; }

        // Hesaplanan Minimum Maaş (Bu parametre kullanıcıdan alınmaz, hesaplanır)
        public float MinimumCalculatedSalary { get; set; }

        public string Position { get; set; } // Kullanıcının pozisyonu (örneğin: öğretim görevlisi, araştırma görevlisi vb.)

        public float SalaryMultiplier { get; set; } // Kullanıcının maaş çarpanı (örneğin: 1.0, 1.5 vb.)
    }

    /// <summary>
    /// Eğitim Düzeylerini temsil eden enum.
    /// BMO kriterlerine göre detaylandırılabilir.
    /// </summary>
    public enum EducationLevel
    {
        Undefined,                  // Tanımlanmamış
        RelatedMasters,             // Meslek alanı ile ilgili yüksek lisans
        RelatedPhD,                 // Meslek alanı ile ilgili doktora
        RelatedAssociateProfessor,  // Meslek alanı ile ilgili doçentlik
        UnrelatedMasters,           // Meslek alanı ile ilgili olmayan yüksek lisans
        UnrelatedPhDOrAssociate     // Meslek alanı ile ilgili olmayan doktora/doçentlik
    }

}
