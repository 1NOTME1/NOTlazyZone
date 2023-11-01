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
        public ShopViewModel() : base("Sklep")
        {
        }

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<Zamowienium>
                (
                    //z bazy danych pobieram wszystkie dane
                    notlazyzoneEntities.Zamowienia
                );
        }
        #endregion
    }
}
