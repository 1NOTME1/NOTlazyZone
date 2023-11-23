using NOTlazyZone.ViewModels;
using NOTlazyZone.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using NOTlazyZone.ViewModel;
using NOTlazyZone.Views;

namespace NOTlazyZone.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region CommandsMenu
        public ICommand MessageCommand
        {
            get
            {
                return new BaseCommand(_ => CreateMessage());

            }
        }
        #endregion

        #region CommandsStatistic
        public ICommand StatisticCommand
        { 
            get
            {
                return new BaseCommand(_ => ShowStatistic());

            }
        }
        #endregion

        #region CommandsExercise
        public ICommand ExerciseCommand
        {
            get
            {
                return new BaseCommand(_ => ShowExercies());
            }
        }
        #endregion

        #region CommandsDiet
        public ICommand DietCommand
        {
            get
            {
                return new BaseCommand(_ => ShowDiet());
            }
        }
        #endregion

        #region CommandsCalendar
        public ICommand CalendarCommand
        {
            get
            {
                return new BaseCommand(_ => ShowCalendar());
            }
        }
        #endregion

        #region CommandsShowCaloriesCalculator
        public ICommand CalculatorCalorieCommand
        {
            get
            {
                return new BaseCommand(_ => ShowCaloriesCalculator());
            }
        }
        #endregion

        #region CommandsContactList
        public ICommand ContactListCommand
        {
            get
            {
                return new BaseCommand(_ => ShowContactList());
            }
        }
        #endregion

        #region CommandsShop
        public ICommand ShopCommand
        {
            get
            {
                return new BaseCommand(_ => ShowShop());
            }
        }
        #endregion

        #region CommandsSettings
        public ICommand SettingsCommand
        {
            get
            {
                return new BaseCommand(_ => ShowSettings());
            }
        }
        #endregion


        #region Commands
        private ReadOnlyCollection<CommandViewModel> _Commands;
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    List<CommandViewModel> cmds = CreateCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }
        private List<CommandViewModel> CreateCommands()
        {
            return new List<CommandViewModel>
    {
        new CommandViewModel("Statystyki", new BaseCommand(_ => ShowStatistic()), "icons/chart.png"),
        new CommandViewModel("Dodaj Ćwiczenia", new BaseCommand(_ => ShowExercies()), "icons/barbell.png"),
        new CommandViewModel("Kreator Diety", new BaseCommand(_ => ShowDiet()), "icons/diet.png"),
        new CommandViewModel("Wiadomości / Poczta", new BaseCommand(_ => CreateMessage()), "icons/email.png"),
        new CommandViewModel("Kalendarz Treningowy", new BaseCommand(_ => ShowCalendar()), "icons/calendar_1.png"),
        new CommandViewModel("Kalkulator Kalorii", new BaseCommand(_ => ShowCaloriesCalculator()), "icons/kcal.png"),
        new CommandViewModel("Lista Kontaktów", new BaseCommand(_ => ShowContactList()), "icons/contact_list.png"),
        new CommandViewModel("Sklep", new BaseCommand(_ => ShowShop()), "icons/shopping_cart.png"),
        new CommandViewModel("Ustawienia", new BaseCommand(_ => ShowSettings()), "icons/settings.png"),
    };
        }


        #endregion
        #region Workspaces
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.onWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        #endregion


        #region Zakładki
        private void onWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.onWorkspaceRequestClose;

            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.onWorkspaceRequestClose;
        }
        private void onWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }
        #endregion

        #region Funkcje wywolu.....
        private void CreateMessage()
        {
            MessagesViewModel workspace = new MessagesViewModel();
            Workspaces.Add(workspace);
            SetActiveWorkspace(workspace);
        }
        private void ShowStatistic()
        {
            StatisticViewModel workspace = Workspaces.FirstOrDefault(vm => vm is StatisticViewModel) as StatisticViewModel;
            if (workspace == null)
            {
                workspace = new StatisticViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }
        private void ShowCalendar()
        {
            TrainingPlanViewModel workspace = Workspaces.FirstOrDefault(vm => vm is TrainingPlanViewModel) as TrainingPlanViewModel;
            if (workspace == null)
            {
                workspace = new TrainingPlanViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }
        private void ShowExercies()
        {
            ExerciseViewModel workspace = Workspaces.FirstOrDefault(vm => vm is ExerciseViewModel) as ExerciseViewModel;
            if (workspace == null)
            {
                workspace = new ExerciseViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }

        private void ShowCaloriesCalculator()
        {
            CaloriesCalculatorViewModel workspace = Workspaces.FirstOrDefault(vm => vm is CaloriesCalculatorViewModel) as CaloriesCalculatorViewModel;
            if (workspace == null)
            {
                workspace = new CaloriesCalculatorViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }

        private void ShowSettings()
        {
            SettingViewModel workspace = Workspaces.FirstOrDefault(vm => vm is SettingViewModel) as SettingViewModel;
            if (workspace == null)
            {
                workspace = new SettingViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }

        private void ShowContactList()
        {
            ListContactViewModel workspace = Workspaces.FirstOrDefault(vm => vm is ListContactViewModel) as ListContactViewModel;
            if (workspace == null)
            {
                workspace = new ListContactViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }

        private void ShowDiet()
        {
            DietViewModel workspace = Workspaces.FirstOrDefault(vm => vm is DietViewModel) as DietViewModel;
            if (workspace == null)
            {
                workspace = new DietViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }

        private void ShowShop()
        {
            ShopViewModel workspace = Workspaces.FirstOrDefault(vm => vm is ShopViewModel) as ShopViewModel;
            if (workspace == null)
            {
                workspace = new ShopViewModel();
                Workspaces.Add(workspace);
            }
            SetActiveWorkspace(workspace);
        }

        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }

        #endregion




    }
}
