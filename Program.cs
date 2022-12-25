/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
int SecPosit(int number)
{
    int a = number % 100;
    int b = a / 10;
    return b;
}

Console.Write("Input your number from 100 to 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 999 || userNumber < 100)
{
    Console.WriteLine("Uncorrect number");
}
else
{
    Console.WriteLine($"The second position of number {userNumber} is {SecPosit(userNumber)}");
}
*/

/* Задача 2: Напишите программу, которая выводит третью цифру (слева) заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int ThirdNumber(int number)
{
    while (number > 1000)
    {
    number = number / 10;
    }

    int result = number % 10;
    return result;
}

Console.Write("Enter the number from 100 to 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100)
    Console.Write("Your number less than 100");
else
    Console.Write($"The third position of the {userNumber} is {ThirdNumber(userNumber)}");
*/
/* Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
bool WeekCheck(int number)
{
    if (number > 5 && number < 8)
        return true;
    else return false; 
}

Console.Write("Enter the number of the day of the week: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Is your day number {userNumber} a weekend? - {WeekCheck(userNumber)}");
*/