using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondHomeWorkApp
{
    //Галиев Камиль
    //Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(numericUpDown1.Value);
        }
    }
}
