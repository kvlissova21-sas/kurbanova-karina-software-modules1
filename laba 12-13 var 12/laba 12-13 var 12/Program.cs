//Задание 1
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
string result = (num1 == num2) ? "Равны" : "Не равны";
Console.WriteLine(result);

//Задание 2
Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA == numB || numA == numC || numB == numC)
{
    Console.WriteLine("Есть одинаковые числа");
}
else
{
    Console.WriteLine("Все числа разные");
}

//Задание 3
Console.WriteLine("Введите знак сигнала светофора: 1 — красный, 2 — жёлтый, 3 — зелёный");
int signal = Convert.ToInt32(Console.ReadLine());

switch (signal)
{
    case 1:
        Console.WriteLine("Красный: стоять!");
        break;
    case 2:
        Console.WriteLine("Желтый: приготовиться!");
        break;
    case 3:
        Console.WriteLine("Зеленый: можно ехать!");
        break;
    default:
        Console.WriteLine("Неверный номер сигнала");
        break;
}

//Задание 4
Console.WriteLine("Введите скорость автомобиля:");
int speed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Автомобиль в городе? (Да/Нет):");
string answer = Console.ReadLine().ToLower();
bool isCity = (answer == "да");

int limit = isCity ? 60 : 90;

switch (speed)
{
    case int s when s > limit:
        Console.WriteLine($"Превышение! Ограничение {limit} км/ч.");
        break;
    case int s when s <= limit && s >= 0:
        Console.WriteLine($"Скорость в норме!");
        break;
    case int s when s < 0:
        Console.WriteLine("Ошибка: скорость не может быть отрицательной!");
        break;
}

Console.ReadLine();