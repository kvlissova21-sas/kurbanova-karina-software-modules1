// Вариант 12 пункт А

Console.Write("Введите строку: ");
string text = Console.ReadLine();

if (text == null)
{
    Console.WriteLine("Ввод завершён");
    return;
}

int i = 0;
while (i < text.Length && text[i] == ' ')
{
    i++;
}

Console.WriteLine($"Пропущено пробелов: {i}");

// Пункт В

Console.WriteLine("Введите цифры");
string digit = Console.ReadLine();

if (digit == null)
{
    Console.WriteLine("Ввод завершён");
    return;
}

int k = 0;
while (k < digit.Length && char.IsDigit(digit[k]))
{
    k++;
}

Console.WriteLine($"Длина начального фрагмента из цифр: {k}");