#region Test Script Template
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EDevlet
{
    [TestClass]
    public class EDevletLogin : EDevletKeywords
    {
        [TestMethod]
        public void EDevletLoginTest()
        {
            #endregion

            //E-Devlet Login Testi

            BrowserKapat();
            OpenLink("Chrome", "https://giris.turkiye.gov.tr/Giris/gir");
            DegerGir("TC Kimlik Numarası", TCKimlik, TCKimlikID, ID);
            DegerGir("Şifre", Sifre, SifreID, ID);
            Tikla("submitButton", Name);
            TestBitti();


#region Test Script Template
        }
    }
}
#endregion