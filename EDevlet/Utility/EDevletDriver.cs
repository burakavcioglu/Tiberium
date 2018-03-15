using TiberiumFramework;

namespace EDevlet
{
    public class EDevletDriver : Tiberium
    {
        #region Driver Katmanı
        /* Driver Katmanı
        
        IWebDriver static olarak Web adıyla Tanımlanmıştır.

        */
        #endregion

        //Login Static
        public const string TCKimlik = "TCKN-BİLGİSİ";
        public const string Sifre = "EDEVLET-PAROLA";
        public const string TCKimlikID = "tridField";
        public const string SifreID = "egpField";

        //Locators
        public const string EHizmetlerLocator = "//em[text()=\"e-Hizmetler\"]";
        public const string KisiselBilgiler = "//em[text()=\"Kişisel Bilgiler\"]";
        public const string Adalet = "//em[text()=\"Adalet\"]";
        public const string KontrolSicil = "//strong[starts-with(text(),\"Bu sayfayı DOĞRUDAN \")]";
        public const string AdliSicilSorgu = "//a[starts-with(text(),\"Adli Sicil Kaydı Sor\")]";




    }
}