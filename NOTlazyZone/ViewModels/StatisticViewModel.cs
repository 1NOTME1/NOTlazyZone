using Microsoft.EntityFrameworkCore;
using NOTlazyZone.Models.Entities;
using System;
using System.Linq;

namespace NOTlazyZone.ViewModels
{
    public class StatisticViewModel : WszystkieViewModel<StatystykiSilowni>
    {
        private string _nazwaSilowni;
        private string _wlasciciel;
        private int _liczbaCzlonkow;
        private DateTime _dataZalozenia;
        private string _stronaInternetowa;
        private string _godzinyOtwarcia;
        private int _liczbaKlientow;
        private int _sredniaLiczbaKlientowTygodniowo;
        private string _najpopularniejszeCwiczenia;
        private bool _dostepniTrenerzyPersonalni;
        private double _wzrostProcentowyLiczbyKlientow;
        private string _nazwaAdresu;
        private string _miejscowosc;
        private string _email;
        private string _telefon;


        #region Konstruktor
        public StatisticViewModel() : base("StatystykiSilowni")
        {
            load();
        }
        #endregion

        #region Helpers
        public override void load()
        {
            var silownia = notlazyzoneEntities.StatystykiSilownis
                .Include(s => s.StAd)
                .Include(s => s.StMa)
                .Include(s => s.StTn)


                .FirstOrDefault(s => s.StId == 5);
            if (silownia != null)
            {
                NazwaSilowni = silownia.StNazwaSilowni;
                Wlasciciel = silownia.StWlasciciel;
                LiczbaCzlonkow = silownia.StLiczbaCzlonkow;
                DataZalozenia = silownia.StDataZalozenia;
                StronaInternetowa = silownia.StStronaInterentowa;
                GodzinyOtwarcia = silownia.StGodzinyOtwarcia;
                LiczbaKlientow = silownia.StLiczbaKlientow;
                SredniaLiczbaKlientowTygodniowo = silownia.StSredniaLiczbaOdwiedzinTygodniowo;
                NajpopularniejszeCwiczenia = silownia.StNajpopularniejszeZajecia;
                DostepniTrenerzyPersonalni = silownia.StDostepniTrenerzyPersonalni;
                WzrostProcentowyLiczbyKlientow = silownia.StProcentowyWzrostLiczbyKlientow;
                NazwaAdresu = silownia.StAd?.AdNazwa;
                Miejscowosc = silownia.StAd?.AdMiejscowosc;
                Email = silownia.StMa?.MaNazwa;
                Telefon = silownia.StTn.TnNumer;




            }

        }



        public string NazwaSilowni
        {
            get { return _nazwaSilowni; }
            set
            {
                _nazwaSilowni = value;
                OnPropertyChanged(() => NazwaSilowni);
            }

        }

        public string Wlasciciel
        {
            get { return _wlasciciel; }
            set
            {
                _wlasciciel = value;
                OnPropertyChanged(() => Wlasciciel);
            }
        }

        public int LiczbaCzlonkow
        {
            get { return _liczbaCzlonkow; }
            set
            {
                _liczbaCzlonkow = value;
                OnPropertyChanged(() => LiczbaCzlonkow);
            }
        }

        public DateTime DataZalozenia
        {
            get { return _dataZalozenia; }
            set
            {
                _dataZalozenia = value;
                OnPropertyChanged(() => DataZalozenia);
            }
        }

        public string StronaInternetowa
        {
            get { return _stronaInternetowa; }
            set
            {
                _stronaInternetowa = value;
                OnPropertyChanged(() => _stronaInternetowa);
            }
        }

        public string GodzinyOtwarcia
        {
            get { return _godzinyOtwarcia; }
            set
            {
                _godzinyOtwarcia = value;
                OnPropertyChanged(() => GodzinyOtwarcia);
            }
        }

        public int LiczbaKlientow
        {
            get { return _liczbaKlientow; }
            set
            {
                _liczbaKlientow = value;
                OnPropertyChanged(() => LiczbaKlientow);
            }
        }

        public int SredniaLiczbaKlientowTygodniowo
        {
            get { return _sredniaLiczbaKlientowTygodniowo; }
            set
            {
                _sredniaLiczbaKlientowTygodniowo = value;
                OnPropertyChanged(() => SredniaLiczbaKlientowTygodniowo);
            }
        }

        public string NajpopularniejszeCwiczenia
        {
            get { return _najpopularniejszeCwiczenia; }
            set
            {
                _najpopularniejszeCwiczenia = value;
                OnPropertyChanged(() => NajpopularniejszeCwiczenia);
            }
        }

        public bool DostepniTrenerzyPersonalni
        {
            get { return _dostepniTrenerzyPersonalni; }
            set
            {
                _dostepniTrenerzyPersonalni = value;
                OnPropertyChanged(() => DostepniTrenerzyPersonalni);
            }
        }

        public double WzrostProcentowyLiczbyKlientow
        {
            get { return _wzrostProcentowyLiczbyKlientow; }
            set
            {
                _wzrostProcentowyLiczbyKlientow = value;
                OnPropertyChanged(() => WzrostProcentowyLiczbyKlientow);
            }
        }

        public string NazwaAdresu
        {
            get { return _nazwaAdresu; }
            set
            {
                _nazwaAdresu = value;
                OnPropertyChanged(() => NazwaAdresu);
            }
        }

        public string Miejscowosc
        {
            get { return _miejscowosc; }
            set
            {
                _miejscowosc = value;
                OnPropertyChanged(() => Miejscowosc);
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(() => Email);
            }
        }

        public string Telefon
        {
            get { return _telefon; }
            set
            {
                _telefon = value;
                OnPropertyChanged(() => Telefon);
            }
        }


        #endregion


    }

}
