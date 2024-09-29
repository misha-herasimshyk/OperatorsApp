using OperatorsApp.Controllers;
using OperatorsApp.Models;

namespace OperatorsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenCalculatorButton_Click(object sender, EventArgs e)
        {
            CalculatorModel calculatorModel = new CalculatorModel();
            CalculatorController calculatorController = new CalculatorController(calculatorModel);
            CalculatorForm calculatorForm = new CalculatorForm(calculatorController);
            calculatorForm.Show();
        }

        private void OpenAgeButton_Click(object sender, EventArgs e)
        {
            AgeModel ageModel = new AgeModel();
            AgeController ageController = new AgeController(ageModel);
            AgeForm ageForm = new AgeForm(ageController);
            ageForm.Show();
        }

        private void OpenMultiplicationButton_Click(object sender, EventArgs e)
        {
            MultiplicationForm multiplicationForm = new MultiplicationForm();
            multiplicationForm.Show();
        }

        private void OpenCalculatorButton_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}