using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    class ShowDietViewModel : WszystkieViewModel<DietForView>
    {
        public ShowDietViewModel() : base("Zarządzanie Dieta")
        {
            load();
        }

        public override void load()
        {
            List = new ObservableCollection<DietForView>
                (
                    //dla kazdego zamowienia z bazy zamienia
                    from Dietum in notlazyzoneEntities.Dieta
                        //tworze nowa zamowieniaforview
                    select new DietForView
                    {
                       idDiety = Dietum.DaId,
                       nazwaDiety = Dietum.DaNazwa,
                       idUzytkownika = Dietum.DaUsId,
                       iloscKalorii = Dietum.DaColorie,
                       iloscBialka = Dietum.DaIloscBialka,
                       iloscWegli = Dietum.DaIloscWeglowodanow,
                       iloscTluszczy = Dietum.DaIloscTluszczy,
                       rodzajDiety = Dietum.DaDat.DatRodzaj

                    }
                );
        }
    }
}
