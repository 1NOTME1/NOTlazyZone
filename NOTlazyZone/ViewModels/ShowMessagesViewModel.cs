using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using NOTlazyZone.ViewModel;
using NOTlazyZone.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    internal class ShowMessagesViewModel : JedenViewModel<Wiadomosci>
    {
        public ObservableCollection<Wiadomosci> Wiadomosci { get; private set; } = new ObservableCollection<Wiadomosci>();
        #region Konstruktor
        public ShowMessagesViewModel() : base("Produkt")
        {
            item = new Wiadomosci();
            LoadWiadomosci();
        }
        #endregion
        private void LoadWiadomosci()
        {
            var wiadomosciFromDb = notlazyzoneEntities.Wiadomoscis.ToList();
            foreach (var prod in wiadomosciFromDb)
            {
                Wiadomosci.Add(prod);
            }
        }
        //dla kazdego elementu na interfejsie ktory bedzie dodawany tworzymy wlasciwosc


        public String WiZawartosc
        {
            get
            {
                return item.WiZawartosc;
            }
            set
            {
                if (item.WiZawartosc != value)
                {
                    item.WiZawartosc = value;
                    OnPropertyChanged(() => WiZawartosc);
                }
            }
        }

        public DateTime WiDataOtrzymania
        {
            get
            {
                return item.WiDataOtrzymania;
            }
            set
            {
                if (item.WiDataOtrzymania != value)
                {
                    item.WiDataOtrzymania = value;
                    OnPropertyChanged(() => WiDataOtrzymania);
                }
            }
        }

        public String WiDoOsoby
        {
            get
            {
                return item.WiDoOsoby;
            }
            set
            {
                if (item.WiDoOsoby != value)
                {
                    item.WiDoOsoby = value;
                    OnPropertyChanged(() => WiDoOsoby);
                }
            }
        }

        public String WiTemat
        {
            get
            {
                return item.WiTemat;
            }
            set
            {
                if (item.WiTemat != value)
                {
                    item.WiTemat = value;
                    OnPropertyChanged(() => WiTemat);
                }
            }
        }
    }
}

//    internal class ShowMessagesViewModel : WszystkieViewModel<MessagesViewModel>
//    {
//        public ShowMessagesViewModel() : base("Sklep")
//        {
//            load();
//        }

//        #region Helpers

//        public override void load()
//        {
//            List = new ObservableCollection<MessagesViewModel>
//                (
//                    //dla kazdego zamowienia z bazy zamienia
//                    from Wiadomosci in notlazyzoneEntities.Wiadomoscis
//                        //tworze nowa zamowieniaforview
//                    select new MessagesViewModel
//                    {
//                        WiDoOsoby1 = Wiadomosci.WiDoOsoby,
//                        WiZawartosc1 = Wiadomosci.WiZawartosc,
//                        WiTemat1 = Wiadomosci.WiTemat,
//                        WiDataOtrzymania1 = Wiadomosci.WiDataOtrzymania

//                    }
//                );
//        }
//        #endregion
//    }
//}
