using OperatorsApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorsApp
{
    public partial class CalculatorForm : Form
    {
        private CalculatorController _controller;

        public CalculatorForm(CalculatorController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) || string.IsNullOrWhiteSpace(textBoxNum2.Text))
            {
                MessageBox.Show("Будь ласка, введіть обидва числа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            double num1 = Convert.ToDouble(textBoxNum1.Text);
            double num2 = Convert.ToDouble(textBoxNum2.Text);

           
            if (comboBoxOperation.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть операцію.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string operation = comboBoxOperation.SelectedItem.ToString();

       
            double result = _controller.PerformCalculation(num1, num2, operation);
            labelResult.Text =  result.ToString();
        }
    }
}
