/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(1, 10));
*/

/*
//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumDigits(int num)
{
    if (num < 1) return 0;
    int result = 0;
    return SumDigits(num / 10) + num % 10;
}
Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum digits: {SumDigits(num)}");
*/