// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int Number)
{
    if (Number==1) Console.WriteLine("1");
    else
    {
        Console.Write($"{Number},");
        PrintNumbers(Number-1);
    }
}

Console.Clear();
Console.WriteLine("Введте число");
int N = Convert.ToInt32(Console.ReadLine());
if(N<1) Console.WriteLine("число должно быть больше 1");
else PrintNumbers(N);