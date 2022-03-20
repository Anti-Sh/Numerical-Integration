using System;
using System.Windows.Forms;

namespace Integral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(formA.Text);
            double b = 0;
            if (formB.Text == "2pi")
            {
                b = 2*Math.PI;
            }
            else
            {
                b = Convert.ToDouble(formB.Text);
            }
            int n = Convert.ToInt32(formN.Text);
            int type = formType.SelectedIndex;
            if(type == 2)
            {
                a = 1.1;
                b = 4;
                n = 7;
            }
            QuadratureFormulas int1 = new QuadratureFormulas(type, n, a, b);
            mainTable.Rows.Clear();
            if (type != 2)
            {
                mainTable.Rows.Add("Метод Левого Прямоугольника", int1.LeftRect(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.LeftRect(int1.FillArrInFuncs())));
                mainTable.Rows.Add("Метод Правого Прямоугольника", int1.RightRect(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.RightRect(int1.FillArrInFuncs())));
                mainTable.Rows.Add("Метод Среднего Прямоугольника", int1.MiddleRect(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.MiddleRect(int1.FillArrInFuncs())));
                mainTable.Rows.Add("Метод Трапеций", int1.Trapeze(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.Trapeze(int1.FillArrInFuncs())));
                mainTable.Rows.Add("Метод Парабол", int1.Parabola(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.Parabola(int1.FillArrInFuncs())));
                mainTable.Rows.Add("Формула Н.-К. n=3", int1.NewtonCotes(int1.FillArrInFuncs(), 3), int1.GetDiscrepancy(int1.NewtonCotes(int1.FillArrInFuncs(), 3)));
                mainTable.Rows.Add("Формула Н.-К. n=4", int1.NewtonCotes(int1.FillArrInFuncs(), 4), int1.GetDiscrepancy(int1.NewtonCotes(int1.FillArrInFuncs(), 4)));
            }
            else
            {
                mainTable.Rows.Add("Метод Левого Прямоугольника", int1.LeftRect(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.LeftRect(int1.FillArrInFuncs())));
                mainTable.Rows.Add("Метод Правого Прямоугольника", int1.RightRect(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.RightRect(int1.FillArrInFuncs())));
                mainTable.Rows.Add("Метод Трапеций", int1.Trapeze(int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.Trapeze(int1.FillArrInFuncs())));
            }
        }
    }
}
