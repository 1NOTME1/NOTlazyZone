using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.EntitiesForView
{
    class DietForView
    {
        public int idDiety { get; set; }
        public string nazwaDiety { get; set; }
        public int? idUzytkownika { get; set; }
        public int? iloscKalorii { get; set; }
        public int? iloscBialka { get; set; }
        public int? iloscWegli { get; set; }
        public int? iloscTluszczy { get; set; }
        public string? rodzajDiety { get; set; }
    }
}
