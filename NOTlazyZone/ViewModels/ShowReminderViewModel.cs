using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace NOTlazyZone.ViewModels
{
    class ShowReminderViewModel : WszystkieViewModel<PowiadomieniaForView>
    {
        public ShowReminderViewModel() : base("Powiadomienia")
        {
            load();
        }

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<PowiadomieniaForView>
                (
                    from Powiadomienium in notlazyzoneEntities.Powiadomienia
                    select new PowiadomieniaForView
                    {
                        IdPowiadomienia = Powiadomienium.PoId,
                        powiadomienie = Powiadomienium.PoTimestamp,
                        nazwaPowiadomienia = Powiadomienium.PoNazwa,
                        UsId = Powiadomienium.PoUsId,
                        nazwaUzytkownika = Powiadomienium.PoUs.UsImie + " "
                        + Powiadomienium.PoUs.UsNazwisko,
                        uwagi = Powiadomienium.PoUs.UsUwagi,
                        DaId = Powiadomienium.PoUs.Dieta.Select(d => d.DaId).FirstOrDefault(),
                        CwId = Powiadomienium.PoUs.Cwiczenia.Select(c => c.CwId).FirstOrDefault()


                    }
                );
        }
        #endregion
    }
}
