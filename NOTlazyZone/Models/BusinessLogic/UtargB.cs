using NOTlazyZone.Models.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.BusinessLogic
{
    public class UtargB:DatabaseClass
    {
        public UtargB(NOTlazyZoneEntities nOTlazyZoneEntities)
        :base(nOTlazyZoneEntities)
        { }


        public decimal? UtargTowraOkres(int idTowaru, DateTime dataOd, DateTime dataDo)
        {
            return
                (
                     from pozycja in nOTlazyZoneEntities.Zamowienia
                     where pozycja.ZaPr.PrId == idTowaru &&
                     pozycja.ZaDataZamowienia >= dataOd &&
                     pozycja.ZaDataZamowienia <= dataDo

                     select pozycja.ZaPr.PrCena * pozycja.ZaIlosc

                ).Sum();
        }
    }
}
