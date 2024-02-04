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
using GalaSoft.MvvmLight.Messaging;




namespace NOTlazyZone.ViewModels
{
    public abstract class WszystkieViewModel<T> : WorkspaceViewModel
    {
        #region DB
        protected readonly NOTlazyZoneEntities notlazyzoneEntities;
        #endregion

        #region Fields
        private BaseCommand _LoadCommand;
        private BaseCommand _AddCommand;
        private BaseCommand _SortCommand;
        private BaseCommand _FindCommand;
        private ObservableCollection<T> _List;
        #endregion  Fields

        #region Properties


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


        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new BaseCommand((param) => Add());
                }
                return _AddCommand;
            }
        }

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

        public string SortFild { get; set; }
        public List<string> SortComboboxItems
        {
            get
            {
                return getComboboxSortList();
            }
        }

        public ICommand SortCommand
        {
            get
            {
                if (_SortCommand == null)
                {
                    _SortCommand = new BaseCommand((param) => sort()); 
                }
                return _SortCommand;
            }
        }

        public string FindFild { get; set; }   
        public string FindTextBox { get; set; }
        public List <string> FindComboboxItems
        {
            get
            {
                return getComboboxFindList();
            }
        }

        public ICommand FindCommand
        {
            get
            {
                if (_FindCommand == null)
                {
                    _FindCommand = new BaseCommand((param) => find());
                }
                return _FindCommand;
            }
        }



                #endregion  Properties

                #region Constructor
                public WszystkieViewModel(string displayName) : base()
        {
            base.DisplayName = displayName;
            notlazyzoneEntities = new NOTlazyZoneEntities();
        }
        #endregion  Constructor

        #region Helpers
        public abstract void sort();
        public abstract List<String> getComboboxSortList();

        public abstract void find();
        public abstract List<String> getComboboxFindList();

        public abstract void load();
        private void Add()
        {
            Messenger.Default.Send(DisplayName + " Add");
        }
        #endregion
    }
}

