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
    class ListContactViewModel : WszystkieViewModel<KontaktyForView>
    {
        public ListContactViewModel() : base("Lista Kontaktow")
        {
            load();
        }

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<KontaktyForView>
            (
            //dla kazdego zamowienia z bazy zamienia
                    from Kontakty in notlazyzoneEntities.Kontakties
                        //tworze nowa zamowieniaforview
                    select new KontaktyForView
                    {
                        IdKontaktu = Kontakty.KoId,
                        IdUzytkownika = Kontakty.KoUsId,
                        nazwaUzytkownika = Kontakty.KoUs.UsImie + " "
                        + Kontakty.KoUs.UsNazwisko,
                        dataRozpoczecia = Kontakty.KoUs.UsDataRozpoczeciaOd,
                        dataZakonczenia = Kontakty.KoUs.UsDataRozpoczeciaOd,
                        czyUzytkownikAktywny = Kontakty.KoUs.UsAktywny,
                        numerTelefonu = Kontakty.KoUs.Telefons.Select(t => t.TnNumer).FirstOrDefault(),
                        typUzytkownika = Kontakty.KoUs.RolaUzytkownikas.Select(r => r.RoRoleName).FirstOrDefault()


                    }
                );


        }

        #endregion
    }
    
}
