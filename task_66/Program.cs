//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int GetSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }

    int step = 1;
    if(m > n)
    {
        step = -1;
    }
    return m + GetSum(m + step, n);
}

Console.Write("Введите число - от (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число - до (N): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{GetSum(m, n)}");