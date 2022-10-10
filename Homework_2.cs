﻿Console.WriteLine("GB C# Homework Part_2");

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("GB_C#_Homework_2 Task_1");
Console.WriteLine("Please enter a 3-digit number (number A): ");
Start_A:
var numberA = Console.ReadLine();
//int number_numA = Convert.ToInt32(numberA);
var digitArrayA = numberA!.ToArray();
if(digitArrayA.Length >= 3)
{
    Console.WriteLine($"{digitArrayA[2]}");
}
else
{
    Console.WriteLine($"{numberA} is not sufficient. Please enter a 3-digit number:");
    goto Start_A;
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("GB_C#_Homework_2 Task_2");
Console.WriteLine("Please enter a number B: ");
var numberB = Console.ReadLine();
//int number_num = Convert.ToInt32(number);
var digitArrayB = numberB!.ToArray();
if(digitArrayB.Length >= 3)
{
    Console.WriteLine($"{digitArrayB[2]}");
}
else
{
    Console.WriteLine($"{numberB} has no 3-rd digit");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("GB_C#_Homework_2 Task_3");
Console.WriteLine("Please enter a day of the week number (from 1 to 7): ");
Start_B:
var day = Console.ReadLine();
int week_num = Convert.ToInt32(day);
string [] wochentage = new string [] {"Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"};
if(week_num > 7)
{
    Console.WriteLine($"{day} is not a 'day of the week' number.");
    Console.WriteLine("Please, type in another value:");
    goto Start_B;
}
else
{
    // Здесь не совсем магическое число: в классической 7-ми дневной неделе как правило 2 выходных дня. Поэтому отнимаем от общей длины массива два дня.
    if(week_num <= 5)
    {
        Console.Write($"{wochentage[week_num - 1]}({day}) in not a weekend day, it's a business day. Go back to work!");
    }
    else
    {
        Console.Write($"{wochentage[week_num - 1]}({day}) is a weekend day. Have some rest.");
    }
}