using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.ViewModels
{
    class AddUserRoleViewModel : JedenViewModel<RolaUzytkownika>
    {
        public ObservableCollection<RolaUzytkownika> Rola { get; private set; } = new ObservableCollection<RolaUzytkownika>();
        #region Konstruktor
        public AddUserRoleViewModel() : base("Dodaj Typ Adresu")
        {
            item = new RolaUzytkownika();
            LoadRoleTyp();
        }
        #endregion
        private void LoadRoleTyp()
        {
            var RoleTypFromDb = notlazyzoneEntities.RolaUzytkownikas.ToList();
            foreach (var prod in RoleTypFromDb)
            {
                Rola.Add(prod);
            }
        }

        protected override string ValidateProperty(string PropertyName)
        {
            switch (PropertyName)
            {
                case nameof(RoRoleName):
                    return string.IsNullOrEmpty(RoRoleName) ? "Wypełnij pole Rola" : string.Empty;

                default:
                    return string.Empty;
            }

        }

        public string RoRoleName
        {
            get
            {
                return item.RoRoleName;
            }
            set
            {
                if (item.RoRoleName != value)
                {
                    item.RoRoleName = value;
                    OnPropertyChanged(() => RoRoleName);
                }
            }
        }
    }
}
