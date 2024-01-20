using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    class AddExerciseTypeViewModel : JedenViewModel<CwiczeniaTyp>
    {
        public ObservableCollection<CwiczeniaTyp> ExerciseType { get; private set; } = new ObservableCollection<CwiczeniaTyp>();
        #region Konstruktor
        public AddExerciseTypeViewModel() : base("Dodaj Nowy Typ Ćwiczenia")
        {
            item = new CwiczeniaTyp();
            LoadExerciseType();
        }
        #endregion
        private void LoadExerciseType()
        {
            var exerciseTypeFromDb = notlazyzoneEntities.CwiczeniaTyps.ToList();
            foreach (var prod in exerciseTypeFromDb)
            {
                ExerciseType.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(CwtNazwa):
                    return string.IsNullOrEmpty(CwtNazwa) ? "Wypełnij pole nazwa" : string.Empty;


                default: return string.Empty;
            }
        }

        public string? CwtNazwa
        {
            get
            {
                return item.CwtNazwa;
            }
            set
            {
                if (item.CwtNazwa != value)
                {
                    item.CwtNazwa = value;
                    OnPropertyChanged(() => CwtNazwa);
                }
            }
        }

    }
}
