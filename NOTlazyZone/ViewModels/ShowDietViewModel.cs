using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    class ShowDietViewModel : WszystkieViewModel<DietForView>
    {
        #region Properties for sorting and finding
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
        #endregion

        public ShowDietViewModel() : base("Zarządzanie Dieta")
        {
            load();
        }

        public override void load()
        {
            List = new ObservableCollection<DietForView>
                (
                    //dla kazdego zamowienia z bazy zamienia
                    from Dietum in notlazyzoneEntities.Dieta
                        //tworze nowa zamowieniaforview
                    select new DietForView
                    {
                       idDiety = Dietum.DaId,
                       nazwaDiety = Dietum.DaNazwa,
                       idUzytkownika = Dietum.DaUsId,
                       iloscKalorii = Dietum.DaColorie,
                       iloscBialka = Dietum.DaIloscBialka,
                       iloscWegli = Dietum.DaIloscWeglowodanow,
                       iloscTluszczy = Dietum.DaIloscTluszczy,
                       rodzajDiety = Dietum.DaDat.DatRodzaj

                    }
                );
        }

        public override List<string> getComboboxSortList()
        {
            return new List<string> { "nazwaDiety", "iloscKalorii", "rodzajDiety" };
        }

        public override void sort()
        {
            switch (SortField)
            {
                case "nazwaDiety":
                    List = new ObservableCollection<DietForView>(List.OrderBy(item => item.nazwaDiety));
                    break;
                case "iloscKalorii":
                    List = new ObservableCollection<DietForView>(List.OrderBy(item => item.iloscKalorii));
                    break;
                case "rodzajDiety":
                    List = new ObservableCollection<DietForView>(List.OrderBy(item => item.rodzajDiety));
                    break;
            }
        }

        public override List<string> getComboboxFindList()
        {
            return new List<string> { "nazwaDiety", "rodzajDiety" };
        }

        public override void find()
        {
            switch (FindField)
            {
                case "nazwaDiety":
                    List = new ObservableCollection<DietForView>(List.Where(item => item.nazwaDiety != null && item.nazwaDiety.StartsWith(FindTextBox)));
                    break;
                case "rodzajDiety":
                    List = new ObservableCollection<DietForView>(List.Where(item => item.rodzajDiety != null && item.rodzajDiety.StartsWith(FindTextBox)));
                    break;
            }
        }

    }

}
