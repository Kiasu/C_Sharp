/*
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Enter the numbers separated by a space: "); // (введите числа через пробел) Не знал как по английски правильно будет, ввел то что выдал переводчик :)

int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

int Numbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine(Numbers(array));
*/

/*
//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Input number: ");
int a = int.Parse(Console.ReadLine());
int b;
string result = " ";
while (a > 0)
{
    b = a % 2;
    result = b + result;
    a = a / 2;
}
Console.WriteLine($"Output: {result}");
*/

/*
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

string X(int k1, int k2, int b1, int b2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"({x}, {y})";
    return result;
}

Console.WriteLine(X(2, -3, -3, 2));
*/