// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m == n) return m;
    return m + SumNumbers(m + 1, n);
}

//-----------------------------------------------------------------

int M = ReadInt("Введите целое число M: ");
int N = ReadInt("Введите целое число N: ");

System.Console.WriteLine($"Сумма натуральных элементов от M ({M}) до N ({N}): {SumNumbers(M, N)}");