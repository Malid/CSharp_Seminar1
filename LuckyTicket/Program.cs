using static System.Console;
Write("Введите билет для проверки на счастливость: ");
string InputBuffer = ReadLine();
int SumA = 0;
int SumB = 0;
if (int.TryParse(InputBuffer, out var x))//если получается Распарсить то число валидное
{
    if (InputBuffer.Length % 2 == 0)
    {
        int Seredina = InputBuffer.Length / 2;
        for (int i = 0; i < Seredina; i++)
        {
            char C = InputBuffer[i];
            char CC = InputBuffer[Seredina + i];
            SumA = SumA + Convert.ToUInt16(C.ToString());
            SumB = SumB + Convert.ToUInt16(CC.ToString());

        }
        if (SumA == SumB)
        {
            System.Console.WriteLine("Билет счастливый!");
            System.Console.WriteLine("Сумма первых цифр = " + SumA);
            System.Console.WriteLine("Сумма последних цифр = " + SumB);
        }
        else
        {
            System.Console.WriteLine("Не счастливый");
            System.Console.WriteLine("Сумма первых цифр = " + SumA);
            System.Console.WriteLine("Сумма последних цифр = " + SumB);
        }
    }
    else
    {
        System.Console.WriteLine("Неправильный билет");
    }
}