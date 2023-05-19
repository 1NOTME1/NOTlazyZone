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
        public string Adres
        {
            get => Model.Adres;
            set
            {
                if (Model.Adres != value)
                {
                    Model.Adres = value;
                    OnPropertyChanged(() => Adres);
                }
            }
        }


        public Statistic Model { get; set; }
        public StatisticViewModel() 
        {
            base.DisplayName = "Statystyki";
            Model = new Statistic("NOTlazyZone", "Długa 20");
        }
    }
    
}
