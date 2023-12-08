using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class AddMailViewModel : JedenViewModel<Mail>
    {
        public ObservableCollection<Mail> Mail { get; private set; } = new ObservableCollection<Mail>();
        #region Konstruktor
        public AddMailViewModel() : base("Dodaj Mail")
        {
            item = new Mail();
            LoadMail();
        }
        #endregion
        private void LoadMail()
        {
            var mailFromDb = notlazyzoneEntities.Mail.ToList();
            foreach (var prod in mailFromDb)
            {
                Mail.Add(prod);
            }
        }

        public IQueryable<Uzytkownicy> MaUsComboBoxItems
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

        public int? MaUsId
        {
            get
            {
                return item.MaUsId;
            }
            set
            {
                if (item.MaUsId != value)
                {
                    item.MaUsId = value;
                    OnPropertyChanged(() => MaUsId);
                }
            }
        }



        public String MaNazwa
        {
            get
            {
                return item.MaNazwa;
            }
            set
            {
                if (item.MaNazwa != value)
                {
                    item.MaNazwa = value;
                    OnPropertyChanged(() => MaNazwa);
                }
            }
        }

        public String? MaOpis
        {
            get
            {
                return item.MaOpis;
            }
            set
            {
                if (item.MaOpis != value)
                {
                    item.MaOpis = value;
                    OnPropertyChanged(() => MaOpis);
                }
            }
        }

        public String? MaUwagi
        {
            get
            {
                return item.MaUwagi;
            }
            set
            {
                if (item.MaUwagi != value)
                {
                    item.MaUwagi = value;
                    OnPropertyChanged(() => MaUwagi);
                }
            }
        }

        public bool MaAktywny
        {
            get
            {
                return item.MaAktywny;
            }
            set
            {
                if (item.MaAktywny != value)
                {
                    item.MaAktywny = value;
                    OnPropertyChanged(() => MaAktywny);
                }
            }
        }

    }
}
