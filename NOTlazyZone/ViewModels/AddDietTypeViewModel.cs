using Microsoft.IdentityModel.Tokens;
using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    class AddDietTypeViewModel : JedenViewModel<DietaTyp>
    {
        public ObservableCollection<DietaTyp> DietaTyp { get; private set; } = new ObservableCollection<DietaTyp>();
        #region Konstruktor
        public AddDietTypeViewModel() : base("Dodaj Typ Diety")
        {
            item = new DietaTyp();
            LoadDietType();
        }
        #endregion
        private void LoadDietType()
        {
            var dietTypeFromDb = notlazyzoneEntities.DietaTyps.ToList();
            foreach (var prod in dietTypeFromDb)
            {
                DietaTyp.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(DatRodzaj):
                    return DatRodzaj.IsNullOrEmpty() ? "Nie uzupełnijłeś rodzaju diety" : string.Empty;


                default: return string.Empty;
            }
        }


        public string DatRodzaj
        {
            get
            {
                return item.DatRodzaj;
            }
            set
            {
                if (item.DatRodzaj != value)
                {
                    item.DatRodzaj = value;
                    OnPropertyChanged(() => DatRodzaj);
                }
            }
        }

    }
}
