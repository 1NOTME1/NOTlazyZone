using NOTlazyZone.Helpers;
using NOTlazyZone.Models.Context;
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
    internal class AddTelefonViewModel : JedenViewModel<Telefon>
    {
        public ICommand OpenModalTelefonCommand { get; private set; }
        public ObservableCollection<Telefon> Telefon { get; private set; } = new ObservableCollection<Telefon>();
    #region Konstruktor
    public AddTelefonViewModel() : base("Uzytkownik")
    {
        item = new Telefon();
        LoadPhone();
        OpenModalTelefonCommand = new RelayCommand(OpenModalTelefon);

        }
        #endregion

        private void OpenModalTelefon()
        {
            ModalPhone modalView = new ModalPhone
            {
                DataContext = this
            };
            WindowManager.OpenModalWindow(this, modalView);
        }

        private void LoadPhone()
    {
        var phoneFromDb = notlazyzoneEntities.Telefons.ToList();
        foreach (var prod in phoneFromDb)
        {
            Telefon.Add(prod);
        }
    }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(TnNumer):
                    return string.IsNullOrEmpty(TnNumer) ? "Podaj numer telefonu" : string.Empty;

                case nameof(TnAktywny):
                    return !TnAktywny ? "Uzupełnij pole aktywności telefonu" : string.Empty;

                case nameof(TnUsId):
                    return TnUsId == 0 ? "Przypisz uzytkownika do numeru" : string.Empty;

                default:
                    return string.Empty;
            }

        }
        #region Dane

        public String TnNumer
        {
            get
            {
                return item.TnNumer;
            }
            set
            {
                if (item.TnNumer != value)
                {
                    item.TnNumer = value;
                    OnPropertyChanged(() => TnNumer);
                }
            }
        }

        public String? TnOpis
        {
            get
            {
                return item.AdOpis;
            }
            set
            {
                if (item.AdOpis != value)
                {
                    item.AdOpis = value;
                    OnPropertyChanged(() => TnOpis);
                }
            }
        }

        public String? TnUwagi
        {
            get
            {
                return item.AdUwagi;
            }
            set
            {
                if (item.AdUwagi != value)
                {
                    item.AdUwagi = value;
                    OnPropertyChanged(() => TnUwagi);
                }
            }
        }

        public bool TnAktywny
        {
            get
            {
                return item.AdAktywny;
            }
            set
            {
                if (item.AdAktywny != value)
                {
                    item.AdAktywny = value;
                    OnPropertyChanged(() => TnAktywny);
                }
            }
        }

        public IQueryable<Uzytkownicy> TnUsComboBoxItems
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

        public int TnUsId
        {
            get
            {
                return item.TnUsId;
            }
            set
            {
                if (item.TnUsId != value)
                {
                    item.TnUsId = value;
                    OnPropertyChanged(() => TnUsId);
                }
            }
        }


        #endregion
    }
}
