﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.EntitiesForView
{
    //klasa do wyswietlania danych z tabel ktore maja klucze obce
    //za_id, pr_nazwa, pr_cena, us_imie, us_nazwisko, za_data_zamowienia
    public class ZamowieniaForView
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
