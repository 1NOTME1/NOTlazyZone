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
    internal class AddMailViewModel : JedenViewModel<Mail>
    {
        public ICommand OpenModalMailCommand { get; private set; }

        public ObservableCollection<Mail> Mail { get; private set; } = new ObservableCollection<Mail>();
        #region Konstruktor
        public AddMailViewModel() : base("Dodaj Mail")
        {
            item = new Mail();
            LoadMail();
            OpenModalMailCommand = new RelayCommand(OpenModalMail);
        }
        #endregion

        private void OpenModalMail()
        {
            ModalMail modalView = new ModalMail
            {
                DataContext = this
            };
            WindowManager.OpenModalWindow(this, modalView);
        }

        private void LoadMail()
        {
            var mailFromDb = notlazyzoneEntities.Mail.ToList();
            foreach (var prod in mailFromDb)
            {
                Mail.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(MaUsId):
                    return MaUsId == 0 ? "Wypełnij pole uzytkownika" : string.Empty;

                case nameof(MaNazwa):
                    return string.IsNullOrEmpty(MaNazwa) ? "adres jest pusty" : string.Empty;

                case nameof(MaAktywny):
                    return !MaAktywny ? "Nie uzupełniłeś aktywności adresu mail" : string.Empty;

                default:
                    return string.Empty;
            }

        }

        public IQueryable<Uzytkownicy> MaUsComboBoxItems
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

        public int MaUsId
        {
            get
            {
                return item.MaUsId;
            }
            set
            {
                if (item.MaUsId != value)
                {
                    item.MaUsId = value;
                    OnPropertyChanged(() => MaUsId);
                }
            }
        }



        public String MaNazwa
        {
            get
            {
                return item.MaNazwa;
            }
            set
            {
                if (item.MaNazwa != value)
                {
                    item.MaNazwa = value;
                    OnPropertyChanged(() => MaNazwa);
                }
            }
        }

        public String? MaOpis
        {
            get
            {
                return item.MaOpis;
            }
            set
            {
                if (item.MaOpis != value)
                {
                    item.MaOpis = value;
                    OnPropertyChanged(() => MaOpis);
                }
            }
        }

        public String? MaUwagi
        {
            get
            {
                return item.MaUwagi;
            }
            set
            {
                if (item.MaUwagi != value)
                {
                    item.MaUwagi = value;
                    OnPropertyChanged(() => MaUwagi);
                }
            }
        }

        public bool MaAktywny
        {
            get
            {
                return item.MaAktywny;
            }
            set
            {
                if (item.MaAktywny != value)
                {
                    item.MaAktywny = value;
                    OnPropertyChanged(() => MaAktywny);
                }
            }
        }

    }
}
