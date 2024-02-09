using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.BusinessLogic;
using System;
using System.Windows.Input;
using NOTlazyZone.ViewModel;
using System.Collections.ObjectModel;

namespace NOTlazyZone.ViewModels
{
    class CaloriesCalculatorViewModel : WorkspaceViewModel
    {
        protected readonly NOTlazyZoneEntities nOTlazyZoneEntities;
        private double weight;
        private double height;
        private double bmi;
        private readonly BMIReader bmiReader;
        private string dietInfo;
        public ObservableCollection<string> DietTypes { get; set; }

        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChanged(() => Weight);
                CalculateBMI();

            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged(() => Height);
                CalculateBMI();
            }
        }

        public double BMI
        {
            get { return bmi; }
            private set
            {
                bmi = value;
                OnPropertyChanged(() => BMI);
            }
        }

        public string DietInfo
        {
            get { return dietInfo; }
            set
            {
                dietInfo = value;
                OnPropertyChanged(() => DietInfo);
            }
        }

        public CaloriesCalculatorViewModel()
        {
            base.DisplayName = "Kalkulator Kalorii";
            nOTlazyZoneEntities = new NOTlazyZoneEntities();
            bmiReader = new BMIReader(nOTlazyZoneEntities);
            LoadDietTypes();
        }

        private void LoadDietTypes()
        {
            var types = bmiReader.GetAllDietTypes();
            DietTypes = new ObservableCollection<string>(types);
        }

        private void CalculateBMI()
        {
            if (Height > 0 && Weight > 0)
            {
                double heightInMeters = Height / 100;
                BMI = Weight / (heightInMeters * heightInMeters);
                ShowDietInfoBasedOnBMI(BMI);
            }
        }

        private void ShowDietInfoBasedOnBMI(double bmi)
        {
            var dietInfo = bmiReader.GetDietInfoBasedOnBMI(bmi);
            DietInfo = $"Propozycje dań: {dietInfo.DietName}";
        }
    }
}
