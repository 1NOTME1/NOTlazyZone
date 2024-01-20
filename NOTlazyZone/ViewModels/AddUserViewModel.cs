using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class AddUserViewModel : JedenViewModel<Uzytkownicy>
    {

        public ObservableCollection<Uzytkownicy> User { get; private set; } = new ObservableCollection<Uzytkownicy>();
        #region Konstruktor
        public AddUserViewModel() : base("Uzytkownik")
        {
            item = new Uzytkownicy();
            LoadUser();
        }
        #endregion
        private void LoadUser()
        {
            var userFromDb = notlazyzoneEntities.Uzytkownicies.ToList();
            foreach (var prod in userFromDb)
            {
                User.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(UsImie):
                    return string.IsNullOrEmpty(UsImie) ? "Wypełnij pole Imię" : string.Empty;

                case nameof(UsNazwisko):
                    return string.IsNullOrEmpty(UsNazwisko) ? "Wypełnij pole Nazwisko" : string.Empty;

                case nameof(UsPesel):
                    return string.IsNullOrEmpty(UsPesel) ? "Wypełnij pole PESEL" : string.Empty;

                case nameof(UsDataRozpoczeciaOd):
                    return UsDataRozpoczeciaOd == DateTime.MinValue ? "Uzupełnij datę" : string.Empty;

                case nameof(UsDataZakonczeniaDo):
                    return UsDataZakonczeniaDo == DateTime.MinValue ? "Uzupełnij datę" : string.Empty;


                case nameof(UsAktywny):
                    return !UsAktywny ? "Uzupełnij pole aktywności telefonu" : string.Empty;

                case nameof(UsRoId):
                    return UsRoId == 0 ? "Przypisz role do uzytkownika" : string.Empty;

                default:
                    return string.Empty;
            }

        }



        #region Dane

        public IQueryable<RolaUzytkownika> UsRoComboBoxItems
        {
            get
            {
                return
                    (
                        from RolaUzytkownika in notlazyzoneEntities.RolaUzytkownikas
                        select RolaUzytkownika
                    ).ToList().AsQueryable();
            }
        }

        public String UsImie
        {
            get
            {
                return item.UsImie;
            }
            set
            {
                if (item.UsImie != value)
                {
                    item.UsImie = value;
                    OnPropertyChanged(() => UsImie);
                }
            }
        }

        public String UsNazwisko
        {
            get
            {
                return item.UsNazwisko;
            }
            set
            {
                if (item.UsNazwisko != value)
                {
                    item.UsNazwisko = value;
                    OnPropertyChanged(() => UsNazwisko);
                }
            }
        }

        public String UsPesel
        {
            get
            {
                return item.UsPesel;
            }
            set
            {
                if (item.UsPesel != value)
                {
                    item.UsPesel = value;
                    OnPropertyChanged(() => UsPesel);
                }
            }
        }

        public DateTime UsDataRozpoczeciaOd
        {
            get
            {
                return item.UsDataRozpoczeciaOd;
            }
            set
            {
                if (item.UsDataRozpoczeciaOd != value)
                {
                    item.UsDataRozpoczeciaOd = value;
                    OnPropertyChanged(() => UsDataRozpoczeciaOd);
                }
            }
        }

        public DateTime UsDataZakonczeniaDo
        {
            get
            {
                return item.UsDataZakonczeniaDo;
            }
            set
            {
                if (item.UsDataZakonczeniaDo != value)
                {
                    item.UsDataZakonczeniaDo = value;
                    OnPropertyChanged(() => UsDataZakonczeniaDo);
                }
            }
        }

        public string? UsOpis
        {
            get
            {
                return item.UsOpis;
            }
            set
            {
                if (item.UsOpis != value)
                {
                    item.UsOpis = value;
                    OnPropertyChanged(() => UsOpis);
                }
            }
        }

        public string UsUwagi
        {
            get
            {
                return item.UsUwagi;
            }
            set
            {
                if (item.UsUwagi != value)
                {
                    item.UsUwagi = value;
                    OnPropertyChanged(() => UsUwagi);
                }
            }
        }

        public bool UsAktywny
        {
            get
            {
                return item.UsAktywny;
            }
            set
            {
                if (item.UsAktywny != value)
                {
                    item.UsAktywny = value;
                    OnPropertyChanged(() => UsAktywny);
                }
            }
        }

        public int? UsRoId
        {
            get
            {
                return item.UsRoId;
            }
            set
            {
                if (item.UsRoId != value)
                {
                    item.UsRoId = value;
                    OnPropertyChanged(() => UsRoId);
                }
            }
        }
        #endregion
    }
}

