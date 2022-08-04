using static System.Console;
Clear();
// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

//     456 -> 6
//     782 -> 2
//     918 -> 8
Write("Введите трёхзначное число: ");

int N = Convert.ToInt32(ReadLine());//считываем число с клавиатуры в целочисленную N
int LastDigit = N % 10; //получаем остаток от деления N
string LastDigit2 = Convert.ToString(N);

System.Console.WriteLine(LastDigit);
System.Console.WriteLine(LastDigit2[LastDigit2.Length-1]+ " -lastDigit2");