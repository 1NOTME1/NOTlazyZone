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
                from Kontakty in notlazyzoneEntities.Kontakties
                join Rola in notlazyzoneEntities.RolaUzytkownikas on Kontakty.KoUs.UsRoId equals Rola.RoId into RolaJoin
                from Rola in RolaJoin.DefaultIfEmpty()
                select new KontaktyForView
                {
                    IdKontaktu = Kontakty.KoId,
                    IdUzytkownika = Kontakty.KoUsId,
                    nazwaUzytkownika = Kontakty.KoUs.UsImie + " " + Kontakty.KoUs.UsNazwisko,
                    dataRozpoczecia = Kontakty.KoUs.UsDataRozpoczeciaOd,
                    dataZakonczenia = Kontakty.KoUs.UsDataRozpoczeciaOd,
                    czyUzytkownikAktywny = Kontakty.KoUs.UsAktywny,
                    numerTelefonu = Kontakty.KoUs.Telefons.Select(t => t.TnNumer).FirstOrDefault(),

                    rolaUzytkownika = Rola != null ? Rola.RoRoleName : null,
                    nazwaAdresu = Kontakty.KoUs.Adres.Select(a => a.AdNazwa).FirstOrDefault(),
                    ulicaAdresu = Kontakty.KoUs.Adres.Select(a => a.AdUlica).FirstOrDefault(),
                    nrDomuAdresu = Kontakty.KoUs.Adres.Select(a => a.AdNrDomu).FirstOrDefault(),
                    nrLokaluAdresu = Kontakty.KoUs.Adres.Select(a => a.AdNrLokalu).FirstOrDefault(),
                    kodPocztowyAdresu = Kontakty.KoUs.Adres.Select(a => a.AdKod).FirstOrDefault(),
                    miejscowoscAdresu = Kontakty.KoUs.Adres.Select(a => a.AdMiejscowosc).FirstOrDefault(),
                    czyAdresAktywny = Kontakty.KoUs.Adres.Select(a => a.AdAktywny).FirstOrDefault(),
                    adresTypAdresu = Kontakty.KoUs.Adres.Select(at => at.AdAdt.AdtNazwa).FirstOrDefault()


                }
            );
        }





        #endregion
    }

}
