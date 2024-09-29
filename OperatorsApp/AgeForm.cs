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
    public partial class AgeForm : Form
    {
        private AgeController _controller;

        public AgeForm(AgeController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void CheckAgeButton_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBoxAge.Text);
            string category = _controller.GetAgeCategory(age);
            labelCategory.Text =  category;
        }
    }
}
