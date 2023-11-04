using Microsoft.EntityFrameworkCore;
using NOTlazyZone.Helpers;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    //
    public class JedenViewModel<T> : WorkspaceViewModel
    {
        #region DB
        //cała BD
        protected NOTlazyZoneEntities notlazyzoneEntities;
        //dodawany obiekt
        protected T item;
        #endregion

        #region Command
        private BaseCommand _SaveAndCloseCommand;
        //ta komenda bedzie podpieta pod przycisk Zapisz i Zamknik
        public ICommand SaveAndCloseCommand
        {
            get
            {
                if (_SaveAndCloseCommand == null)
                    _SaveAndCloseCommand = new BaseCommand(param => SaveAndClose(), canExecute: () => true);
                return _SaveAndCloseCommand;
            }
        }
        #endregion

        #region Konstruktor
        public JedenViewModel(string displayName)
        {
            base.DisplayName = displayName;
            notlazyzoneEntities = new NOTlazyZoneEntities();
        }
        #endregion

        #region Pomocniczy
        //funkcja zapisuje nowy towar do bd
        public void Save()
        {
            //dodanie do lakalnej kolekcji
            notlazyzoneEntities.Add(item);
            //zapisujemy do bazy danych
            notlazyzoneEntities.SaveChanges();

        }
        private void SaveAndClose()
        {
            //zaisujemy nowy obiekt
            Save();
            //zamykamy zakładke
            OnRequestClose();
        }
        #endregion
    }
}
