using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class addZamowienieViewModel : JedenViewModel<Zamowienium>
    {
        public ObservableCollection<Zamowienium> Zamowienie { get; private set; } = new ObservableCollection<Zamowienium>();

        public addZamowienieViewModel() : base("Dodaj Adres")
        {
            item = new Zamowienium();
            LoadZamowienie();
            ZaDataZamowienia = DateTime.Now;
        }

        private void LoadZamowienie()
        {
            var zamowienieFromDb = notlazyzoneEntities.Zamowienia.ToList();
            foreach (var prod in zamowienieFromDb)
            {
                Zamowienie.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(ZaUsId):
                    return ZaUsId == 0 ? "Wybierz Użytkownika" : string.Empty;

                case nameof(ZaPrId):
                    return ZaPrId == 0 ? "Wybierz Produktu" : string.Empty;

                case nameof(ZaIlosc):
                    return ZaIlosc == 0 ? "Podaj ilość" : string.Empty;

                case nameof(ZaDataZamowienia):
                    return ZaDataZamowienia == DateTime.MinValue ? "Uzupełnij datę" : string.Empty;

                default: return string.Empty;
            }
        }
        public IQueryable<Uzytkownicy> ZaUsComboBoxItems
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
        public IQueryable<Produkty> ZaPrComboBoxItems
        {
            get
            {
                return
                    (
                        from Produkty in notlazyzoneEntities.Produkties
                        select Produkty
                    ).ToList().AsQueryable();
            }
        }

        public int ZaId
        {
            get
            {
                return item.ZaId;
            }
            set
            {
                if (item.ZaId != value)
                {
                    item.ZaId = value;
                    OnPropertyChanged(() => ZaId);
                }
            }
        }

        public int ZaUsId
        {
            get
            {
                return item.ZaUsId;
            }
            set
            {
                if (item.ZaUsId != value)
                {
                    item.ZaUsId = value;
                    OnPropertyChanged(() => ZaUsId);
                }
            }
        }

        public int ZaPrId
        {
            get
            {
                return item.ZaPrId;
            }
            set
            {
                if (item.ZaPrId != value)
                {
                    item.ZaPrId = value;
                    OnPropertyChanged(() => ZaPrId);
                }
            }
        }

        public int ZaIlosc
        {
            get
            {
                return item.ZaIlosc;
            }
            set
            {
                if (item.ZaIlosc != value)
                {
                    item.ZaIlosc = value;
                    OnPropertyChanged(() => ZaIlosc);
                }
            }
        }

        public DateTime ZaDataZamowienia
        {
            get
            {
                return item.ZaDataZamowienia;
            }
            set
            {
                if (item.ZaDataZamowienia != value)
                {
                    item.ZaDataZamowienia = value;
                    OnPropertyChanged(() => ZaDataZamowienia);
                }
            }
        }

    }
}
