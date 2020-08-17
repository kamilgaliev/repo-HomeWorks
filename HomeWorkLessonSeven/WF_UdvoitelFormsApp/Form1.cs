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
    //Галиев Камиль
    //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
    //Игрок должен получить это число за минимальное количество ходов.
    //в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.

    public partial class Form1 : Form
    {
        Stack<int> MyStack;
        public Form1()
        {
            InitializeComponent();
            MyStack = new Stack<int>();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelText.Text = (int.Parse(labelText.Text) + 1).ToString();
            MyStack.Push(1);
            LblCount();
            WinGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelText.Text = (int.Parse(labelText.Text) * 2).ToString();
            MyStack.Push(2);
            LblCount();
            WinGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelText.Text = "1";
            labelCount.Text = "0";
        }

        private void LblCount()
        {
            labelCount.Text = (int.Parse(labelCount.Text) + 1).ToString();
        }

        private void WinGame()
        {
            if (labelMyNum.Text == labelText.Text)
            {
                MessageBox.Show($"Вы выиграли!\nКоличество попыток: {labelCount.Text}");
                labelMyNum.Text = "1";
                labelText.Text = "1";
                MyStack = new Stack<int>();
                labelCount.Text = "0";
            }
        }
        private void RollBack()
        {
            if (MyStack.Count == 0)
                MessageBox.Show("Стек пуст!");
            else if(MyStack.Peek() == 1)
            {
                labelText.Text = (int.Parse(labelText.Text) - 1).ToString();
                labelCount.Text = (int.Parse(labelCount.Text) - 1).ToString();
                MyStack.Pop();
            }
            else if (MyStack.Peek() == 2)
            {
                labelText.Text = (int.Parse(labelText.Text) / 2).ToString();
                labelCount.Text = (int.Parse(labelCount.Text) - 1).ToString();
                MyStack.Pop();
            }
        }

        private void MenuItemGame_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            labelMyNum.Text = form2.numstr;
            MyStack = new Stack<int>();
            labelText.Text = "1";
            labelCount.Text = "0";
        }

        private void btnRollBack_Click(object sender, EventArgs e)
        {
            RollBack();
        }
    }
}
