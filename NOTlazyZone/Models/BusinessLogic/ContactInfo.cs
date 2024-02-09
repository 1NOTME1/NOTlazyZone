using Firma.Models.EntitiesForView;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.BusinessLogic
{
    public class ContactInfo : DatabaseClass
    {
        public ContactInfo(NOTlazyZoneEntities nOTlazyZoneEntities)
            : base(nOTlazyZoneEntities)
        {
        }

        public IQueryable<KeyAndValue> GetRolaKeyAndValueItems()
        {
            return
            (
                from rola in nOTlazyZoneEntities.RolaUzytkownikas
                select new KeyAndValue
                {
                    Key = rola.RoId,
                    Value = rola.RoRoleName
                }
                ).ToList().AsQueryable();
        }

        public int CountUsersByRole(int rolaId)
        {
            return nOTlazyZoneEntities.Uzytkownicies
                .Count(ilosc => ilosc.UsRoId == rolaId);
        }

        public int CountUsersDateEnd(DateTime selectedDate)
        {
            return nOTlazyZoneEntities.Uzytkownicies
                .Count(user => user.UsDataZakonczeniaDo < selectedDate);
        }

        public IQueryable<string> Adres()
        {
            return nOTlazyZoneEntities.Adres
                .Select(adres => adres.AdMiejscowosc)
                .Distinct()
                .AsQueryable();
        }

        public int CountContactsByMiejscowosc(string wybranaMiejscowosc)
        {
            var liczbaKontaktow = nOTlazyZoneEntities.Kontakties
                .Join(nOTlazyZoneEntities.Uzytkownicies, kontakt => kontakt.KoUsId, uzytkownik => uzytkownik.UsId, (kontakt, uzytkownik) => new { Kontakt = kontakt, Uzytkownik = uzytkownik })
                .Join(nOTlazyZoneEntities.Adres, rezultat => rezultat.Uzytkownik.UsId, adres => adres.AdUsId, (rezultat, adres) => new { Rezultat = rezultat, Adres = adres })
                .Count(wynik => wynik.Adres.AdMiejscowosc == wybranaMiejscowosc);

            return liczbaKontaktow;
        }











    }
}
