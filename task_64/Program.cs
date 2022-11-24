//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"

string GetNumbers(int m, int n)
{
    if (m == n)
    {
        return Convert.ToString(n);
    }

    int step = 1;
    if(m > n)
    {
        step = -1;
    }
    return Convert.ToString(m) + ", " + GetNumbers(m + step, n);
}

Console.Write("Введите число - от (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число - до (N): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{GetNumbers(m, n)}");