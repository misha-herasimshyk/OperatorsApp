using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp.Models
{
    public class AgeModel
    {
        public string CheckAgeCategory(int age)
        {
            if (age <= 12)
                return "Дитина";
            else if (age <= 17)
                return "Підліток";
            else if (age <= 120)
                return "Дорослий";
            else
                return "Ви безсмертний?";
        }
    }
}
