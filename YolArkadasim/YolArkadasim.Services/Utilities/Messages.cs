using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YolArkadasim.Services.Utilities
{
    public static class Messages
    {
        // Messages.Category.NotFound()
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı.";
                return "Böyle bir kategori bulunamadı.";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla eklenmiştir.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla silinmiştir.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adlı kategori başarıyla veritabanından silinmiştir.";
            }
        }

        public static class Journey
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Kayıtlar bulunamadı.";
                return "Böyle bir kayıt bulunamadı.";
            }
            public static string Add(string journeyTitle)
            {
                return $"{journeyTitle} başlıklı kayıt başarıyla eklenmiştir.";
            }

            public static string Update(string journeyTitle)
            {
                return $"{journeyTitle} başlıklı kayıt başarıyla güncellenmiştir.";
            }
            public static string Delete(string journeyTitle)
            {
                return $"{journeyTitle} başlıklı kayıt başarıyla silinmiştir.";
            }
            public static string HardDelete(string journeyTitle)
            {
                return $"{journeyTitle} başlıklı kayıt başarıyla veritabanından silinmiştir.";
            }
        }
    }
}
