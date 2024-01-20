using Microsoft.IdentityModel.Tokens;
using NOTlazyZone.Helpers;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    class AddShopViewModel:JedenViewModel<Produkty>
    {


        public ObservableCollection<Produkty> Produkty { get; private set; } = new ObservableCollection<Produkty>();
        #region Konstruktor
        public AddShopViewModel() : base("Produkt")
        {
            item = new Produkty();
            LoadProducts();
        }
        #endregion
        private void LoadProducts()
        {
            var produktyFromDb = notlazyzoneEntities.Produkties.ToList();
            foreach (var prod in produktyFromDb)
            {
                Produkty.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(PrNazwa):
                    return PrNazwa.IsNullOrEmpty() ? "Wypełnij pole Nazwa Produktu" : string.Empty;

                case nameof(PrCena):
                    return PrCena == 0 ? "Wypełnij pole Cena produktu" : string.Empty;

                default: return string.Empty;
            }
        }

        //protected override string ValidateModel()
        //{
        //    string errors = string.Empty;
        //    errors += ValidateProperty(nameof(PrNazwa));
        //    errors += ValidateProperty(nameof(PrCena));

        //    return errors;
        //}


        #region Dane
        //dla kazdego elementu na interfejsie ktory bedzie dodawany tworzymy wlasciwosc


        public String PrNazwa
        {
            get
            {
                return item.PrNazwa;
            }
            set
            {
                if (item.PrNazwa != value)
                {
                    item.PrNazwa = value;
                    OnPropertyChanged(() => PrNazwa);
                }
            }
        }

        public decimal PrCena
        {
            get
            {
                return item.PrCena;
            }
            set
            {
                if (item.PrCena != value)
                {
                    item.PrCena = value;
                    OnPropertyChanged(() => PrCena);
                }
            }
        }

        #endregion

        
    }
}
