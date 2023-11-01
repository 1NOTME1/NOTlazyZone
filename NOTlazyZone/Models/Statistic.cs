using System;

namespace NOTlazyZone.Models
{
    public class Statistic
    {
        public string NazwaSilowni { get; set; }
        public string Adres { get; set; }
        public string Wlasciciel { get; set; }
        public string Miasto { get; set; }
        public int LiczbaCzlonkow { get; set; }
        public DateTime DataZalozenia { get; set; }
        public string TelefonKontaktowy { get; set; }
        public string EmailKontaktowy { get; set; }
        public string StronaInternetowa { get; set; }
        public string GodzinyOtwarcia { get; set; }
        public int LiczbaKlientow { get; set; }
        public int SredniaLiczbaOdwiedzinTygodniowo { get; set; }
        public string NajpopularniejszeZajecia { get; set; }
        public bool DostepnePosilkiDietetyczne { get; set; }
        public double ProcentowyWzrostLiczbyKlientow { get; set; }
        public string OpisWzrostu { get; set; }

        public Statistic(string nazwaSilowni, string adres, string wlasciciel, string miasto, int liczbaCzlonkow, DateTime dataZalozenia, string telefonKontaktowy, string emailKontaktowy, string stronaInternetowa, string godzinyOtwarcia, int liczbaKlientow, int sredniaLiczbaOdwiedzinTygodniowo, string najpopularniejszeZajecia, bool dostepnePosilkiDietetyczne, double procentowyWzrostLiczbyKlientow, string opisWzrostu)
        {
            NazwaSilowni = nazwaSilowni;
            Adres = adres;
            Wlasciciel = wlasciciel;
            Miasto = miasto;
            LiczbaCzlonkow = liczbaCzlonkow;
            DataZalozenia = dataZalozenia;
            TelefonKontaktowy = telefonKontaktowy;
            EmailKontaktowy = emailKontaktowy;
            StronaInternetowa = stronaInternetowa;
            GodzinyOtwarcia = godzinyOtwarcia;
            LiczbaKlientow = liczbaKlientow;
            SredniaLiczbaOdwiedzinTygodniowo = sredniaLiczbaOdwiedzinTygodniowo;
            NajpopularniejszeZajecia = najpopularniejszeZajecia;
            DostepnePosilkiDietetyczne = dostepnePosilkiDietetyczne;
            ProcentowyWzrostLiczbyKlientow = procentowyWzrostLiczbyKlientow;
            OpisWzrostu = opisWzrostu;
        }



    }
}
