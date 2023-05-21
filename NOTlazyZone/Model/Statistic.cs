using System;

namespace NOTlazyZone.Model
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

        public Statistic( string nazwaSilowni, string adres, string wlasciciel, string miasto, int liczbaCzlonkow, DateTime dataZalozenia, string telefonKontaktowy, string emailKontaktowy, string stronaInternetowa, string godzinyOtwarcia, int liczbaKlientow, int sredniaLiczbaOdwiedzinTygodniowo, string najpopularniejszeZajecia, bool dostepnePosilkiDietetyczne, double procentowyWzrostLiczbyKlientow, string opisWzrostu)
        {
            this.NazwaSilowni = nazwaSilowni;
            this.Adres = adres;
            this.Wlasciciel = wlasciciel;
            this.Miasto = miasto;
            this.LiczbaCzlonkow = liczbaCzlonkow;
            this.DataZalozenia = dataZalozenia;
            this.TelefonKontaktowy = telefonKontaktowy;
            this.EmailKontaktowy = emailKontaktowy;
            this.StronaInternetowa = stronaInternetowa;
            this.GodzinyOtwarcia = godzinyOtwarcia;
            this.LiczbaKlientow = liczbaKlientow;
            this.SredniaLiczbaOdwiedzinTygodniowo = sredniaLiczbaOdwiedzinTygodniowo;
            this.NajpopularniejszeZajecia = najpopularniejszeZajecia;
            this.DostepnePosilkiDietetyczne = dostepnePosilkiDietetyczne;
            this.ProcentowyWzrostLiczbyKlientow = procentowyWzrostLiczbyKlientow;
            this.OpisWzrostu = opisWzrostu;
        }



    }
}
