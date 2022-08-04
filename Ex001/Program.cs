using static System.Console;

//Задача 0
Clear();
Write("Введите число 1: ");
int numA = Convert.ToInt32(ReadLine());

//int numC = int.Parse(ReadLine());
int number = numA;
int sqr = number * number;
int number1 = Convert.ToInt32(Math.Pow(number, 2));
// System.Console.WriteLine("Введите число 1");
// int numB = Console.ReadLine();
System.Console.WriteLine($"Квадрат числа {number} = {sqr}");
System.Console.WriteLine($"Квадрат числа {number1} = {sqr}");