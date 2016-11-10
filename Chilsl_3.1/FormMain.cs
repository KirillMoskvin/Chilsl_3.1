using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chilsl_3._1
{
    public partial class Form_main : Form
    {
        Polynom p;
        double a, b, x0, y0, eps, n;
        public Form_main()
        {
            InitializeComponent();
            p = new Polynom();
            p[1] = 2;
            p[0] = 11;
            p[2] = 13;
            p[4] = 8;
            Polynom p2 = new Polynom();
            p2[2] = 213;
            p2[0] = 11;
            p2[12] = 113;
            p2[700] = 123;
            //MessageBox.Show(p.ToString()+Environment.NewLine+ p2.ToString()+Environment.NewLine+(p+p2).ToString());
          //  MessageBox.Show(p.ToString());
         //   p.Integrate();
          //  MessageBox.Show(p.ToString());
        }

        /// <summary>
        /// Валидация элементов.  Здесь код не очень.
        /// </summary>
        /// <returns>true, если все введено корректно</returns>
        bool Validation()
        {
            string ErrorMessage = "";
            bool res = true;

            ///Проверка значения х0
            if (!double.TryParse(tb_x0.Text, out x0))
            {
                res = false;
                ErrorMessage += "Введено неверное значение x0"+Environment.NewLine;
            }
            //Проверка значения у0
            if (!double.TryParse(tb_y0.Text, out y0))
            {
                res = false;
                ErrorMessage += "Введено неверное значение y0" + Environment.NewLine;
            }
            ///Проверка значения a
            if (!double.TryParse(tb_a.Text, out a))
            {
                res = false;
                ErrorMessage += "Введено неверное значение a" + Environment.NewLine;
            }
            else
                if (a <= 0)
                {
                    res = false;
                    ErrorMessage += "a должен быть положительным!" + Environment.NewLine;
                }
            ///Проверка значения a
            if (!double.TryParse(tb_b.Text, out b))
            {
                res = false;
                ErrorMessage += "Введено неверное значение b" + Environment.NewLine;
            }
            else
                if (b <= 0)
                {
                    res = false;
                    ErrorMessage += "b должен быть положительным!" + Environment.NewLine;
                }
            ///Проверка значения eps
            if (!double.TryParse(tb_eps.Text, out eps))
            {
                res = false;
                ErrorMessage += "Введено неверное значение eps" + Environment.NewLine;
            }
            else
                if (eps <= 0)
            {
                res = false;
                ErrorMessage += "eps должен быть положительным!" + Environment.NewLine;
            }





            if (!res)
                MessageBox.Show(ErrorMessage);
            return res;
        }


        long Factorial(int n)
        {
            int res = 1;
            for (int i = 2; i <= n; ++i)
                res *= i;
            return res;
        }

        /// <summary>
        /// Подсчет количества шагов, исходя из погрешности
        /// </summary>
        /// <returns>Количество шагов</returns>
        int CountSteps()
        {
            double M = a * a + b * b;
            double N = 2 * b;
            double h = Math.Min(a, b/M);
            int n = 1;
            while ((Math.Pow(N, n) * M * Math.Pow(h, n + 1) / Factorial(n + 1))>=eps)
                ++n;
            return n;
        }

        Polynom Solve(int steps)
        {
            Polynom polPrev = new Polynom();
            polPrev[0] = y0 * y0;
            polPrev[2] = 1;
            polPrev.Integrate();
            polPrev[0] = polPrev.Func(x0);

            for (int i=2; i<=steps; ++i)
            {
                Polynom polTmp = new Polynom();
                polTmp[2] = 1;
                polTmp = polTmp + polPrev * polPrev;
                polTmp.Integrate();
                polTmp[0] = -polTmp.Func(x0) + y0;
                polPrev = polTmp;
            }
            return polPrev;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_solve_Click(object sender, EventArgs e)
        {
            tb_output.Clear();
            if (Validation())
            {
                int steps = CountSteps();
                tb_output.Text += "Произведено шагов: " + steps.ToString()+Environment.NewLine;
                Polynom result = Solve(steps);
                tb_output.Text += "Многочлен, поученный на " + steps.ToString() + "-м шаге:" + Environment.NewLine + result.ToString() + Environment.NewLine;
                tb_output.Text += "Приближенный результат вычисления: " + result.Func(x0).ToString();
            }

            
        }

        private void tb_eps_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
