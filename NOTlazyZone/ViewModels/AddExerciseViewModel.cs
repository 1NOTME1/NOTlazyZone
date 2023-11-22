using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class AddExerciseViewModel : JedenViewModel<Cwiczenium>
    {
        public ObservableCollection<Cwiczenium> Cwiczenie { get; private set; } = new ObservableCollection<Cwiczenium>();
        #region Konstruktor
        public AddExerciseViewModel() : base("Dodaj Cwiczenie")
        {
            item = new Cwiczenium();
            LoadProducts();
        }
        #endregion
        private void LoadProducts()
        {
            var cwiczeniaFromDb = notlazyzoneEntities.Cwiczenia.ToList();
            foreach (var prod in cwiczeniaFromDb)
            {
                Cwiczenie.Add(prod);
            }
        }


        #region Dane
        //dla kazdego elementu na interfejsie ktory bedzie dodawany tworzymy wlasciwosc


        public String? cwNazwa
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
                    OnPropertyChanged(() => cwNazwa);
                }
            }
        }

        public int? cwSeria
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
                    OnPropertyChanged(() => cwSeria);
                }
            }
        }

        public int? CwPowtorzenie
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

        public decimal? CwCiezar
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

        public decimal? CwPrzerwa
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

        public String? CwOpis
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

        public bool? CwCardio
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


                #endregion
            }
        }



        
    }
}