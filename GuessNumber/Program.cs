//

//задание 1
Console.Write("Введите пароль: ");
string password = Console.ReadLine();

Console.Write("Подтвердите пароль: ");
string confirm = Console.ReadLine();

if (password == confirm)
{
    Console.WriteLine("Пароль принят");
}
else
{
    Console.WriteLine("Пароль не принят");
}
// задание 2
Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}
//задание 3
Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите операцию (+, -, *, /): ");
string op = Console.ReadLine();

switch (op)
{
    case "+":
        Console.WriteLine($"{a} + {b} = {a + b}");
        break;
    case "-":
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    case "*":
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    case "/":
        if (b == 0)
        {
            Console.WriteLine("На ноль делить нельзя!");
        }
        else
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        break;
    default:
        Console.WriteLine("Неизвестная операция");
        break;
}
//задание 4
Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine());

int sum = 0;
if (n1 > 0) sum += n1;
if (n2 > 0) sum += n2;
if (n3 > 0) sum += n3;

Console.WriteLine($"Сумма положительных: {sum}");
//задание 5
Console.WriteLine("=== Тёмный Лабиринт ===");
Console.WriteLine("Перед вами две двери:");
Console.WriteLine("A — Комната с огромным драконом");
Console.WriteLine("B — Тёмный коридор");
Console.Write("Ваш выбор (A/B): ");
string path = Console.ReadLine().ToUpper();

if (path == "A")
{
    Console.WriteLine("\nДракон говорит: \"Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.\"");
    Console.Write("Ваш ответ: ");
    string answer = Console.ReadLine().ToLower();

    if (answer == "рыба")
    {
        Console.WriteLine("+ Дракон отступает и открывает дверь. Вы прошли дальше!");
    }
    else
    {
        Console.WriteLine("- Неверно! Дракон съедает вас.");
    }
}
else if (path == "B")
{
    Console.WriteLine("\nВы в тёмной комнате. Перед вами две двери:");
    Console.WriteLine("1 — Сокровища Dungeon Master'а");
    Console.WriteLine("2 — Ловушка с ядовитыми шипами");
    Console.Write("Выбор (1/2): ");
    string door = Console.ReadLine();

    if (door == "1")
    {
        Console.WriteLine("+ Вы нашли сокровища! Победа!");
    }
    else if (door == "2")
    {
        Console.WriteLine("- Ловушка! Вы погибли.");
    }
    else
    {
        Console.WriteLine("Неверный выбор. Вы остались в темноте навсегда.");
    }
}
else
{
    Console.WriteLine("Неизвестный путь. Вы заблудились в лабиринте.");
}
