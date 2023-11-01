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
    class ListContactViewModel : WszystkieViewModel<Kontakty>
    {
        public ListContactViewModel() : base("StatystykiSilowni")
        {
        }

        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<Kontakty>
                (
                    //z bazy danych pobieram wszystkie dane
                    notlazyzoneEntities.Kontakties
                );
        }
        #endregion

    }
}
