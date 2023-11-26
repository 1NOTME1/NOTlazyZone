using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class AddListContactViewModel : JedenViewModel<Kontakty>
    {
        public ObservableCollection<Kontakty> Kontakty { get; private set; } = new ObservableCollection<Kontakty>();

        public AddListContactViewModel() : base("Dodaj Cwiczenie")
        {
            item = new Kontakty();
            LoadKontakt();
        }
        private void LoadKontakt()
        {
            var kontaktyFromDb = notlazyzoneEntities.Kontakties.ToList();
            foreach (var prod in kontaktyFromDb)
            {
                Kontakty.Add(prod);
            }
        }

        #region Dane
        //dla kazdego elementu na interfejsie ktory bedzie dodawany tworzymy wlasciwosc

        public int? KoUsId
        {
            get
            {
                return item.KoUsId;
            }
            set
            {
                if (item.KoUsId != value)
                {
                    item.KoUsId = value;
                    OnPropertyChanged(() => KoUsId);
                }
            }
        }

        public IQueryable<Uzytkownicy> KoUsComboBoxItems
        {
            get
            {
                return
                    (
                        from Uzytkownicy in notlazyzoneEntities.Uzytkownicies
                        select Uzytkownicy
                    ).ToList().AsQueryable();
            }
        }

        //public String? UsImie
        //{
        //    get
        //    {
        //        return item.UsImie;
        //    }
        //    set
        //    {
        //        if (item.UsImie != value)
        //        {
        //            item.UsImie = value;
        //            OnPropertyChanged(() => UsImie);
        //        }
        //    }
        //}

        //public String? UsNazwisko
        //{
        //    get
        //    {
        //        return item.UsNazwisko;
        //    }
        //    set
        //    {
        //        if (item.UsNazwisko != value)
        //        {
        //            item.UsNazwisko = value;
        //            OnPropertyChanged(() => UsNazwisko);
        //        }
        //    }
        //}

        //public String? UsPesel
        //{
        //    get
        //    {
        //        return item.UsPesel;
        //    }
        //    set
        //    {
        //        if (item.UsPesel != value)
        //        {
        //            item.UsPesel = value;
        //            OnPropertyChanged(() => UsPesel);
        //        }
        //    }
        //}

        //public DateTime? UsDataRozpoczeciaOd
        //{
        //    get
        //    {
        //        return item.UsDataRozpoczeciaOd;
        //    }
        //    set
        //    {
        //        if (item.UsDataRozpoczeciaOd != value)
        //        {
        //            item.UsDataRozpoczeciaOd = value;
        //            OnPropertyChanged(() => UsDataRozpoczeciaOd);
        //        }
        //    }
        //}

        //public DateTime? UsDataZakonczeniaDo
        //{
        //    get
        //    {
        //        return item.UsDataZakonczeniaDo;
        //    }
        //    set
        //    {
        //        if (item.UsDataZakonczeniaDo != value)
        //        {
        //            item.UsDataZakonczeniaDo = value;
        //            OnPropertyChanged(() => UsDataZakonczeniaDo);
        //        }
        //    }
        //}

        //public string? UsOpis
        //{
        //    get
        //    {
        //        return item.UsOpis;
        //    }
        //    set
        //    {
        //        if (item.UsOpis != value)
        //        {
        //            item.UsOpis = value;
        //            OnPropertyChanged(() => UsOpis);
        //        }
        //    }
        //}

        //public string? UsUwagi
        //{
        //    get
        //    {
        //        return item.UsUwagi;
        //    }
        //    set
        //    {
        //        if (item.UsUwagi != value)
        //        {
        //            item.UsUwagi = value;
        //            OnPropertyChanged(() => UsUwagi);
        //        }
        //    }
        //}

        //public bool? UsAktywny
        //{
        //    get
        //    {
        //        return item.UsAktywny;
        //    }
        //    set
        //    {
        //        if (item.UsAktywny != value)
        //        {
        //            item.UsAktywny = value;
        //            OnPropertyChanged(() => UsAktywny);
        //        }
        //    }
        //}


        #endregion

    }
}
