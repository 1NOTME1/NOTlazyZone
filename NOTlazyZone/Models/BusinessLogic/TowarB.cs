using Firma.Models.EntitiesForView;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.BusinessLogic
{
    public class TowarB : DatabaseClass
    {
        #region Construktor
        public TowarB(NOTlazyZoneEntities nOTlazyZoneEntities) 
            : base(nOTlazyZoneEntities) { }
        #endregion

        public IQueryable<KeyAndValue> GetTowaryKeyAndValueItems()
        {
            return
            (
                from towar in nOTlazyZoneEntities.Produkties
                select new KeyAndValue
                {
                    Key = towar.PrId,
                    Value = towar.PrNazwa
                }
                ).ToList().AsQueryable();
        }


    }
}
