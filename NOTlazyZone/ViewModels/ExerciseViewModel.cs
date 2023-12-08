using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace NOTlazyZone.ViewModels
{
    class ExerciseViewModel : JedenViewModel<Cwiczenium>
    {
        public ObservableCollection<Cwiczenium> Cwiczenia { get; private set; } = new ObservableCollection<Cwiczenium>();
        #region Konstruktor
        public ExerciseViewModel() : base("Cwiczenia")
        {
            item = new Cwiczenium();
            LoadCwiczenia();
        }
        #endregion
        private void LoadCwiczenia()
        {
            var cwiczeniaFromDb = notlazyzoneEntities.Cwiczenia.ToList();
            foreach (var prod in cwiczeniaFromDb)
            {
                Cwiczenia.Add(prod);
            }
        }

        #region Dane
        //dla kazdego elementu na interfejsie ktory bedzie dodawany tworzymy wlasciwosc


        public String? CwNazwa
        {
            get
            {
                return item.CwNazwa;
            }
            set
            {
                if (item.CwNazwa != value)
                {
                    item.CwNazwa = value;
                    OnPropertyChanged(() => CwNazwa);
                }
            }
        }

        public int CwSeria
        {
            get
            {
                return item.CwSeria;
            }
            set
            {
                if (item.CwSeria != value)
                {
                    item.CwSeria = value;
                    OnPropertyChanged(() => CwSeria);
                }
            }
        }

        public int CwPowtorzenie
        {
            get
            {
                return item.CwPowtorzenie;
            }
            set
            {
                if (item.CwPowtorzenie != value)
                {
                    item.CwPowtorzenie = value;
                    OnPropertyChanged(() => CwPowtorzenie);
                }
            }
        }

        public decimal CwCiezar
        {
            get
            {
                return item.CwCiezar;
            }
            set
            {
                if (item.CwCiezar != value)
                {
                    item.CwCiezar = value;
                    OnPropertyChanged(() => CwCiezar);
                }
            }
        }

        public decimal CwPrzerwa
        {
            get
            {
                return item.CwPrzerwa;
            }
            set
            {
                if (item.CwPrzerwa != value)
                {
                    item.CwPrzerwa = value;
                    OnPropertyChanged(() => CwPrzerwa);
                }
            }
        }

        public bool CwCardio
        {
            get
            {
                return item.CwCardio;
            }
            set
            {
                if (item.CwCardio != value)
                {
                    item.CwCardio = value;
                    OnPropertyChanged(() => CwCardio);
                }
            }
        }

        public int? CwTrudnosc
        {
            get
            {
                return item.CwTrudnosc;
            }
            set
            {
                if (item.CwTrudnosc != value)
                {
                    item.CwTrudnosc = value;
                    OnPropertyChanged(() => CwTrudnosc);
                }
            }
        }

        public string? CwOpis
        {
            get
            {
                return item.CwOpis;
            }
            set
            {
                if (item.CwOpis != value)
                {
                    item.CwOpis = value;
                    OnPropertyChanged(() => CwOpis);
                }
            }
        }

        #endregion


    }
}
