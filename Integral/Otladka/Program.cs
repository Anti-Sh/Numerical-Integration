using Integral2;

Console.WriteLine("Hello, World!");

double[] arr = { 0, Math.PI/2, Math.PI, Math.PI*1.5, 2 * Math.PI };
double sum = 0;


Integral int1 = new Integral(0, 2, 0, 2*Math.PI);
/*
foreach(double x in arr)
{
    Console.WriteLine(int1.F(x));
}
*/

Console.WriteLine("НАЧААЛО");
Console.WriteLine(int1.F(2*Math.PI));
Console.WriteLine(int1.F1(2 * Math.PI));
Console.WriteLine(int1.F2(2 * Math.PI));

//int1.Chebishev(2, int1.FillArrInFuncs());
Console.WriteLine();