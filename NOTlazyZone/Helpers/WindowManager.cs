using NOTlazyZone.ViewModel;
using System.Windows.Controls;
using System.Windows;

namespace NOTlazyZone.Helpers
{
    public static class WindowManager
    {
        public static void OpenModalWindow(WorkspaceViewModel viewModel, UserControl view)
        {
            Window window = new Window
            {
                Title = viewModel.DisplayName,
                Content = view,
                Owner = Application.Current.MainWindow
            };

            viewModel.RequestClose += (s, e) => window.Close();
            window.ShowDialog();
        }
    }
}
