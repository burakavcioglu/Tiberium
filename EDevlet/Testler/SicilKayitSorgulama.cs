#region Test Script Template
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EDevlet
{
    [TestClass]
    public class SicilKayitSorgulama : EDevletKeywords
    {
        [TestMethod]
        public void AdliSicilKayitSorgulama()
        {
            #endregion


            //Adli Sicil Kaydı Sorgulama Testi

            EDevletLogin("Chrome", TCKimlik, Sifre); //E-Devlet Login Keyword: Tarayıcı, TCKN, Şifre
            Tikla(EHizmetlerLocator, XPath);
            Tikla(Adalet, XPath);
            Tikla(AdliSicilSorgu, XPath); //AdliSicilSorgu XPath - "Adli Sicil Kaydı Sorgulama" Metin
            Tikla("chkOnay", Name);
            Tikla("btn", Name);
            ListedenSec("Kurum Türü", "cmbKurumTuru", "Özel", ID);
            ListedenSec("Belgenin Neden Verileceği", "belgeNedenVerilecek", "Ehliyet", ID);
            DegerGir("Belgenin Nereye Verileceği", "TIBERIUM", "belgeNereyeVerilecek", ID);
            Tikla("btn", Name);
            Kontrol(KontrolSicil, XPath); //Bu sayfayı DOĞRUDAN YAZDIRMAYINIZ! Metni Kontrol Edilir
            Tikla("Kayıtı Belgelerim", Metin);
            Tikla("Geri Dön", Metin);
            TestBitti();


#region Test Script Template
        }
    }
}
#endregion