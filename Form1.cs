using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightCalculator
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            double weight, height, age, koef, idealweight;

            height = Convert.ToDouble(Height.Text);
            
            if (less15.Checked == true)
            {
                koef = 0.9;
            }

            if (ot15do17.Checked == true)
            {
                koef = 1.0;
            }

            if (More17.Checked == true)
            {
                koef = 1.1;
            }

            if (height < 155)
            {
                idealweight = (height - 95) * koef;
            }

            if (height < 155)
            {
                idealweight = (height - 95) * koef;
            }

            if (height < 155)
            {
                idealweight = (height - 95) * koef;
            }
        }
    }
}
