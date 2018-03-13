using TiberiumFramework;

namespace EDevlet
{
    public class EDevletLayer : Tiberium
    {
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


        #region E-Devlet Login Keyword
        public void EDevletLogin(string browser, string TCKN, string parola)
        {
            BrowserKapat();
            OpenLink(browser, "https://giris.turkiye.gov.tr/Giris/gir");
            DegerGir("TC Kimlik Numarası", TCKN, TCKimlikID, ID);
            DegerGir("Şifre", parola, SifreID, ID);
            Tikla("submitButton", Name);
        }
        #endregion

    }
}