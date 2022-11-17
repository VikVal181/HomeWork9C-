// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers (int Number1, int Number2)
{
    int Sum = 0;
    if (Number1 == Number2) Sum=Number1;
    else Sum = Number1+SumNumbers(Number1+1,Number2);
    return Sum;
}

Console.Clear();
Console.WriteLine("Введте число M");
int M = Convert.ToInt32(Console.ReadLine());
if(M < 0) Console.WriteLine("число должно быть больше 0");
else
{
    Console.WriteLine("Введте число N");
    int N = Convert.ToInt32(Console.ReadLine());
    if(N < 0) Console.WriteLine("число должно быть больше 0");
    else{
        if(N < M)
        { 
            int Tmp = N;
            N = M;
            M = Tmp;
        }
        int Sum = SumNumbers(M,N);
        Console.WriteLine($"Сумма чисел между {M} и {N}: {Sum}");
    }
}