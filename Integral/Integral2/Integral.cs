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
        double F(double x) // Значение функции в точке X
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
        private double[] ChebX(int m) // Элементы формулы Чебышева
        {
            double[] chebX2 = { -0.57735, 0.57735 };
            double[] chebX3 = { -0.707107, 0, 0.707107 };
            if (m == 2) return chebX2;
            return chebX3;
        }
        public double Chebishev(int m, double[] arr) // Чебышев
        {
            double sum = 0;
            double[] chebX = ChebX(m);
            for (int i = 0; i < n; i++)
                foreach (double x in chebX)
                    sum += F(arr[i] + h / 2 + h / 2 * x);
            if (m == 3) return (sum * h / 3);
            return sum*h/2;
        }
        public double[,] LejandrKoef(int m)  // Элементы формулы Лежандра-Гаусса
        {
            double[,] lej2 = { { -0.57735027, 0.57735027 }, { 1, 1 } }; // x и c для m=2
            double[,] lej3 = { { -0.77459667, 0, 0.77459667 }, { 0.55555556, 0.88888889, 0.55555556 } }; // x и c для m=3
            if (m == 2) return lej2;
            return lej3;

        }
        public double LejandrGauss(int m, double[] arr) // Метод Лежандра-Гаусса
        {
            double sum = 0;
            var lejX = LejandrKoef(m);
            for (int i = 0; i < n; i++)
                for(int j = 0; j < m; j++)
                {
                    double x = arr[i] + h / 2 + h / 2 * lejX[0, j];
                    double c = lejX[1, j];
                    sum += c * F(x);
                }
            return sum * h / 2;
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
