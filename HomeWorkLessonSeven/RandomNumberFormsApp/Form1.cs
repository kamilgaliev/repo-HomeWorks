using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberFormsApp
{
    //Галиев Камиль
    //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
    //а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное 
    //число введенного.
    //a) Для ввода данных от человека используется элемент TextBox;
    public partial class Form1 : Form
    {
        Random r;
        int MyNum;
        int MyCount;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            MyNum = r.Next(1,100);
            MyCount = 0;
            textBox1.AppendText($"Игра - Угадай число\r\nВведите число от 1 до 100\r\n");
        }

        private void btnCheckNum_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txtBoxForNum.Text, out num) == true && txtBoxForNum.Text != "0")
            {
                MyCount++;
                WinOrNo();
                txtBoxForNum.Text = "";
            }
            else
            {
                MessageBox.Show("Введите число!!!", "Ошибка");
            }
            
        }
        private void WinOrNo()
        {
            int n = Convert.ToInt32(txtBoxForNum.Text);
            if (n > MyNum)
                textBox1.AppendText($"Вы ввели слишком большое число: {n}\r\n");
            else if (n < MyNum)
                textBox1.AppendText($"Вы ввели слишком маленькое число: {n}\r\n");
            else if (n == MyNum)
            {
                textBox1.AppendText($"Вы угадали!\r\nКоличество попыток: {MyCount}\r\n");
                if (MessageBox.Show("Хотите начать новую игру?","Новая игра",MessageBoxButtons.OKCancel) == DialogResult.OK)
                    NewGame();
            }
        }

        private void NewGame()
        {
            textBox1.Text=$"Игра - Угадай число\r\nВведите число от 1 до 100\r\n";
            MyNum = r.Next(1, 100);
            MyCount = 0;
        }
    }
}
