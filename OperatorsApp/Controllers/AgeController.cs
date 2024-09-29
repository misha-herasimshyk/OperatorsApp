using OperatorsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp.Controllers
{
    public class AgeController
    {
        private AgeModel _model;

        public AgeController(AgeModel model)
        {
            _model = model;
        }

        public string GetAgeCategory(int age)
        {
            return _model.CheckAgeCategory(age);
        }
    }
}