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
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    class ShopViewModel : WszystkieViewModel<ZamowieniaForView>
    {

        protected readonly NOTlazyZoneEntities nOTlazyZoneEntities;
        #region Properties

        private DateTime _DataOd;
        public DateTime DataOd
        {
            get
            {
                return _DataOd;
            }
            set
            {
                if (value != _DataOd)
                {
                    _DataOd = value;
                    OnPropertyChanged(() => DataOd);
                }
            }
        }

        private DateTime _DataDo;
        public DateTime DataDo
        {
            get
            {
                return _DataDo;
            }
            set
            {
                if (value != _DataDo)
                {
                    _DataDo = value;
                    OnPropertyChanged(() => DataDo);
                }
            }
        }

        private int _IdTowaru;
        public int IdTowaru
        {
            get
            {
                return _IdTowaru;
            }
            set
            {
                if (value != _IdTowaru)
                {
                    _IdTowaru = value;
                    OnPropertyChanged(() => IdTowaru);
                }
            }
        }

        private decimal? _Utarg;
        public decimal? Utarg
        {
            get
            {
                return _Utarg;
            }
            set
            {
                if (value != _Utarg)
                {
                    _Utarg = value;
                    OnPropertyChanged(() => Utarg);
                }
            }
        }

        public IQueryable<KeyAndValue> TowaryComboBoxItems
        {
            get
            {
                return new TowarB(nOTlazyZoneEntities).GetTowaryKeyAndValueItems();
            }
        }



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
        public ShopViewModel() : base("Sklep")
        {
            load();
            nOTlazyZoneEntities = new NOTlazyZoneEntities();
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
        }

        private BaseCommand _ObliczCommand;
        public ICommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                {
                    _ObliczCommand = new BaseCommand((object o) => obliczUtargClick());
                }
                return _ObliczCommand;
            }
        }


        private void obliczUtargClick()
        {
            //to jest wywolanie funkcji z klasy logiki biznesowej UtargB
            Utarg = new UtargB(nOTlazyZoneEntities).UtargTowraOkres(IdTowaru, DataOd, DataDo);
        }

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<ZamowieniaForView>
            (
                from Zamowienium in notlazyzoneEntities.Zamowienia
                select new ZamowieniaForView
                {
                    IdZamowienia = Zamowienium.ZaId,
                    dataZamowienia = Zamowienium.ZaDataZamowienia,
                    nazwaProduktu = Zamowienium.ZaPr.PrNazwa,
                    cenaProduktu = Zamowienium.ZaPr.PrCena,
                    iloscProduktow = Zamowienium.ZaIlosc,
                    nazwaUzytkownika = Zamowienium.ZaUs.UsImie + " " + Zamowienium.ZaUs.UsNazwisko
                }
            );
        }


        public override List<string> getComboboxSortList()
        {
            return new List<string> { "nazwaProduktu", "cenaProduktu", "dataZamowienia" };
        }

        public override void sort()
        {
            switch (SortField)
            {
                case "nazwaProduktu":
                    List = new ObservableCollection<ZamowieniaForView>(List.OrderBy(item => item.nazwaProduktu));
                    break;
                case "cenaProduktu":
                    List = new ObservableCollection<ZamowieniaForView>(List.OrderBy(item => item.cenaProduktu));
                    break;
                case "dataZamowienia":
                    List = new ObservableCollection<ZamowieniaForView>(List.OrderBy(item => item.dataZamowienia));
                    break;
            }
        }

        public override List<string> getComboboxFindList()
        {
            return new List<string> { "nazwaProduktu", "nazwaUzytkownika" };
        }

        public override void find()
        {
            switch (FindField)
            {
                case "nazwaProduktu":
                    List = new ObservableCollection<ZamowieniaForView>(List.Where(item => item.nazwaProduktu != null && item.nazwaProduktu.StartsWith(FindTextBox)));
                    break;
                case "nazwaUzytkownika":
                    List = new ObservableCollection<ZamowieniaForView>(List.Where(item => item.nazwaUzytkownika != null && item.nazwaUzytkownika.StartsWith(FindTextBox)));
                    break;
            }
        }

        #endregion

    }

}
