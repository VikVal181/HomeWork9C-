// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int Number1, int Number2)
{
    int A = 0;
    if (Number1 == 0) A=Number2+1;
    else if (Number1 > 0 && Number2 == 0) A = Akkerman(Number1-1,1);
    else A=Akkerman(Number1-1,Akkerman(Number1,Number2-1));
    return A;
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
        int A = Akkerman(M,N);
        Console.WriteLine($"Функция Аккермана: А({M},{N})={A}");
    }
}