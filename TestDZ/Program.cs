using static System.Console;
Clear();

void Task2()
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
{
    Clear();
    Task2Info();

    Write("Введите число 1: ");
    int a = Convert.ToInt32(ReadLine());

    Write("Введите число 2: ");
    int b = Convert.ToInt32(ReadLine());
    int max = 0;

    if (a>b) max = a;
    if (b>a) max = b;

    WriteLine("max = " + max);
}


void Task4()
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
{
    Clear();
    Task4Info();
}


void Task6()
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
{
    System.Console.WriteLine("It works!6");
}


void Task8()
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
{
    System.Console.WriteLine("It works!8");
}


void ShowMenu()
{
    //Menu
    Clear();
    Task2Info();
    Task4Info();
    Task6Info();
    Task8Info();
    //Menu End
}


void Task2Info()
{
    WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    WriteLine("a = 5; b = 7 -> max = 7");
    WriteLine("a = 2 b = 10 -> max = 10");
    WriteLine("a = -9 b = -3 -> max = -3");
    WriteLine(" ");
}


void Task4Info()
{

    WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    WriteLine("2, 3, 7 -> 7");
    WriteLine("44 5 78 -> 78");
    WriteLine("22 3 9 -> 22");
    WriteLine("");
}


void Task6Info()
{
    WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    WriteLine("4 -> да");
    WriteLine("-3 -> нет");
    WriteLine("7 -> нет");
    WriteLine("");
}

void Task8Info()
{
    WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    WriteLine("5 -> 2, 4");
    WriteLine("8 -> 2, 4, 6, 8");
    WriteLine("");
}


// Начало программы
ShowMenu();
Write("Введите номер нужной задачи, q для выхода, m для показа меню:");
string Key = ReadLine();

while (Key != "q")
{
    switch (Key)
    {
        case "2":
            Clear();
            Task2();
            //выполняем задачу 2
            //WriteLine("Задача 2");
            break;

        case "4":
            Clear();
            Task4();
            //выполняем задачу 4
            //WriteLine("Задача 4");
            break;

        case "6":
            Clear();
            Task6();
            //выполняем задачу 6
            WriteLine("Задача 6");
            break;

        case "8":
            Clear();
            Task8();
            //выполняем задачу 8
            WriteLine("Задача 8");
            break;

        case "m":
            ShowMenu();
            break;

        default:
            WriteLine("Неправильный номер задачи!");
            break;
    }
    Write("Введите номер нужной задачи, q для выхода, m для показа меню:");
    Key = ReadLine();
}

