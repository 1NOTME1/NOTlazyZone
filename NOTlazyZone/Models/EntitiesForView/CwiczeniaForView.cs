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
        public int? IdPlanu { get; set; }
        public int IdCwiczenia { get; set; }
        public string? nazwaCwiczenia { get; set; }
        public string? typCwiczenia { get; set; }
        public int? seriaCwiczenia { get; set; }
        public TimeSpan? czasPlanu { get; set; }
        //ponizsze pola beada zamist id produktu
        public decimal ciezarCwiczenia { get; set; }
        public decimal? przerwaCwiczenia { get; set; }
        public int? trudnoscCwiczenia { get; set; }
        public string? nazwaUzytkownika { get; set; }
        public string? opisCwiczenia { get; set; }
        #endregion
    }
}
