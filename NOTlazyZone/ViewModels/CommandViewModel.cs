using System.Windows;
using System.Windows.Input;

namespace NOTlazyZone.ViewModels
{
    public class CommandViewModel : BaseViewModel
    {
        #region Properties
        public string DisplayName { get; set; }
        public ICommand Command { get; set; }
        public string Icon { get; set; }
        #endregion

        #region Konstructor
        public CommandViewModel(string displayName, ICommand command, string icon)
        {
            DisplayName = displayName;
            Command = command;
            Icon = icon;
        }
        #endregion
    }
}
