// Задание 1
int size;
bool valid;
do
{
    Console.Write("Количество участников (1–30): ");
    string input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("Ввод завершён");
        return;
    }
    valid = int.TryParse(input, out size)
            && size >= 1 && size <= 30;
    if (!valid)
        Console.WriteLine("Нужно целое число от 1 до 30.");
}
while (!valid);

Console.WriteLine($"Принято: {size}");

//Задание 2

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 0;
do
{
    number /= 10;
    count++;
}
while (number > 0);
Console.WriteLine("Количество цифр:" + count);

//Задание 3

string answer;
do
{
    Console.WriteLine("Привет! :)");
    Console.Write("Повторить? (д/н): ");
    answer = Console.ReadLine();
}
while (answer == "д");
Console.WriteLine("Пока! :(");

//Вариант 12 пункт А

long sum = 0;
int number;
do
{
    Console.WriteLine("Введите число от -1000 до 1000, 0 - выход");
    string input = Console.ReadLine();

    if (input == null)
    {
        Console.WriteLine("Ввод завершен:");
        return;
    }

    if (!int.TryParse(input, out number))
    {
        Console.WriteLine("Это не число");
        continue;
    }

    if (number < -1000 || number > 1000)
    {
        Console.WriteLine("Число вне диапазона");
        continue;
    }
    if (number != 0)
    {
        sum += number;
    }
}
while (number != 0);
Console.WriteLine("Сумма: " + sum);

//пункт Б

long sum = 0;
int count = 0;
double price;
do
{
    Console.WriteLine("Введите сумму покупки, 0 - выход");
    string input = Console.ReadLine();

    if (input == null)
    {
        Console.WriteLine("Ввод завершен");
        break;
    }

    if (!double.TryParse(input, out price))
    {
        Console.WriteLine("Это не число");
        continue;
    }
    if (price < 0)
    {
        Console.WriteLine("Сумма не может быть отрицательной");
        continue;
    }
    if (price > 0)
    {
        sum += (long)price;
        count++;
    }
}
while (price != 0);
Console.WriteLine("Количество покупок: " + count);
Console.WriteLine("Итог: " + sum);



