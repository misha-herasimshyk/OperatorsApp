using OperatorsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp.Controllers
{
   
    public class CalculatorController
    {
        private CalculatorModel _model;

        public CalculatorController(CalculatorModel model)
        {
            _model = model;
        }

        public double PerformCalculation(double num1, double num2, string operation)
        {
            return _model.Calculate(num1, num2, operation);
        }
    }
}