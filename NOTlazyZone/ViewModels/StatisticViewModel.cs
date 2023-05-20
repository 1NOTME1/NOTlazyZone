using NOTlazyZone.Model;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    public class StatisticViewModel : WorkspaceViewModel
    {
        public ICommand ChangeCodeCommand { get; set; }

        public string NazwaSilowni
        {
            get => Model.NazwaSilowni;
            set
            {
                if (Model.NazwaSilowni != value)
                {
                    Model.NazwaSilowni = value;
                    OnPropertyChanged(() => NazwaSilowni);
                }
            }
        }
        public string GymName
        {
            get => Model.NazwaSilowni;
            set
            {
                if (Model.NazwaSilowni != value)
                {
                    Model.NazwaSilowni = value;
                    OnPropertyChanged(() => NazwaSilowni);
                }
            }
        }
        
        public string Adres { get => Model.Adres; set{}}
        //public string Test { get; set; }
        //public string NazwaSilowni { get; set; }
        //public string Adres { get; set; }
        //public string Miasto { get; set; }
        public int LiczbaCzlonkow { get => Model.LiczbaCzlonkow; set { } }
        //public DateTime DataZalozenia { get; set; }
        //public string TelefonKontaktowy { get; set; }
        //public string EmailKontaktowy { get; set; }
        //public string StronaInternetowa { get; set; }
        //public string GodzinyOtwarcia { get; set; }
        //public int LiczbaKlientow { get; set; }
        //public int SredniaLiczbaOdwiedzinTygodniowo { get; set; }
        //public string NajpopularniejszeZajecia { get; set; }
        //public bool DostepnePosilkiDietetyczne { get; set; }
        //public double ProcentowyWzrostLiczbyKlientow { get; set; }
        //public string OpisWzrostu { get; set; }

        public Statistic Model { get; set; }

        public StatisticViewModel() 
        {
            base.DisplayName = "Statystyki";
            Model = new Statistic("NOTlazyZone", "Długa 20",13);
        }
    }
    
}
