//Задание 1

Console.WriteLine("Введите число x вектора А");
var input1 = Console.ReadLine();
Console.WriteLine("Введите число y вектора А");
var input2 = Console.ReadLine();
Console.WriteLine("Введите число z вектора А");
var input3 = Console.ReadLine();
Console.WriteLine("Введите число x вектора B");
var input4 = Console.ReadLine();
Console.WriteLine("Введите число y вектора B");
var input5 = Console.ReadLine();
Console.WriteLine("Введите число z вектора B");
var input6 = Console.ReadLine();

double a1 = Convert.ToDouble(input1);
double a2 = Convert.ToDouble(input2);
double a3 = Convert.ToDouble(input3);
double b1 = Convert.ToDouble(input4);
double b2 = Convert.ToDouble(input5);
double b3 = Convert.ToDouble(input6);

double lenghtA = Math.Sqrt(a1 * a1 + a2 * a2 + a3 * a3);
double lenghtB = Math.Sqrt(b1 * b1 + b2 * b2 + b3 * b3);
double lenghtAB = Math.Sqrt(
    (a1 - b1) * (a1 - b1) +
    (a2 - b2) * (a2 - b2) +
    (a3 - b3) * (a3 - b3)
);

Console.WriteLine(lenghtA);
Console.WriteLine(lenghtB);
Console.WriteLine(lenghtAB);


//Задание 2

Console.WriteLine("Введите число x1");
var input7 = Console.ReadLine();
Console.WriteLine("Введите число x2");
var input8 = Console.ReadLine();
Console.WriteLine("Введите число w1");
var input9 = Console.ReadLine();
Console.WriteLine("Введите число w2");
var input10 = Console.ReadLine();
Console.WriteLine("Введите число b1");
var input11 = Console.ReadLine();
Console.WriteLine("Введите число b2");
var input12 = Console.ReadLine();
Console.WriteLine("Введите число v");
var input13 = Console.ReadLine();

double x1 = Convert.ToDouble(input7);
double x2 = Convert.ToDouble(input8);
double w1 = Convert.ToDouble(input9);
double w2 = Convert.ToDouble(input10);
double B1 = Convert.ToDouble(input11);
double B2 = Convert.ToDouble(input12);
double v = Convert.ToDouble(input13);

double h = x1 * w1 + x2 * w2 + B1;
double y = h * v + B2;
Console.WriteLine(h);
Console.WriteLine(y);

//Задание 3

Console.WriteLine("Введите число t1");
var input14 = Console.ReadLine();
Console.WriteLine("Введите число t2");
var input15 = Console.ReadLine();
Console.WriteLine("Введите число N");
var input16 = Console.ReadLine();
Console.WriteLine("Введите число t3");
var input17 = Console.ReadLine();

double t1 = Convert.ToDouble(input14);
double t2 = Convert.ToDouble(input15);
double N = Convert.ToDouble(input16);
double t3 = Convert.ToDouble(input17);

double T = t1 + t2 * N + t3;
Console.WriteLine(T);