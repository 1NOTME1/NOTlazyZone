using NOTlazyZone.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    public class TrainingPlanViewModel : WorkspaceViewModel
    {
        private DateTime _selectedDate;

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                if (_selectedDate != value)
                {
                    _selectedDate = value;
                    OnPropertyChanged(() => SelectedDate);
                }
            }
        }

        public TrainingPlanViewModel()
        {
            base.DisplayName = "Plan treningowy";
            SelectedDate = DateTime.Now;
        }
    }
}