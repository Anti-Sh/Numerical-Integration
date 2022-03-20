using System;

namespace Integral2
{
    internal class Integral
    {
        int type;  // Номер уравнения
        int n; // Число разбиений
        double a, b;  // Левая и правая границы
        double h; // Шаг разбиения
        double[] exListX = { 1.1, 1.4, 1.7, 2.1, 2.3, 2.7, 3.5, 4 }; // Список X из 3 задания
        double[] exListY = { 0.6, 0.8, 0.9, 1.5, 1.8, 1.2, 0.5, 0.8 }; // Список Y из 3 задания
        double[] exectValues = { 1.5707963267948966, 1.28539816339745, 0 };  // Точные значения интегралов 
        public Integral(int typeEntered, int nEntered, double aEntered, double bEntered)
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
                result[i] = result[i - 1] + h;
            return result;
        }
        public double[] FillArrInFuncs() // Возврат соответствующего типу массива значений Х
        {
            if (type != 2)
                return FillMassive();
            else
                return exListX;
        }
        public double F(double x) // Значение функции в точке X
        {
            double y = 0;
            switch (type)
            {
                case 0: // Вычисление значения функции для 1 
                    y = 1 / (5 - 3 * Math.Cos(x));
                    break;
                case 1: // Вычисление значения функции для 2
                    y = 1 / Math.Pow((1 + Math.Pow(x, 2)), 2);
                    break;
                case 2: // Вычисление значения функции для таблицы
                    int index = Array.IndexOf(exListX, x);
                    y = exListY[index];
                    break;
                default:
                    break;
            }
            return y;
        }
        public double F1(double x) // Значение функции в точке X
        {
            double y = 0;
            switch (type)
            {
                case 0: // Вычисление значения 1 производной для 1 функции
                    y = -3 * Math.Sin(x) / Math.Pow((5 - 3 * Math.Cos(x)), 2);
                    break;
                case 1: // Вычисление значения 1 производной для 2 функции
                    y = -4 * x / Math.Pow((Math.Pow(x, 2) + 1), 3);
                    break;
            }
            return y;
        }
        public double F2(double x) // Значение функции в точке X
        {
            double y = 0;
            switch (type)
            {
                case 0: // Вычисление значения 2 производной для 1 функции
                    double up = Math.Cos(x) + 6 * Math.Pow(Math.Sin(x), 2) / (3 * Math.Cos(x) - 5);
                    y = -3 * up / Math.Pow((3 * Math.Cos(x) - 5), 2);
                    break;
                case 1: // Вычисление значения 2 производной для 2 функции
                    up = 6 * x * x / (x * x + 1) - 1;
                    y = 4 * up / Math.Pow((Math.Pow(x, 2) + 1), 3);
                    break;
            }
            return y;
        }
        public double Teylor(double[] arr) // Разложение в ряд Тейлора
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double x = arr[i];
                sum += F(x) * h + F1(x) * h * h / 2 + F2(x) * h * h * h / 6;
            }
            return sum;
        }
        public double MonteCarlo(double[] arr) // Метод Монте-Карло
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += F(arr[i]);
            sum = sum * h;
            return sum;
        }
        public double GetDiscrepancy(double ans) // Вычисление невязок
        {
            if (type != 2)
                return Math.Abs(exectValues[type] - ans);
            else
                return 0;
        }
    }
}
