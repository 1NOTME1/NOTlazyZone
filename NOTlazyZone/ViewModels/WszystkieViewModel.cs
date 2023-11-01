using NOTlazyZone.Helpers;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    //kalsa abstrakcyjna bo ma metode abstakcyjna
    public abstract class WszystkieViewModel<T> : WorkspaceViewModel
    {
        #region DB
        protected readonly NOTlazyZoneEntities notlazyzoneEntities;
        #endregion

        #region Command
        private BaseCommand _LoadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand((param) => load());

                }
                return _LoadCommand;
            }
        }
        #endregion
        #region Kolekcja
        private ObservableCollection<T> _List;
        public ObservableCollection<T> List
        {
            get
            {
                if (_List == null)
                {
                    load();
                }
                return _List;
            }
            set
            {
                _List = value;
                OnPropertyChanged(() => List);
            }
        }
        #endregion

        #region Konstruktor
        public WszystkieViewModel(string displayName)
        {
            base.DisplayName = displayName;
            notlazyzoneEntities = new NOTlazyZoneEntities();

        }
        #endregion

        #region Helpers
        //Ta metoda jest abstract bo nie wiemy jak ja napisac w klasie wszystkieViewModel a wiemu dopiero w klasach dziedziczacych
        public abstract void load();
        #endregion


    }
}

