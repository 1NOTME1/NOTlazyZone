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

namespace NOTlazyZone.ViewModels
{
    class ShopViewModel : WszystkieViewModel<ZamowieniaForView>
    {
        public ShopViewModel() : base("Sklep")
        {
            load();
        }

        #region Helpers
       
        public override void load()
        {
            List = new ObservableCollection<ZamowieniaForView>
                (
                    //dla kazdego zamowienia z bazy zamienia
                    from Zamowienium in notlazyzoneEntities.Zamowienia
                    //tworze nowa zamowieniaforview
                    select new ZamowieniaForView
                    {
                        IdZamowienia = Zamowienium.ZaId,
                        dataZamowienia = Zamowienium.ZaDataZamowienia,
                        nazwaProduktu = Zamowienium.ZaPr.PrNazwa,
                        cenaProduktu = Zamowienium.ZaPr.PrCena,
                        nazwaUzytkownika = Zamowienium.ZaUs.UsImie+" "
                        + Zamowienium.ZaUs.UsNazwisko

                    }
                );
        }
        #endregion
    }

}
