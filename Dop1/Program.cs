using static System.Console;
Clear();
// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int counter = -N;
//System.Console.WriteLine(-N);
while(counter<=N){
    System.Console.Write(counter+ " ");    
    counter++;
}
