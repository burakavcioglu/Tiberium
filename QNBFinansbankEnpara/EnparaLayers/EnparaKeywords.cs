namespace QNBFinansbankEnpara
{
    public class EnparaKeywords : EnparaDriver
    {
        public void EnparaHesapTutarGir(string tutar)
        {
            Temizle("hesapTutar", ID);
            Tikla("(//span[text()=\"Hesap açılış tutarı\"])[2]", XPath);
            CiftTikla("hesapTutar", ID);
            DegerGir(null, tutar, "hesapTutar", ID);
            Tikla("(//span[text()=\"Hesap açılış tutarı\"])[2]", XPath);
        }



    }
}