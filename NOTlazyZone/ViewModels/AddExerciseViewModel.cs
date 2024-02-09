using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using NOTlazyZone.Helpers;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    internal class AddExerciseViewModel : JedenViewModel<Cwiczenium>
    {
        public ICommand OpenModalCommand { get; private set; }
        public ObservableCollection<Cwiczenium> Cwiczenie { get; private set; } = new ObservableCollection<Cwiczenium>();
        #region Konstruktor
        public AddExerciseViewModel() : base("Dodaj Cwiczenie")
        {
            item = new Cwiczenium();
            LoadProducts();
            OpenModalCommand = new RelayCommand(OpenModal);
        }
        #endregion

        private void OpenModal()
        {
            ModalExercise modalView = new ModalExercise
            {
                DataContext = this
            };
            WindowManager.OpenModalWindow(this, modalView);
        }

        private void LoadProducts()
        {
            var cwiczeniaFromDb = notlazyzoneEntities.Cwiczenia.ToList();
            foreach (var prod in cwiczeniaFromDb)
            {
                Cwiczenie.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(CwNazwa):
                    return CwNazwa.IsNullOrEmpty() ? "Wypełnij pole Nazwa Produktu" : string.Empty;

                case nameof(CwSeria):
                    return CwSeria == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                case nameof(CwPowtorzenie):
                    return CwPowtorzenie == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                case nameof(CwCiezar):
                    return CwCiezar == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                case nameof(CwPrzerwa):
                    return CwPrzerwa == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                case nameof(CwTrudnosc):
                    return CwTrudnosc == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                case nameof(CwUsId):
                    return CwUsId == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                case nameof(CwPtId):
                    return CwPtId == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                case nameof(CwCardio):
                    return !CwCardio ? "Nie uzupełniłeś aktywności adresu" : string.Empty;

                default: return string.Empty;
            }
        }


        #region Dane
            //dla kazdego elementu na interfejsie ktory bedzie dodawany tworzymy wlasciwosc


        public IQueryable<Uzytkownicy> ExUsComboBoxItems
        {
            get
            {
                return
                    (
                        from Uzytkownicy in notlazyzoneEntities.Uzytkownicies
                        select Uzytkownicy
                    ).ToList().AsQueryable();
            }
        }

        public IQueryable<CwiczeniaTyp> CwCwtComboBoxItems
        {
            get
            {
                return
                    (
                        from CwiczeniaTyp in notlazyzoneEntities.CwiczeniaTyps
                        select CwiczeniaTyp
                    ).ToList().AsQueryable();
            }
        }

        public IQueryable<PlanTreningowy> CwPtComboBoxItems
        {
            get
            {
                return
                    (
                        from PlanTreningowy in notlazyzoneEntities.PlanTreningowies
                        select PlanTreningowy
                    ).ToList().AsQueryable();
            }
        }


        public String CwNazwa
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

        public int CwTrudnosc
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

        public int CwUsId
        {
            get
            {
                return item.CwUsId;
            }
            set
            {
                if (item.CwUsId != value)
                {
                    item.CwUsId = value;
                    OnPropertyChanged(() => CwUsId);
                }
            }
        }

        public int? CwCwtId
        {
            get
            {
                return item.CwCwtId;
            }
            set
            {
                if (item.CwCwtId != value)
                {
                    item.CwCwtId = value;
                    OnPropertyChanged(() => CwCwtId);
                }
            }
        }



        public int? CwPtId
        {
            get
            {
                return item.CwPtId;
            }
            set
            {
                if (item.CwPtId != value)
                {
                    item.CwPtId = value;
                    OnPropertyChanged(() => CwPtId);
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


                #endregion
            }
        }



        
    }
}