namespace EDevlet
{
    public class EDevletKeywords : EDevletDriver
    {
        //Keywords Katmanı

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