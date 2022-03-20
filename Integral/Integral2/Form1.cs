using System;
using System.Windows.Forms;

namespace Integral2
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
                b = 2*Math.PI;
            else
                b = Convert.ToDouble(formB.Text);
            int n = Convert.ToInt32(formN.Text);
            int type = formType.SelectedIndex;
            if(type == 2)
            {
                a = 1.1;
                b = 4;
                n = 7;
            }
            Integral int1 = new Integral(type, n, a, b);
            mainTable.Rows.Clear();
            if (type != 2)
            {
                mainTable.Rows.Add("Чебышев m=2", int1.Chebishev(2, int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.Chebishev(2, int1.FillArrInFuncs())));
                mainTable.Rows.Add("Чебышев m=3", int1.Chebishev(3, int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.Chebishev(3, int1.FillArrInFuncs())));
                mainTable.Rows.Add("Лежандр-Гаусс m=2", int1.LejandrGauss(2, int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.LejandrGauss(2, int1.FillArrInFuncs())));
                mainTable.Rows.Add("Лежандр-Гаусс m=3", int1.LejandrGauss(3, int1.FillArrInFuncs()), int1.GetDiscrepancy(int1.LejandrGauss(3, int1.FillArrInFuncs())));
            }
        }
    }
}
