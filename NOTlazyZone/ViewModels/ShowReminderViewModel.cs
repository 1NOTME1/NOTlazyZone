using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace NOTlazyZone.ViewModels
{
    class ShowReminderViewModel : WszystkieViewModel<PowiadomieniaForView>
    {
        #region Properties
        private string _sortField;
        private string _findField;
        private string _findTextBox;

        public string SortField
        {
            get { return _sortField; }
            set
            {
                _sortField = value;
                OnPropertyChanged(() => SortField);
            }
        }

        public string FindField
        {
            get { return _findField; }
            set
            {
                _findField = value;
                OnPropertyChanged(() => FindField);
            }
        }

        public string FindTextBox
        {
            get { return _findTextBox; }
            set
            {
                _findTextBox = value;
                OnPropertyChanged(() => FindTextBox);
            }
        }
        #endregion

        public ShowReminderViewModel() : base("Powiadomienia")
        {
            load();
        }

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<PowiadomieniaForView>
                (
                    from Powiadomienium in notlazyzoneEntities.Powiadomienia
                    select new PowiadomieniaForView
                    {
                        IdPowiadomienia = Powiadomienium.PoId,
                        powiadomienie = Powiadomienium.PoTimestamp,
                        nazwaPowiadomienia = Powiadomienium.PoNazwa,
                        UsId = Powiadomienium.PoUsId,
                        nazwaUzytkownika = Powiadomienium.PoUs.UsImie + " "
                        + Powiadomienium.PoUs.UsNazwisko,
                        uwagi = Powiadomienium.PoUs.UsUwagi,
                        DaId = Powiadomienium.PoUs.Dieta.Select(d => d.DaId).FirstOrDefault(),
                        CwId = Powiadomienium.PoUs.Cwiczenia.Select(c => c.CwId).FirstOrDefault()


                    }
                );
        }
        #endregion
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "nazwaPowiadomienia", "powiadomienie", "nazwaUzytkownika" };
        }

        public override void sort()
        {
            switch (SortField)
            {
                case "nazwaPowiadomienia":
                    List = new ObservableCollection<PowiadomieniaForView>(List.OrderBy(item => item.nazwaPowiadomienia));
                    break;
                case "powiadomienie":
                    List = new ObservableCollection<PowiadomieniaForView>(List.OrderBy(item => item.powiadomienie));
                    break;
                case "nazwaUzytkownika":
                    List = new ObservableCollection<PowiadomieniaForView>(List.OrderBy(item => item.nazwaUzytkownika));
                    break;
            }
        }

        public override List<string> getComboboxFindList()
        {
            return new List<string> { "nazwaPowiadomienia", "nazwaUzytkownika" };
        }

        public override void find()
        {
            switch (FindField)
            {
                case "nazwaPowiadomienia":
                    List = new ObservableCollection<PowiadomieniaForView>(List.Where(item => item.nazwaPowiadomienia != null && item.nazwaPowiadomienia.StartsWith(FindTextBox)));
                    break;
                case "nazwaUzytkownika":
                    List = new ObservableCollection<PowiadomieniaForView>(List.Where(item => item.nazwaUzytkownika != null && item.nazwaUzytkownika.StartsWith(FindTextBox)));
                    break;
            }
        }
    }
}
