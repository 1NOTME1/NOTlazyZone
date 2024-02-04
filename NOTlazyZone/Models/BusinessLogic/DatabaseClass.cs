using NOTlazyZone.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.BusinessLogic
{
    public class DatabaseClass
    {
        #region Fields
        protected NOTlazyZoneEntities nOTlazyZoneEntities;
        #endregion

        #region Constructor
        public DatabaseClass(NOTlazyZoneEntities nOTlazyZoneEntities)
        {
            this.nOTlazyZoneEntities = nOTlazyZoneEntities;
        }
        #endregion



    }
}
