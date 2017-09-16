using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathematicalProgram
{
    public partial class BiCo : Form
    {
        public BiCo()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            decimal n = numericUpDown1.Value, k = numericUpDown2.Value; 
            if(n == 0 || k == 0)
            {
                lResult.Text = "Enter data";
            }
            else if(n<k)
            {
                lResult.Text = "n < k";
            }
            else
            {
                lResult.Text = (factorial_recursion(n) / (factorial_recursion(k) * (factorial_recursion(n - k)))).ToString();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        public decimal factorial_recursion(decimal number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * factorial_recursion(number - 1);
        }
    }
}
