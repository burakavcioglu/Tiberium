using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QNBFinansbankEnpara
{
    [TestClass]
    public class MevduatFaizHesaplama : EnparaKeywords
    {
        [TestMethod]
        public void MevduatFaizHesaplamaTest()
        {
            // QNB Finansbank Enpara Mevduat Faiz Hesaplama Testi
            // Keyword Driven Testing - KDT

            BrowserKapat();
            OpenLink(Chrome, "https://www.qnbfinansbank.enpara.com");
            Tikla("ORANLAR VE FİYATLAR", Metin);
            Tikla(MevduatOranlarLogo, XPath);
            EnparaHesapTutarGir("50000"); //Enpara Special Keyword
            ListedenSec("Para Birimi", "drpCurrency", "TL", ID);
            Tikla("rdHesapVadeli", ID); //Vadeli Hesap Radio Button
            ListedenSec("Toplam Mevduat Büyüklüğü", "drpAumRange", "0 - 100.000 TL arası", ID);
            ListedenSec("Vade", "drpVade", "32 gün", ID);
            Tikla("mevduatCalculation", ID); //Hesapla
            Kontrol("vadeSonuBakiye", ID);
            Bekle(3); //Hızlı Geçtiği için bekletiyorum.
            TestBitti();
        }
    }
}