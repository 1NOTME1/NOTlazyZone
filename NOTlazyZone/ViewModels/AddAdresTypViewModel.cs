using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    class AddAdresTypViewModel : JedenViewModel<AdresTyp>
    {
        public ObservableCollection<AdresTyp> AdresTyp { get; private set; } = new ObservableCollection<AdresTyp>();
        #region Konstruktor
        public AddAdresTypViewModel() : base("Dodaj Typ Adresu")
        {
            item = new AdresTyp();
            LoadAdresTyp();
        }
        #endregion
        private void LoadAdresTyp()
        {
            var adresTypFromDb = notlazyzoneEntities.AdresTyps.ToList();
            foreach (var prod in adresTypFromDb)
            {
                AdresTyp.Add(prod);
            }
        }

        public string? AdtNazwa
        {
            get
            {
                return item.AdtNazwa;
            }
            set
            {
                if (item.AdtNazwa != value)
                {
                    item.AdtNazwa = value;
                    OnPropertyChanged(() => AdtNazwa);
                }
            }
        }

        public bool? AdtAktywny
        {
            get
            {
                return item.AdtAktywny;
            }
            set
            {
                if (item.AdtAktywny != value)
                {
                    item.AdtAktywny = value;
                    OnPropertyChanged(() => AdtAktywny);
                }
            }
        }

    }
}
