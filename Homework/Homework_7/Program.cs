/*
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] array)                                          
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 2 - 1;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 3;
int n = 5;
double[,] array = new double [m, n];

FillArray(array);
PrintArray(array);
*/

/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

int m = 5;
int n = 5;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
string Position(int[,] array)
{
    string result = string.Empty;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (num == array[m,n])
            result += $"({m}, {n})";
        }
    }
    if (result == string.Empty)
    result = "Number not found";
    return result;
}

Console.WriteLine(Position(array));
*/
/*
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + " ";
    }
    return result;
}
int m = 5;
int n = 5;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));
*/

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
string Average(int[,] array)
{
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double avr = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        avr = sum / count;
        result += avr.ToString() + " ";
    }
    return result; 
}
int m = 5;
int n = 5;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Average(array)); 