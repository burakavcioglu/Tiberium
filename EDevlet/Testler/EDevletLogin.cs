using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EDevlet
{
    [TestClass]
    public class EDevletLogin : EDevletLayer
    {
        [TestMethod]
        public void EDevletLoginTest()
        {
            BrowserKapat();
            OpenLink("Chrome", "https://giris.turkiye.gov.tr/Giris/gir");
            DegerGir("TC Kimlik Numarası", TCKimlik, TCKimlikID, ID);
            DegerGir("Şifre", Sifre, SifreID, ID);
            Tikla("submitButton", Name);
            TestBitti();
        }
    }
}
