/*
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;

int reverse = 0;
while(num > 0)
{
    int digits = num % 10;
    reverse = reverse * 10 + digits;
    num = num / 10;
}
if(n == reverse)
{
    Console.WriteLine("It's a palindrome");
}
else
{
    Console.WriteLine("It's NOT a palindrome");
}
*/

/*
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Sqrt1(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}
Console.WriteLine("Input first coordinate: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second coordinate: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third coordinate: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input fourth coordinate: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input fifth coordinate: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input sixth coordinate: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Sqrt1(x1, y1, z1, x2, y2, z2));
*/

/*
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} x {i} x {i} = {i * i * i}");
}
*/

