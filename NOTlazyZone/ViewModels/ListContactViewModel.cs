using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace NOTlazyZone.ViewModels
{
    class ListContactViewModel : WszystkieViewModel<ZamowieniaForView>
    {
        public ListContactViewModel() : base("Sklep")
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
                        nazwaUzytkownika = Zamowienium.ZaUs.UsImie + " "
                        + Zamowienium.ZaUs.UsNazwisko

                    }
                );
        }
        #endregion
    }
    //class ListContactViewModel : WorkspaceViewModel
    //{
    //    public ListContactViewModel()
    //    {
    //        base.DisplayName = "Kontakty";
    //    }
    //}

    //class ListContactViewModel : WszystkieViewModel<Kontakty>
    //{
    //    public ListContactViewModel() : base("Kontakty")
    //    {
    //    }

    //    #region Helpers
    //    public override void load()
    //    {
    //        List = new ObservableCollection<Kontakty>
    //            (
    //                //z bazy danych pobieram wszystkie dane
    //                notlazyzoneEntities.Kontakties
    //            );
    //    }
    //    #endregion

    //}
}
