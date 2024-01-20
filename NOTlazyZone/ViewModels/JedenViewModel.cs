using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NOTlazyZone.Helpers;
using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    //
    public abstract class JedenViewModel<T> : WorkspaceViewModel, IDataErrorInfo
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

        public string Error => string.Empty;

        public string this[string columnName] => ValidateProperty(columnName);
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
        public virtual void SaveAndClose()
        {
            string errors = ValidateModel();
            if (!errors.IsNullOrEmpty())
            {
                MessageBox.Show(App.Current.MainWindow, errors, "Błąd");
                return;
            }
            //zaisujemy nowy obiekt
            try
            {
                Save();
                //zamykamy zakładke
                OnRequestClose();
            }
            catch (DbUpdateException ex) 
            {
                MessageBox.Show(App.Current.MainWindow, "Wystąpił błąd podczas zapisu", "Błąd");
            }
            
        }

        protected abstract string ValidateProperty(string PropertyName);
        protected virtual string ValidateModel()
        {
            //string errors = string.Empty;
            //foreach (PropertyInfo property in GetType().GetProperties()) 
            //{
            //    errors += ValidateProperty(property.Name);
            //}
            //return errors;
            return string.Join('\n', GetType().GetProperties().Select(item => ValidateProperty(item.Name)).Where(item => !string.IsNullOrEmpty(item)));

        }



        #endregion
    }
}
