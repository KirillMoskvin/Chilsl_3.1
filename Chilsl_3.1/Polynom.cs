using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilsl_3._1
{
    class Polynom
    {
        /// <summary>
        /// Вид полинома
        /// </summary>
        public SortedList<int, double> polynom;
        /// <summary>
        /// погрешность
        /// </summary>
        const double eps = 1E-100;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Polynom()
        {
            polynom = new SortedList<int, double>();
        }
        /// <summary>
        /// Копирование
        /// </summary>
        /// <returns>Копия данного многочлена</returns>
        public Polynom Clone()
        {
            Polynom res = new Polynom();
            foreach (var pair in polynom)
                res[pair.Key] = pair.Value;
            return res;
        }

        /// <summary>
        /// Сложение многочленов
        /// </summary>
        /// <param name="p1">Первый</param>
        /// <param name="p2">Второй</param>
        /// <returns>Сумма</returns>
        public static Polynom operator + (Polynom p1, Polynom p2)
        {
            Polynom res = new Polynom();
            if (p1.polynom.Count >= p2.polynom.Count)
            {
                res = p2;
                for (int i = 0; i < p1.polynom.Count; ++i)
                    if (p2.polynom.ContainsKey(p1.polynom.Keys[i]))
                        res[p1.polynom.Keys[i]] = p1[p1.polynom.Keys[i]] + p2[p1.polynom.Keys[i]];
                    else
                        res[p1.polynom.Keys[i]] = p1[p1.polynom.Keys[i]];
            }
            else
            {
                res = p1;
                for (int i = 0; i < p2.polynom.Count; ++i)
                    if (p1.polynom.ContainsKey(p2.polynom.Keys[i]))
                        res[p2.polynom.Keys[i]] = p2[p2.polynom.Keys[i]] + p1[p2.polynom.Keys[i]];
                    else
                        res[p2.polynom.Keys[i]] = p2[p2.polynom.Keys[i]];
            }
            return res;
        }
        /// <summary>
        /// Умножение многочленов
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Polynom operator *(Polynom p1, Polynom p2)
        {
            Polynom res = new Polynom();
            foreach (var pair1 in p1.polynom)
                foreach(var pair2 in p2.polynom)
                {
                    if (res.polynom.ContainsKey(pair1.Key + pair2.Key))
                        res[pair1.Key + pair2.Key] += pair1.Value * pair2.Value;
                    else
                        res[pair1.Key + pair2.Key] = pair1.Value * pair2.Value;
                    if (res[pair1.Key + pair2.Key] < eps)
                        res.polynom.Remove(pair1.Key + pair2.Key);
                }
            return res;
        }
        /// <summary>
        /// интегрирование многочлена
        /// </summary>
        public void Integrate()
        {
            SortedList<int, double> res=new SortedList<int, double>();
            foreach(var pair in polynom)
            {
                res[pair.Key + 1] = polynom[pair.Key] / (pair.Key+1);
            }
            polynom = res;
        }
        /// <summary>
        /// Обращение к элементам полинома по индексу
        /// </summary>
        /// <param name="i">индекс</param>
        /// <returns>Коэффициент</returns>
        public double this[int i]
        {
            get
            {
                return polynom[i];
            }
            set
            {
                polynom[i] = value;
            }
        }

        /// <summary>
        /// Конвертация в строку
        /// </summary>
        /// <returns>Многочлен в виде строки</returns>
        public override string ToString()
        {
            string res;
            int i;
            if (polynom.ContainsKey(0) && polynom[0]>eps)
            {
                res = polynom[0].ToString();
                i = 1;
                if (polynom.Count != 1)
                    res += " + ";
            }
            else
            {
                res = "";
                i = 0;
            }
            for (; i<polynom.Count; ++i)
            {
                if (polynom.Values[i] > eps)
                {
                    res += polynom.Values[i].ToString() + "x^" + polynom.Keys[i].ToString();
                    if (i < polynom.Count - 1)
                        res += " + ";
                }
            }
            return res;
        }

        /// <summary>
        /// Вычисление функции от полинома
        /// </summary>
        /// <param name="x">Значение переменной</param>
        /// <returns>Значение функции</returns>
        public double Func(double x)
        {
            double res = 0;
            foreach (var pair in polynom)
                res += Math.Pow(x, pair.Key) * pair.Value;
            return res;
        }
    }
}
