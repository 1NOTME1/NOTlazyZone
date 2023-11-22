using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.EntitiesForView
{
    internal class CwiczeniaForView
    {
        #region Dane
        public int IdCwiczenia { get; set; }
        public string? nazwaCwiczenia { get; set; }
        //ponizsze pola beada zamist id produktu
        public string? typCwiczenia { get; set; }
        public int? potworzenieCwiczenia { get; set; }
        public string? nazwaUzytkownika { get; set; }
        #endregion
    }
}
