/*
//Задача 1. Возводим число в квадрат

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num*num;

Console.WriteLine("Result is " + result);

*/

/*
//Задача 2. Проверка чисел является - ли первое квадратом второго

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2)
    Console.WriteLine("First number is a quad of second number");
else
    Console.WriteLine("First number is not a quad of second number");

*/

/*
//Задача 3. Узнаем день недели

Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1)
{
    Console.WriteLine("Incorrect number of day!");
}
else
{
    if(day == 1)
        Console.WriteLine("It's monday");
    if(day == 2)
        Console.WriteLine("It's tuesday"); 

}

*/

/*
//Задача 4. Целые числа

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if(num < 0)
{
    current = num;
    num = num * (-1);
}
else
{
    current = -1 * num;
}

while(current <= num)
{
    Console.Write(current + " ");
    current++; //current = current + 1;
}

*/


/*
//Задача 5. Из трехзначного числа показать последнюю цифру

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
    Console.WriteLine("Incorrect number");
else
{
    int a = num % 10;
    Console.WriteLine("Resulted number is " + a);
}   

*/

//345 % 10 = 5
//345 / 10 = 34
//345 / 100 = 3
//345 % 100 = 45
//(1234 / 100) % 10 = 2

/*
//Задача 6. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int ShowNumber(int n)
{
    int firstNum = n/10;
    int secondNum = n%10;

    Console.Write(n + " -> ");

    if(firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}

int num = new Random().Next(10, 99);
int a = ShowNumber(num);
Console.WriteLine(a);

*/

/*
//Задача 7. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int num1 = num / 100;
    int num2 = num % 10;
    int num3 = num1 * 10 + num2;

    Console.Write(num3);
}

ReduceNumber();
*/

/*
//Задача 8. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

void IfMultiple()
{
    Console.Write("Input first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 % num2 == 0)
    {
        Console.Write(num1 + " is multiple of " + num2);
    }
    else
    {
        Console.Write(num1 + " is NOT multiple of " + num2);
    }
}
IfMultiple();
*/

/*
//Задача 9. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void Multiple(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.Write(num + " is multiple of 7 and 23");
    }
    else
    {
        Console.Write(num + " is NOT multiple of 7 and 23");
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Multiple(num);
*/

/*
//Задача 10. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void Sqr(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Sqr(num1, num2);

*/

/*
//Задача 11. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQvart(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else
        return 0;
}

Console.WriteLine("Input X coordinate");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate");
int yDot = Convert.ToInt32(Console.ReadLine());

int qvartNum = FindQvart(xDot, yDot);

if (qvartNum == 0)
    Console.WriteLine("Dot located on the axes");
else
    Console.WriteLine("Number of quart is " + qvartNum);    

*/

/*
//Задача 12. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void FindArea(int q)
{
    if(q == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (q == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (q == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (q == 4)
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("Wrong number");       

}

Console.WriteLine("Input qvad number: ");
int qvadNum = Convert.ToInt32(Console.ReadLine());

FindArea(qvadNum);

*/

/*
Console.Clear();
double Sqrt1(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

Console.WriteLine("Input first coordinate: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second coordinate: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third coordinate: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input fourth coordinate: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Sqrt1(x1, y1, x2, y2));

*/
