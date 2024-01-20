using Microsoft.IdentityModel.Tokens;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class AddAdresViewModel : JedenViewModel<Adre>
    {
        public ObservableCollection<Adre> Adres { get; private set; } = new ObservableCollection<Adre>();
        #region Konstruktor
        public AddAdresViewModel() : base("Dodaj Adres")
        {
            item = new Adre();
            LoadAdres();
        }
        #endregion
        private void LoadAdres()
        {
            var adresFromDb = notlazyzoneEntities.Adres.ToList();
            foreach (var prod in adresFromDb)
            {
                Adres.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(AdAdtId):
                    return AdAdtId == 0 ? "Nie uzupełniłeś typu adresu" : string.Empty;

                case nameof(AdUsId):
                    return AdUsId == 0 ? "Nie przypisaleś użytkownika" : string.Empty;

                case nameof(AdNazwa):
                    return AdNazwa.IsNullOrEmpty() ? "Nie uzupełnijłeś nazwy" : string.Empty;

                case nameof(AdOpis):
                    return AdOpis.IsNullOrEmpty() ? "Nie uzupełniłeś opisu" : string.Empty;

                //case nameof(AdUwagi):
                //    return AdUwagi.IsNullOrEmpty() ? "Nie uzupełniłeś uwag" : string.Empty;

                case nameof(AdUlica):
                    return AdUlica.IsNullOrEmpty() ? "Nie uzupełniłeś ulicy" : string.Empty;

                case nameof(AdNrDomu):
                    return AdNrDomu.IsNullOrEmpty() ? "Nie uzupełniłeś numeru domu" : string.Empty;

                case nameof(AdNrLokalu):
                    return AdNrLokalu.IsNullOrEmpty() ? "Nie uzupełniłeś numeru lokalu" : string.Empty;

                case nameof(AdKod):
                    return AdKod.IsNullOrEmpty() ? "Nie uzupełniłeś kodu pocztowego" : string.Empty;

                case nameof(AdMiejscowosc):
                    return AdMiejscowosc.IsNullOrEmpty() ? "Nie uzupełniłeś miejscowosci" : string.Empty;

                case nameof(AdAktywny):
                    return !AdAktywny ? "Nie uzupełniłeś aktywności adresu" : string.Empty;


                default: return string.Empty;
            }
        }

        public IQueryable<AdresTyp> AdAdtComboBoxItems
        {
            get
            {
                return
                    (
                        from AdresTyp in notlazyzoneEntities.AdresTyps
                        select AdresTyp
                    ).ToList().AsQueryable();
            }
        }

        public int AdAdtId
        {
            get
            {
                return item.AdAdtId;
            }
            set
            {
                if (item.AdAdtId != value)
                {
                    item.AdAdtId = value;
                    OnPropertyChanged(() => AdAdtId);
                }
            }
        }

        public IQueryable<Uzytkownicy> AdUsComboBoxItems
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

        public int AdUsId
        {
            get
            {
                return item.AdUsId;
            }
            set
            {
                if (item.AdUsId != value)
                {
                    item.AdUsId = value;
                    OnPropertyChanged(() => AdUsId);
                }
            }
        }

        public string AdNazwa
        {
            get
            {
                return item.AdNazwa;
            }
            set
            {
                if (item.AdNazwa != value)
                {
                    item.AdNazwa = value;
                    OnPropertyChanged(() => AdNazwa);
                }
            }
        }

        public string AdOpis
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
                    OnPropertyChanged(() => AdOpis);
                }
            }
        }

        

        public string? AdUwagi
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
                    OnPropertyChanged(() => AdUwagi);
                }
            }
        }

        public string AdUlica
        {
            get
            {
                return item.AdUlica;
            }
            set
            {
                if (item.AdUlica != value)
                {
                    item.AdUlica = value;
                    OnPropertyChanged(() => AdUlica);
                }
            }
        }

        public string? AdNrDomu
        {
            get
            {
                return item.AdNrDomu;
            }
            set
            {
                if (item.AdNrDomu != value)
                {
                    item.AdNrDomu = value;
                    OnPropertyChanged(() => AdNrDomu);
                }
            }
        }

        public string? AdNrLokalu
        {
            get
            {
                return item.AdNrLokalu;
            }
            set
            {
                if (item.AdNrLokalu != value)
                {
                    item.AdNrLokalu = value;
                    OnPropertyChanged(() => AdNrLokalu);
                }
            }
        }

        public string AdKod
        {
            get
            {
                return item.AdKod;
            }
            set
            {
                if (item.AdKod != value)
                {
                    item.AdKod = value;
                    OnPropertyChanged(() => AdKod);
                }
            }
        }

        public string AdMiejscowosc
        {
            get
            {
                return item.AdMiejscowosc;
            }
            set
            {
                if (item.AdMiejscowosc != value)
                {
                    item.AdMiejscowosc = value;
                    OnPropertyChanged(() => AdMiejscowosc);
                }
            }
        }

        public bool AdAktywny
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
                    OnPropertyChanged(() => AdAktywny);
                }
            }
        }


    }
}
