// SalaryCalculator.cs
using System;

namespace OOP2_2425Spring_Grp13
{
    /// <summary>
    /// BMO politikalarına göre minimum maaşı hesaplayan sınıf.
    /// Kullanıcı tipi string olarak işlenir (enum kullanılmaz).
    /// Hesaplama mantığı BMO linklerindeki bilgilere göre güncellenmelidir.
    /// </summary>
    public static class SalaryCalculator
    {
        // Varsayımsal Temel Maaş ve Katsayılar (BMO politikalarına göre güncellenecek)
        // Bunlar sadece örnektir, gerçek BMO verileri kullanılmalıdır.
        private const decimal BaseMinimumSalary = 50000; // Örnek temel maaş (TL)
        private const decimal ExperienceFactor = 1.05m; // Her yıl deneyim için %5 artış (örnek)


        private const float CertificationBonus = 1.1f; // Sertifika için %10 bonus (örnek)
        private const float PartTimeDiscount = 0.50f; // Part-time için %50 indirim

        private const float CertifiedEnglishBonus = 0.2f; // Sertifikalı İngilizce için %20 bonus (örnek)
        private const float CertifiedGraduateEnglishBonus = 0.2f; // Sertifikalı İngilizce mezuniyet için %20 bonus (örnek)
        private const float CertifiedOtherLanguageBonus = 0.05f; // Sertifikalı diğer diller için %5 bonus (örnek)


        private const float RelatedMastersBonus = 0.10f; // İlgili yüksek lisans için %10 bonus (örnek)
        private const float RelatedPhDBonus = 0.30f; // İlgili doktora için %20 bonus (örnek)
        private const float RelatedAssociateProfessorBonus = 0.35f; // İlgili doçentlik için %25 bonus (örnek)
        private const float UnrelatedMastersBonus = 0.05f; // İlgisiz yüksek lisans için %5 bonus (örnek)
        private const float UnrelatedPhDBonus = 0.15f; // İlgisiz doktora için %10 bonus (örnek)

        // Kullanıcı tipi string değerleri (Yazım hatalarını önlemek için sabitler kullanılabilir)
        private const string UserType_Admin = "Admin";
        private const string UserType_User = "User";
        private const string UserType_PartTimeUser = "Part-time-user"; // Proje tanımındaki string değer

        /// <summary>
        /// Verilen parametrelere göre minimum maaşı hesaplar.
        /// Kullanıcı tipi string olarak alınır.
        /// </summary>
        /// <param name="parameters">Maaş hesaplama parametreleri.</param>
        /// <returns>Hesaplanan minimum maaş.</returns>
        public static decimal CalculateMinimumSalary(SalaryParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters), "Maaş parametreleri boş olamaz.");
            }

            // Deneyim yılına göre artış (Örnek: Her yıl için faktörle çarp)
            for (int i = 0; i < parameters.YearsOfExperience; i++)
            {
                parameters.SalaryMultiplier += (float)ExperienceFactor;
            }

            // Eğitim düzeyine göre bonus (Örnek)
            switch (parameters.EducationLevel)
            {
                case EducationLevel.RelatedPhD:
                    parameters.SalaryMultiplier += RelatedPhDBonus;
                    break;
                case EducationLevel.RelatedMasters:
                    parameters.SalaryMultiplier += RelatedMastersBonus;
                    break;
                case EducationLevel.RelatedAssociateProfessor:
                    parameters.SalaryMultiplier += RelatedAssociateProfessorBonus;
                    break;
            }

            // Sertifika bonusu (Örnek)
            if (parameters.HasCertifications)
            {
                parameters.SalaryMultiplier += CertificationBonus;
            }

            // Kullanıcı tipine göre indirim (Part-time için %50)
            if (string.Equals(parameters.UserType, UserType_PartTimeUser, StringComparison.OrdinalIgnoreCase))
            {
                parameters.SalaryMultiplier += PartTimeDiscount;
            }

            // Minimum maaşı hesapla
            decimal calculatedSalary = BaseMinimumSalary * (decimal)parameters.SalaryMultiplier;

            // Hesaplanan maaşı döndür
            return calculatedSalary;
        }

        // Not: Gerçek BMO politikaları daha karmaşık olabilir (örn: unvan, yaş, vb. faktörler)
        // Lütfen BMO belgelerini dikkatlice inceleyerek bu hesaplama mantığını güncelleyin.
        // String karşılaştırmaları yaparken yazım hatalarına dikkat etmelisiniz.
    }

    // UserType enum'ı artık kullanılmıyor.
}
