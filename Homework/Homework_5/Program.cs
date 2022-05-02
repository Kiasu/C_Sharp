/*
//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Write first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int exponent = 1;
for (int i = 1; i <= b; i++)
{
    exponent *= a;
}
Console.WriteLine(exponent);
*/

/*
//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfNumbers(int number)
{
    if (number < 1) return 0;
    int result = 0;
    return SumOfNumbers(number / 10) + number % 10;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers: {SumOfNumbers(number)}");
*/

/*
//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = {1, 2, 3, 4, 5, 6, 7, 8};  

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

ShowArray(array);
*/