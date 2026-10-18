using System.Reflection.PortableExecutable;

namespace lab18_19Option12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskA1();
            TaskB1();
            TaskA2();
            TaskB2();

        }
        static void TaskA1()
        {
            int[] numbers = {-5, -2, -10};
            if (numbers.Length == 0)
            {
                Console.WriteLine("Массив пуст");
                return;
            }
            int MaxValue = numbers[0];
            int MaxIndex = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] > MaxValue)
                {
                    MaxValue = numbers[i];
                    MaxIndex = i;
                }
            }
            Console.WriteLine("Первый максимум: " + MaxValue);
            Console.WriteLine("Индекс: " + MaxIndex);
        }
        static void TaskB1()
        {
            int[] digits = {0, 7, 8, 9};
            if (digits.Length == 0)
            {
                Console.WriteLine("Массив пуст");
                return;
            }
            int maxTime = digits[0];
            int maxIndex = 0;
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] > maxTime)
                {
                    maxTime = digits[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine("Самая долгая операция: " + maxTime);
            Console.WriteLine("Индекс: " + (maxIndex + 1));
        }
        static void TaskA2()
        {
            int[] numbers = {52};
            int minValue = 0;
            bool hasData = false;

            foreach (int value in numbers)
            {
                if (!hasData)
                {
                    minValue = value;
                    hasData = true;
                }
                else if (value < minValue)
                {
                    minValue = value;
                }
            }

            if (hasData)
                Console.WriteLine("Минимальное значение: " + minValue);
            else
                Console.WriteLine("Нет данных");
        }
        static void TaskB2()
        {
            double[] temps = { 0.0 };
            double maxTemp = -40.0;
            bool hasData = false;
            foreach (double temp in temps)
            {
                if (!hasData)
                {
                    maxTemp = temp;
                    hasData = true;
                }
                else if (temp > maxTemp)
                {
                    maxTemp = temp;
                }
            }

            if (hasData)
                Console.WriteLine("Самое высокое показание: " + maxTemp);
            else
                Console.WriteLine("Нет показаний");
        }
    }
}
