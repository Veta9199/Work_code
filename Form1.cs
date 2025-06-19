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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputA = textBox1.Text.Trim();
            string inputB = textBox2.Text.Trim();
            string inputC = textBox3.Text.Trim();

            lblResult.Text = ""; // очистка результата

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(inputA) || string.IsNullOrEmpty(inputB) || string.IsNullOrEmpty(inputC))
            {
                lblResult.Text = "Внимания! Все три поля должны быть заполнены.";
                return;
            }

            try
            {
                int a = Convert.ToInt32(inputA);
                int b = Convert.ToInt32(inputB);
                int c = Convert.ToInt32(inputC);

                // Проверка на положительность сторон
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    lblResult.Text = "Ошибка! Стороны треугольника должны быть положительными.";
                    return;
                }

                // Проверка существования треугольника
                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && b == c)
                    {
                        lblResult.Text = "Треугольник равносторонний.";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        lblResult.Text = "Треугольник равнобедренный.";
                    }
                    else
                    {
                        lblResult.Text = "Треугольник разносторонний.";
                    }
                }
                else
                {
                    lblResult.Text = "Внимания! Треугольник с такими сторонами не существует.";
                }
            }
            catch (FormatException)
            {
                lblResult.Text = "Внимания! Введите корректные целые числа.";
            }
        }
    }
}
