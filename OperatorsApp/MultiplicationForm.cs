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
    public partial class MultiplicationForm : Form
    {
        public MultiplicationForm()
        {
            InitializeComponent();
        }

        private void GenerateTableButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxNumber.Text);
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{number} x {i} = {number * i}");
            }

            textBoxResult.Text = sb.ToString();
        }
    }
}
