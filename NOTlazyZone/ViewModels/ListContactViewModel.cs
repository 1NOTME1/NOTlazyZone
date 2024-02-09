using Azure;
using Firma.Models.EntitiesForView;
using NOTlazyZone.Helpers;
using NOTlazyZone.Models.BusinessLogic;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using System.Xml;

namespace NOTlazyZone.ViewModels
{
    class ListContactViewModel : WszystkieViewModel<KontaktyForView>
    {
        private readonly ContactInfo contactInfo;
        protected readonly NOTlazyZoneEntities nOTlazyZoneEntities;

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

        private int _liczbaKontaktow;

        public int LiczbaKontaktow
        {
            get => _liczbaKontaktow;
            set
            {
                _liczbaKontaktow = value;
                OnPropertyChanged(() => LiczbaKontaktow);
            }
        }

        private int? _Ilosc;
        public int? Ilosc
        {
            get
            {
                return _Ilosc;
            }
            set
            {
                if (value != _Ilosc)
                {
                    _Ilosc = value;
                    OnPropertyChanged(() => Ilosc);
                }
            }
        }

        private string _wybranaMiejscowosc;
        public string WybranaMiejscowosc
        {
            get => _wybranaMiejscowosc;
            set
            {
                if (_wybranaMiejscowosc != value)
                {
                    _wybranaMiejscowosc = value;
                    OnPropertyChanged(() => WybranaMiejscowosc);
                }
            }
        }


        private int? _Ilosc2;
        public int? Ilosc2
        {
            get
            {
                return _Ilosc2;
            }
            set
            {
                if (value != _Ilosc2)
                {
                    _Ilosc2 = value;
                    OnPropertyChanged(() => Ilosc2);
                }
            }
        }

        private int _RolaId;
        public int RolaId
        {
            get
            {
                return _RolaId;
            }
            set
            {
                if (value != _RolaId)
                {
                    _RolaId = value;
                    OnPropertyChanged(() => RolaId);
                }
            }
        }

        private List<string> _miejscowosc;
        public List<string> miejscowosc
        {
            get { return _miejscowosc; }
            set
            {
                _miejscowosc = value;
                OnPropertyChanged(()=> miejscowosc);
            }
        }

        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                _selectedDate = value;
                OnPropertyChanged(() => SelectedDate);
            }
        }


        public ListContactViewModel() : base("Lista Kontaktow")
        {
            load();
            nOTlazyZoneEntities = new NOTlazyZoneEntities();
            contactInfo = new ContactInfo(nOTlazyZoneEntities);
            SelectedDate = DateTime.Now;
            pokazMiejscowoscClick();
        }

        public IQueryable<KeyAndValue> UsRoComboBoxItems
        {
            get
            {
                return new ContactInfo(nOTlazyZoneEntities).GetRolaKeyAndValueItems();
            }
        }

        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                {
                    _ObliczCommand = new BaseCommand((object o) => obliczIloscClick());
                }
                return _ObliczCommand;
            }
        }

        private BaseCommand _ObliczCommand2;
        public ICommand ObliczCommand2
        {
            get
            {
                if (_ObliczCommand2 == null)
                {
                    _ObliczCommand2 = new BaseCommand((object o) => obliczIloscZakonczonychKarentow());
                }
                return _ObliczCommand2;
            }
        }

        private BaseCommand _ObliczCommand3;
        public ICommand ObliczCommand3
        {
            get
            {
                if (_ObliczCommand3 == null)
                {
                    _ObliczCommand3 = new BaseCommand((object o) => ZaladujLiczbeKontaktow());
                }
                return _ObliczCommand3;
            }
        }


        private void obliczIloscClick()
        {
            Ilosc = new ContactInfo(nOTlazyZoneEntities).CountUsersByRole(RolaId);
        }

        private void pokazMiejscowoscClick()
        {
            miejscowosc = new ContactInfo(nOTlazyZoneEntities).Adres().ToList();
        }

        private void ZaladujLiczbeKontaktow()
        {
            LiczbaKontaktow = contactInfo.CountContactsByMiejscowosc(WybranaMiejscowosc);
        }



        private void obliczIloscZakonczonychKarentow()
        {
            Ilosc2 = new ContactInfo(nOTlazyZoneEntities).CountUsersDateEnd(SelectedDate);
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
