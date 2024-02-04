using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using NOTlazyZone.ViewModel;
using NOTlazyZone.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace NOTlazyZone.ViewModels
{
    class TrainingPlanViewModel : WszystkieViewModel<CwiczeniaForView>
    {
        private string _sortField;
        public string SortField
        {
            get { return _sortField; }
            set
            {
                if (_sortField != value)
                {
                    _sortField = value;
                    OnPropertyChanged(() => SortField);
                }
            }
        }

        private string _findField;
        public string FindField
        {
            get { return _findField; }
            set
            {
                if (_findField != value)
                {
                    _findField = value;
                    OnPropertyChanged(() => FindField);
                }
            }
        }

        private string _findTextBox;
        public string FindTextBox
        {
            get { return _findTextBox; }
            set
            {
                if (_findTextBox != value)
                {
                    _findTextBox = value;
                    OnPropertyChanged(() => FindTextBox);
                }
            }
        }


        public TrainingPlanViewModel() : base("PlanTreningowy")
        {
            load();
        }

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<CwiczeniaForView>
                (
                    // dla każdego ćwiczenia z bazy zamienia
                    from Cwiczenium in notlazyzoneEntities.Cwiczenia
                        // tworzę nową CwiczeniaForView
                    select new CwiczeniaForView
                    {
                        IdPlanu = Cwiczenium.CwPtId,
                        IdCwiczenia = Cwiczenium.CwId,
                        nazwaCwiczenia = Cwiczenium.CwNazwa,
                        seriaCwiczenia = Cwiczenium.CwSeria,
                        czasPlanu = (TimeSpan)Cwiczenium.CwPt.PtCzas,
                        typCwiczenia = Cwiczenium.CwCwt.CwtNazwa,
                        ciezarCwiczenia = Cwiczenium.CwCiezar,
                        przerwaCwiczenia = Cwiczenium.CwPrzerwa,
                        trudnoscCwiczenia = Cwiczenium.CwTrudnosc,
                        nazwaUzytkownika = Cwiczenium.CwUs.UsImie + " " + Cwiczenium.CwUs.UsNazwisko
                    }
                );
        }


        // Implementacja wymaganych metod abstrakcyjnych
        public override void sort()
        {
            switch (SortField)
            {
                case "nazwaCwiczenia":
                    List = new ObservableCollection<CwiczeniaForView>(List.OrderBy(item => item.nazwaCwiczenia));
                    break;
                case "typCwiczenia":
                    List = new ObservableCollection<CwiczeniaForView>(List.OrderBy(item => item.typCwiczenia));
                    break;
                case "trudnoscCwiczenia":
                    List = new ObservableCollection<CwiczeniaForView>(List.OrderBy(item => item.trudnoscCwiczenia));
                    break;
                case "ciezarCwiczenia":
                    List = new ObservableCollection<CwiczeniaForView>(List.OrderBy(item => item.ciezarCwiczenia));
                    break;
                default:
                    break;
            }
        }


        public override List<string> getComboboxSortList()
        {
            return new List<string> { "nazwaCwiczenia", "typCwiczenia", "trudnoscCwiczenia", "ciezarCwiczenia" };
        }


        public override void find()
        {
            switch (FindField)
            {
                case "nazwaCwiczenia":
                    List = new ObservableCollection<CwiczeniaForView>(List.Where(item => item.nazwaCwiczenia != null && item.nazwaCwiczenia.StartsWith(FindTextBox)));
                    break;
                case "typCwiczenia":
                    List = new ObservableCollection<CwiczeniaForView>(List.Where(item => item.typCwiczenia != null && item.typCwiczenia.StartsWith(FindTextBox)));
                    break;
                default:
                    break;
            }
        }


        public override List<string> getComboboxFindList()
        {
            return new List<string> { "nazwaCwiczenia", "typCwiczenia" };
        }


        #endregion
    }
}
