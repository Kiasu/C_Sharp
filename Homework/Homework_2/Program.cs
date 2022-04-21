/*
//Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int num1 = num / 10;
    int num2 = num1 % 10;

    Console.Write(num2);
}

ReduceNumber();
*/

/*
//Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0) num = -num;

if(num < 99)
{
    Console.WriteLine("Third number is missing");
}
else
{
    while(num >= 1000)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine("Third number is " + result);
}
*/

/*
//Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string[] Days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
int dayNumber = new Random().Next(1, 7);
Console.Write(dayNumber + " -> ");
Console.WriteLine(dayNumber + " this is " + Days[dayNumber - 1]);

if(dayNumber < 6)
{
    Console.WriteLine("Today is working day :'(");
}
else
{
    Console.WriteLine("Today is a weekend!!!");
}
*/
