namespace lab20_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = double.Parse(Console.ReadLine());

            if (x1 == 0 || y1 == 0)
            {
                Console.WriteLine("Первая точка лежит на оси координат");
                return;
            }

            if (x2 == 0 || y2 == 0)
            {
                Console.WriteLine("Вторая точка лежит на оси координат");
                return;
            }

            Console.WriteLine("Ни одна из точек не лежит на оси координат");
        }
    }
}