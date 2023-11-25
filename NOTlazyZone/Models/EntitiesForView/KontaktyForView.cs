using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.EntitiesForView
{
    //klasa do wyswietlania danych z tabel ktore maja klucze obce
    public class KontaktyForView
    {
        #region Dane
        public int IdKontaktu { get; set; }
        public int? IdUzytkownika { get; set; }
        public string? nazwaUzytkownika { get; set; }
        public DateTime? dataRozpoczecia { get; set; }
        public DateTime? dataZakonczenia { get; set; }
        public bool? czyUzytkownikAktywny { get; set; }
        public int RolaUzytkownika { get; set; }
        public string numerTelefonu { get; set; }
        public string typUzytkownika { get; set; }

        #endregion
    }
}
