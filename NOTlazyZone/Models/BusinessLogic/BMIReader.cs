using NOTlazyZone.Models.Context;
using NOTlazyZone.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTlazyZone.Models.BusinessLogic
{
    public class BMIReader : DatabaseClass
    {
        public BMIReader(NOTlazyZoneEntities nOTlazyZoneEntities)
            : base(nOTlazyZoneEntities)
        {
        }

        public List<string> GetAllDietTypes()
        {
            var dietTypes = nOTlazyZoneEntities.DietaTyps
                                .Select(dt => dt.DatRodzaj)
                                .ToList();

            return dietTypes;
        }

        public string GetRandomDietNamesBasedOnBMI(double bmi)
        {
            var dietTypeId = GetDietIdBasedOnBMI(bmi);
            var diets = (from d in nOTlazyZoneEntities.Dieta
                         join dt in nOTlazyZoneEntities.DietaTyps on d.DaDatId equals dt.DatId
                         where dt.DatId == dietTypeId
                         orderby Guid.NewGuid()
                         select new {d.DaNazwa })
                         .Take(6)
                         .ToList();

            if (!diets.Any())
            {
                return "Nie znaleziono odpowiedniej diety";
            }

            var dietNames = diets.Select(diet => $"{diet.DaNazwa}").ToList();
            return string.Join("; ", dietNames);
        }


        public int GetDietIdBasedOnBMI(double bmi)
        {
            if (bmi < 18.5)
            {
                return 14; // dla niedowagi
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return 8; //  dla wagi w normie
            }
            else
            {
                return 2; // dla nadwagi
            }
        }


        public (int DietId, string DietName) GetDietInfoBasedOnBMI(double bmi)
        {
            int dietId = GetDietIdBasedOnBMI(bmi);
            string dietName = GetRandomDietNamesBasedOnBMI(bmi);
            return (dietId, dietName);
        }
    }
}
