using NOTlazyZone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    //klasa bedzie modifykowana po wszystkich wykladach
    class CaloriesCalculatorViewModel : WorkspaceViewModel
    {
        public CaloriesCalculatorViewModel()
        {
            base.DisplayName = "Kalkulator Kalorii";
        }
    }
}
