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
        }

        private void LoadZamowienie()
        {
            var zamowienieFromDb = notlazyzoneEntities.Zamowienia.ToList();
            foreach (var prod in zamowienieFromDb)
            {
                Zamowienie.Add(prod);
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

        public int? ZaUsId
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

        public int? ZaPrId
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
