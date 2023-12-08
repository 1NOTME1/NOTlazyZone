using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.EntitiesForView
{
    internal class PowiadomieniaForView
    {
        public int IdPowiadomienia { get; set; }
        public DateTime? powiadomienie { get; set; }
        public int? UsId { get; set; }
        public string? nazwaUzytkownika { get; set; }
        public string? nazwaPowiadomienia { get; set; }
        public string? uwagi { get; set; }
        public int DaId { get; set; }

        public int CwId { get; set; }

    }
}
