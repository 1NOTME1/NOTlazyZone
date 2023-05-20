using System;

namespace NOTlazyZone.Model
{
    public class Statistic
    {
        public string Test { get; set; }
        public string NazwaSilowni { get; set; }
        public string Adres { get; set; }
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

        public Statistic(string nazwaSilowni, string adres, int liczbaCzlonkow)
        {
            this.NazwaSilowni = nazwaSilowni;
            this.Adres = adres;
            this.LiczbaCzlonkow = liczbaCzlonkow;
        }
    }
}
