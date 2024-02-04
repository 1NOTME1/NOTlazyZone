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
    class ListContactViewModel : WszystkieViewModel<KontaktyForView>
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

        public ListContactViewModel() : base("Lista Kontaktow")
        {
            load();
        }

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<KontaktyForView>
            (
                from Kontakty in notlazyzoneEntities.Kontakties
                    //join Rola in notlazyzoneEntities.RolaUzytkownikas on Kontakty.KoUs.UsRoId equals Rola.RoId into RolaJoin
                    //from Rola in RolaJoin.DefaultIfEmpty()
                select new KontaktyForView
                {
                    IdKontaktu = Kontakty.KoId,
                    IdUzytkownika = Kontakty.KoUsId,
                    nazwaUzytkownika = Kontakty.KoUs.UsImie + " " + Kontakty.KoUs.UsNazwisko,
                    dataRozpoczecia = Kontakty.KoUs.UsDataRozpoczeciaOd,
                    dataZakonczenia = Kontakty.KoUs.UsDataRozpoczeciaOd,
                    czyUzytkownikAktywny = Kontakty.KoUs.UsAktywny,
                    numerTelefonu = Kontakty.KoUs.Telefons.Select(t => t.TnNumer).FirstOrDefault(),
                    rolaUzytkownika = Kontakty.KoUs.UsRo.RoRoleName,
                    //rolaUzytkownika = Rola != null ? Rola.RoRoleName : null,
                    nazwaAdresu = Kontakty.KoUs.Adres.Select(a => a.AdNazwa).FirstOrDefault(),
                    ulicaAdresu = Kontakty.KoUs.Adres.Select(a => a.AdUlica).FirstOrDefault(),
                    nrDomuAdresu = Kontakty.KoUs.Adres.Select(a => a.AdNrDomu).FirstOrDefault(),
                    nrLokaluAdresu = Kontakty.KoUs.Adres.Select(a => a.AdNrLokalu).FirstOrDefault(),
                    kodPocztowyAdresu = Kontakty.KoUs.Adres.Select(a => a.AdKod).FirstOrDefault(),
                    miejscowoscAdresu = Kontakty.KoUs.Adres.Select(a => a.AdMiejscowosc).FirstOrDefault(),
                    czyAdresAktywny = Kontakty.KoUs.Adres.Select(a => a.AdAktywny).FirstOrDefault(),
                    adresTypAdresu = Kontakty.KoUs.Adres.Select(at => at.AdAdt.AdtNazwa).FirstOrDefault()


                }
            );
        }
        #endregion
        public override List<string> getComboboxSortList()
        {
            return new List<string> { "nazwaUzytkownika", "dataRozpoczecia", "rolaUzytkownika" };
        }

        public override void sort()
        {
            switch (SortField)
            {
                case "nazwaUzytkownika":
                    List = new ObservableCollection<KontaktyForView>(List.OrderBy(item => item.nazwaUzytkownika));
                    break;
                case "dataRozpoczecia":
                    List = new ObservableCollection<KontaktyForView>(List.OrderBy(item => item.dataRozpoczecia));
                    break;
                case "rolaUzytkownika":
                    List = new ObservableCollection<KontaktyForView>(List.OrderBy(item => item.rolaUzytkownika));
                    break;
            }
        }

        public override List<string> getComboboxFindList()
        {
            return new List<string> { "nazwaUzytkownika", "rolaUzytkownika" };
        }

        public override void find()
        {
            switch (FindField)
            {
                case "nazwaUzytkownika":
                    List = new ObservableCollection<KontaktyForView>(List.Where(item => item.nazwaUzytkownika != null && item.nazwaUzytkownika.StartsWith(FindTextBox)));
                    break;
                case "rolaUzytkownika":
                    List = new ObservableCollection<KontaktyForView>(List.Where(item => item.rolaUzytkownika != null && item.rolaUzytkownika.StartsWith(FindTextBox)));
                    break;
            }
        }

    }

}
