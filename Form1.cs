using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class лаб1 : Form
    {
        public лаб1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);


                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && b == c)
                    {
                        label2.Text = "Что-то получилось, а именно = полученный треугольник - равносторонний";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        label2.Text = "Что-то получилось, а именно = полученный треугольник - равнобедренный";
                    }
                    else
                    {
                        label2.Text = "Что-то получилось, а именно = полученный треугольник - разносторонний";
                    }
                }
                else
                {
                    label2.Text = "Ошибка! Треугольник с такими сторонами не существует.";
                }
            }
            catch (FormatException)
            {
                label2.Text = "Ошибка! Введите корректные числовые значения.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}