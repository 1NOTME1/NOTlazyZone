using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using NOTlazyZone.Models.EntitiesForView;
using NOTlazyZone.ViewModel;
using NOTlazyZone.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace NOTlazyZone.ViewModels
{
    class TrainingPlanViewModel : WszystkieViewModel<CwiczeniaForView>
    {
        public TrainingPlanViewModel() : base("PlanTreningowy")
        {
            load();
        }

        #region Helpers

        public override void load()
        {
            List = new ObservableCollection<CwiczeniaForView>
                (
                    //dla kazdego zamowienia z bazy zamienia
                    from Cwiczenium in notlazyzoneEntities.Cwiczenia
                        //tworze nowa zamowieniaforview
                    select new CwiczeniaForView
                    {
                        IdPlanu = Cwiczenium.CwPtId,
                        IdCwiczenia = Cwiczenium.CwId,
                        nazwaCwiczenia = Cwiczenium.CwNazwa,
                        seriaCwiczenia = Cwiczenium.CwSeria,
                        typCwiczenia = Cwiczenium.CwCwt.CwtNazwa,
                        ciezarCwiczenia = Cwiczenium.CwCiezar,
                        przerwaCwiczenia = Cwiczenium.CwPrzerwa,
                        trudnoscCwiczenia = Cwiczenium.CwTrudnosc,
                        nazwaUzytkownika = Cwiczenium.CwUs.UsImie + " "
                        + Cwiczenium.CwUs.UsNazwisko

                    }
                );
        }
        #endregion
    }
}