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
        public int IdZamowienia { get; set; }
        public DateTime? dataZamowienia { get; set; }
        //ponizsze pola beada zamist id produktu
        public string? nazwaProduktu { get; set; }
        public decimal? cenaProduktu { get; set; }
        public string? nazwaUzytkownika { get; set; }
        #endregion
    }
}
