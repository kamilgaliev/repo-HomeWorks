using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_UdvoitelFormsApp
{
    public partial class Form2 : Form
    {
        public string numstr;
        public Form2()
        {
            InitializeComponent();
            numstr = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(textBoxNumber.Text,out num)==true && textBoxNumber.Text!="0")
            {
                numstr = textBoxNumber.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("Введите число!!!","Ошибка");
            }
        }
    }
}
