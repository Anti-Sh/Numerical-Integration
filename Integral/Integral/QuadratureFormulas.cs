using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    public class QuadratureFormulas
    {
        int type;  // Номер уравнения
        int n; // Число разбиений
        double a, b;  // Левая и правая границы
        double h; // Шаг разбиения
        double[] exListX = { 1.1, 1.4, 1.7, 2.1, 2.3, 2.7, 3.5, 4}; // Список X из 3 задания
        double[] exListY = { 0.6, 0.8, 0.9, 1.5, 1.8, 1.2, 0.5, 0.8}; // Список Y из 3 задания
        double[] exectValues = { 1.5707963267948966, 1.28539816339745, 0};  // Точные значения интегралов 
        public QuadratureFormulas(int typeEntered, int nEntered, double aEntered, double bEntered)
        {
            type = typeEntered;
            n = nEntered;
            a = aEntered;
            b = bEntered;
            h = (b - a) / n;
        }
        private double[] FillMassive() // Создание массива используемых значений X
        {
            double[] result = new double[n + 1];
            result[0] = a;
            for (int i = 1; i < n + 1; i++)
            {
                result[i] = result[i - 1] + h;
            }
            return result;
        }
        public double[] FillArrInFuncs() // Возврат соответствующего типу массива значений Х
        {
            if(type != 2)
            {
                return FillMassive();
            }
            else
            {
                return exListX;
            }
        }
        double F(double x) // Значение функции в точке X
        {
            double y = 0;
            switch (type)
            {
                case 0:
                    y = 1 / (5 - 3 * Math.Cos(x));
                    break;
                case 1:
                    y = 1 / Math.Pow((1 + Math.Pow(x, 2)), 2);
                    break;
                case 2:
                    int index = Array.IndexOf(exListX, x);
                    y = exListY[index];
                    break;
                default:
                    break;
            }
            return y;
        }
        public double LeftRect(double[] arr) // Метод левого прямоугольника
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x = arr[i];
                sum += F(x) * h; 
            }
            return sum;
        }
        public double RightRect(double[] arr) // Метод правого прямоугольника
        {
            double sum = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                double x = arr[i];
                sum += F(x) * h;
            }
            return sum;
        }
        public double MiddleRect(double[] arr) // Метод среднего прямоугольника
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x1 = arr[i];
                double x2 = arr[i+1];
                double x = (x1 + x2) / 2;
                sum += F(x) * h;
            }
            return sum;
        }
        public double Trapeze(double[] arr) // Метод Трапеций
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x1 = arr[i];
                double x2 = arr[i + 1];
                sum += (F(x1) + F(x2)) / 2 * h;
            }
            return sum;
        }
        public double Parabola(double[] arr) // Метод Симпсона
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x1 = arr[i];
                double x3 = arr[i + 1];
                double x2 = arr[i]+(x3-x1)/2;
                sum += h / 6 * (F(x1) + 4 * F(x2) + F(x3));
            }
            return sum;
        }
        public double NewtonCotes(double[] arr, int nk=3) // ФОрмулы Ньютона-Котеса высших порядков
        {
            double sum = 0;
            switch (nk) //nk порядок формулы
            {
                case 3:
                    for (int i = 0; i < n; i++)
                    {
                        double x1 = arr[i]; // local A
                        double x4 = arr[i + 1]; // local B
                        double x2 = (2 * x1 + x4) / 3;
                        double x3 = (x1 + 2 * x4) / 3;
                        sum += h / 8 * (F(x1) + 3 * F(x2) + 3 * F(x3) + F(x4));
                    }
                    break;
                case 4:
                    for (int i = 0; i < n; i++)
                    {
                        double x1 = arr[i]; // local A
                        double x5 = arr[i + 1]; // local B
                        double x2 = x1 + (x1 + x5) / 4;
                        double x3 = x2 + (x1 + x5) / 4;
                        double x4 = x3 + (x1 + x5) / 4;
                        sum += h / 90 * (7 * F(x1) + 32 * F(x2) + 12 * F(x3) + 32 * F(x4) + 7 * F(x5));
                    }
                    break;
            }
            return sum;
        }
        public double GetDiscrepancy(double ans) // Вычисление невязок
        {
            if (type != 2)
            {
                return Math.Abs(exectValues[type]-ans);
            }
            else
            {
                return 0;
            }
        }
    }
}
