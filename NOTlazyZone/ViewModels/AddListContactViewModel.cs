using Microsoft.EntityFrameworkCore;
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
        //public ObservableCollection<Kontakty> Kontakty { get; private set; } = new ObservableCollection<Kontakty>();

        public AddListContactViewModel() : base("Dodaj Kontakt")
        {
            item = new Kontakty();
         
        }

        #region Dane
        //dla kazdego elementu na interfejsie ktory bedzie dodawany tworzymy wlasciwosc

        public int KoUsId
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

        public List<RolaUzytkownika> RoleComboBoxItems
        {
            get
            {
                return notlazyzoneEntities.RolaUzytkownikas.ToList();
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(KoUsId):
                    return KoUsId == 0 ? "Dodaj uzytkownika do kontaktow" : string.Empty;

                default: return string.Empty;
            }
        }






        #endregion

    }
}
