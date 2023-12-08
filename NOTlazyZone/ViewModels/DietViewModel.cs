﻿using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    public class DietViewModel : JedenViewModel<Dietum>
    {
        public ObservableCollection<Dietum> Dieta { get; private set; } = new ObservableCollection<Dietum>();
        #region Konstruktor
        public DietViewModel() : base("Dieta")
        {
            item = new Dietum();
            LoadDiet();
        }
        #endregion
        private void LoadDiet()
        {
            var dietFromDb = notlazyzoneEntities.Dieta.ToList();
            foreach (var prod in dietFromDb)
            {
                Dieta.Add(prod);
            }
        }

        public String DaNazwa
        {
            get
            {
                return item.DaNazwa;
            }
            set
            {
                if (item.DaNazwa != value)
                {
                    item.DaNazwa = value;
                    OnPropertyChanged(() => DaNazwa);
                }
            }
        }

        public IQueryable<Uzytkownicy> DaUsComboBoxItems
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

        public IQueryable<DietaTyp> DaDatComboBoxItems
        {
            get
            {
                return
                    (
                        from DietaTyp in notlazyzoneEntities.DietaTyps
                        select DietaTyp
                    ).ToList().AsQueryable();
            }
        }

        public int DaColorie
        {
            get
            {
                return item.DaColorie;
            }
            set
            {
                if (item.DaColorie != value)
                {
                    item.DaColorie = value;
                    OnPropertyChanged(() => DaColorie);
                }
            }
        }

        public int DaIloscBialka
        {
            get
            {
                return item.DaIloscBialka;
            }
            set
            {
                if (item.DaIloscBialka != value)
                {
                    item.DaIloscBialka = value;
                    OnPropertyChanged(() => DaIloscBialka);
                }
            }
        }

        public int DaIloscWeglowodanow
        {
            get
            {
                return item.DaIloscWeglowodanow;
            }
            set
            {
                if (item.DaIloscWeglowodanow != value)
                {
                    item.DaIloscWeglowodanow = value;
                    OnPropertyChanged(() => DaIloscWeglowodanow);
                }
            }
        }

        public int DaIloscTluszczy
        {
            get
            {
                return item.DaIloscTluszczy;
            }
            set
            {
                if (item.DaIloscTluszczy != value)
                {
                    item.DaIloscTluszczy = value;
                    OnPropertyChanged(() => DaIloscTluszczy);
                }
            }
        }

        public int? DaDatId
        {
            get
            {
                return item.DaDatId;
            }
            set
            {
                if (item.DaDatId != value)
                {
                    item.DaDatId = value;
                    OnPropertyChanged(() => DaDatId);
                }
            }
        }

        public int? DaUsId
        {
            get
            {
                return item.DaUsId;
            }
            set
            {
                if (item.DaUsId != value)
                {
                    item.DaUsId = value;
                    OnPropertyChanged(() => DaUsId);
                }
            }
        }


    }
}
