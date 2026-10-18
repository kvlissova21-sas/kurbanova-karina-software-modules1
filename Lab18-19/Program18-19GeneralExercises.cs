using System.Diagnostics.Tracing;

namespace lab18_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

        }
        static void Task1()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
                alphabet[i] = (char)('A' + i);
            foreach (char letter in alphabet)
                Console.Write(letter + " ");
            Console.WriteLine();
            Console.WriteLine("Длина: " + alphabet.Length);
            Console.WriteLine("Первая: " + alphabet[0]);
            Console.WriteLine("Последняя: " + alphabet[25]);

        }
        static void Task2()
        {
            char[] alphabet = new char[33];
            int code = 'А';

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (i == 6)
                {
                    alphabet[i] = 'Ё';
                }
                else
                {
                    alphabet[i] = (char)code;
                    code++;
                }
            }
            foreach (char letter in alphabet)
                Console.Write(letter + " ");
            Console.WriteLine();


            Console.WriteLine("Длина: " + alphabet.Length);
            Console.WriteLine("Позиция 6: " + alphabet[5]);
            Console.WriteLine("Позиция 7: " + alphabet[6]);
            Console.WriteLine("Последняя: " + alphabet[32]);
        }
        static void Task3()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i + 1;
            long sum = 0;
            foreach (int value in numbers)
                sum += value;
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Длинна: " + numbers.Length);
            Console.WriteLine("Первая: " + numbers[0]);
            Console.WriteLine("Последняя: " + numbers[4]);
        }
        static void Task4()
        {
            string[] words = { "podarok" };
            List<string> result = new List<string>();

            foreach(string word in words)
            {
                if(!string.IsNullOrEmpty(word))
                {
                    result.Add(word);
                }
            }
            Console.WriteLine("Непустые строки: " + result.Count);

            foreach(string items in result)
            {
                Console.Write(items + " ");
                Console.WriteLine();
            }
        }
        static void Task5()
        {
            int[] emptyArray = new int[0];
            Console.WriteLine("Длина пустого массива: " + emptyArray.Length);

            int countFor = 0;
            for (int i = 0; i < emptyArray.Length; i += 2)
            {
                countFor++;
            }
            Console.WriteLine("Проходов for по пустому массиву: " + countFor);

            int countForeach = 0;
            foreach (int x in emptyArray)
            {
                countForeach++;
            }
            Console.WriteLine("Проходов foreach по пустому массиву: " + countForeach);

            int[] oneElement = { 5 };
            int countFor2 = 0;
            for (int i = 0; i < oneElement.Length; i += 2)
            {
                countFor2++;
            }
            Console.WriteLine("Проходов for по массиву из 1 элемента: " + countFor2);
        }
    }
    
}
