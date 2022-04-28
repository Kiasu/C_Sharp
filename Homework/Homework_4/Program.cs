/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] FindIntegersNums(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            counter++;
        }
    }
    Console.WriteLine("Integer nums is: " + counter);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int[] MyArray = CreateRandomArray(5, 100, 999);
int[] NewArr = FindIntegersNums(MyArray);
ShowArray(NewArr);
*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] FindNotIntegerNums(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
            sum += array[i];  
    }
    Console.WriteLine("Sum of odd numbers " + sum);
    return(array);
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int[] MyArray = CreateRandomArray(6, -10, 10);
int[] NewArr = FindNotIntegerNums(MyArray);
ShowArray(NewArr);
*/

/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = {1.145, 5.23, 12, 4.51, 8.12, 15.94};

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine("Difference between max and min = " + (max - min));
*/
