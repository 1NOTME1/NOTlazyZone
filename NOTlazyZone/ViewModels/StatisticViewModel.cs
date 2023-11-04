using NOTlazyZone.Helpers;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    public class StatisticViewModel : WszystkieViewModel<StatystykiSilowni>
    {
        //public ICommand ChangeCodeCommand { get; set; }

        //public string NazwaSilowni
        //{
        //    get => Model.NazwaSilowni;
        //    set
        //    {
        //        if (Model.NazwaSilowni != value)
        //        {
        //            Model.NazwaSilowni = value;
        //            OnPropertyChanged(() => NazwaSilowni);
        //        }
        //    }
        //}
        //public string Adres 
        //{ get => Model.Adres; set{}}
        //public string Wlasciciel
        //{ get => Model.Wlasciciel; set { } }
        //public string Miasto
        //{ get => Model.Miasto; set{}}
        //public int LiczbaCzlonkow
        //{ get => Model.LiczbaCzlonkow; set {}}
        //public DateTime DataZalozenia
        //{ get => Model.DataZalozenia; set{}}
        //public string TelefonKontaktowy
        //{ get => Model.TelefonKontaktowy; set{}}
        //public string EmailKontaktowy
        //{ get => Model.EmailKontaktowy; set{}}
        //public string StronaInternetowa
        //{ get => Model.StronaInternetowa; set{}}
        //public string GodzinyOtwarcia 
        //{ get => Model.GodzinyOtwarcia; set{}}
        //public int LiczbaKlientow 
        //{ get => Model.LiczbaKlientow; set{}}
        //public int SredniaLiczbaOdwiedzinTygodniowo 
        //{ get => Model.SredniaLiczbaOdwiedzinTygodniowo; set{}}
        //public string NajpopularniejszeZajecia 
        //{ get => Model.NajpopularniejszeZajecia; set{}}
        //public bool DostepnePosilkiDietetyczne 
        //{ get => Model.DostepnePosilkiDietetyczne; set{}}
        //public double ProcentowyWzrostLiczbyKlientow 
        //{ get => Model.ProcentowyWzrostLiczbyKlientow; set{}}
        //public string OpisWzrostu 
        //{ get => Model.OpisWzrostu; set{}}

        //public Statistic Model { get; set; }

        #region Konstruktor
        public StatisticViewModel() :base("StatystykiSilowni")
        {
            //Model = new Statistic("NOTlazyZone", "Grochowska 32 Warszawa", "Michał Kwaśniewski", "Warszawa, Poznań, Kraków", 100, DateTime.Now, "456 645 323", "NOTlazyZone@gmail.com", "www.NOTlazyZone.com", "06:00 - 24:00", 50, 10, "Trening silowy", true, 10.5, "Opis");

        }
        #endregion

        #region Helpers
            public override void load()
        {
            List = new ObservableCollection<StatystykiSilowni>
                (
                //z bazy danych pobieram wszystkie dane
                    notlazyzoneEntities.StatystykiSilownis
                );
        }
        #endregion


    }

}
