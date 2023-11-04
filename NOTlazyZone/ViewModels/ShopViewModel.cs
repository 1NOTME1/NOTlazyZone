using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    class ShopViewModel : WszystkieViewModel<Zamowienium>
    {
        private ObservableCollection<Produkty> _produkty;

        public ObservableCollection<Produkty> Produkty
        {
            get { return _produkty; }
            set
            {
                _produkty = value;
                OnPropertyChanged(() => Produkty);


            }
        }

        public ShopViewModel() : base("Sklep")
        {
            load();
        }

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<Zamowienium>(
                //z bazy danych pobieram wszystkie dane
                notlazyzoneEntities.Zamowienia
            );

            // Załaduj dodatkową tabelę Produkty
            Produkty = new ObservableCollection<Produkty>(
                //z bazy danych pobieram wszystkie dane
                notlazyzoneEntities.Produkties
            );
        }
        #endregion
    }

}
