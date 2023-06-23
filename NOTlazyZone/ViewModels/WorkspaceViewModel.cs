using NOTlazyZone.ViewModels;
using NOTlazyZone.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NOTlazyZone.ViewModel
{
    //to jest view model do  odzieczenia prez view modele reprezentujace zakladki
    //kazda zaklada bedzie dziedizzyla po workspaceviewmodel
    public class WorkspaceViewModel : BaseViewModel
    {
        #region Pola i właściwosci
        public string DisplayName { get; set; }//to jest nazwa zakładki
        private BaseCommand _CloseCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                    _CloseCommand = new BaseCommand(_ => OnRequestClose());//komenada...
                return _CloseCommand;
            }
        }
        #endregion
        #region RequestClose [event]
        public event EventHandler RequestClose;
        private void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        #endregion

    }
}
