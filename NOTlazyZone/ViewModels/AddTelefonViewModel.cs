using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class AddTelefonViewModel : JedenViewModel<Telefon>
    {
        public ObservableCollection<Telefon> Telefon { get; private set; } = new ObservableCollection<Telefon>();
    #region Konstruktor
    public AddTelefonViewModel() : base("Uzytkownik")
    {
        item = new Telefon();
        LoadPhone();
    }
    #endregion
    private void LoadPhone()
    {
        var phoneFromDb = notlazyzoneEntities.Telefons.ToList();
        foreach (var prod in phoneFromDb)
        {
            Telefon.Add(prod);
        }
    }
        #region Dane

        public String TnNumer
        {
            get
            {
                return item.TnNumer;
            }
            set
            {
                if (item.TnNumer != value)
                {
                    item.TnNumer = value;
                    OnPropertyChanged(() => TnNumer);
                }
            }
        }

        public String? TnOpis
        {
            get
            {
                return item.AdOpis;
            }
            set
            {
                if (item.AdOpis != value)
                {
                    item.AdOpis = value;
                    OnPropertyChanged(() => TnOpis);
                }
            }
        }

        public String? TnUwagi
        {
            get
            {
                return item.AdUwagi;
            }
            set
            {
                if (item.AdUwagi != value)
                {
                    item.AdUwagi = value;
                    OnPropertyChanged(() => TnUwagi);
                }
            }
        }

        public bool TnAktywny
        {
            get
            {
                return item.AdAktywny;
            }
            set
            {
                if (item.AdAktywny != value)
                {
                    item.AdAktywny = value;
                    OnPropertyChanged(() => TnAktywny);
                }
            }
        }

        public IQueryable<Uzytkownicy> TnUsComboBoxItems
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

        public int? TnUsId
        {
            get
            {
                return item.TnUsId;
            }
            set
            {
                if (item.TnUsId != value)
                {
                    item.TnUsId = value;
                    OnPropertyChanged(() => TnUsId);
                }
            }
        }


        #endregion
    }
}
