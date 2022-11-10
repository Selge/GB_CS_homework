//Старт программы
namespace Homework_8
{
    class App
    {
        static void Main()
        {
            Start.TaskSelector();
        }
    }

    class Start
    {
        public static void TaskSelector()
        {
            Console.WriteLine("GB C# Homework. Stage 8.");
            Console.WriteLine(@"Please, select the task  you're interested in from the list below:
            - 1.Task_1 ('Задача 54').
            - 2.Task_2 ('Задача 56').
            - 3.Task_3 ('Задача 58').
            - 4.Task_4 ('Задача 60').
            - 5.Task_5 ('Задача 62').");
            Console.WriteLine("Please, type in a target Task number: ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Aufgabe.Aufgabe54();
                    break;
                case 2:
                    Aufgabe.Aufgabe56();
                    break;
                case 3:
                    Aufgabe.Aufgabe58();
                    break;
                case 4:
                    Aufgabe.Aufgabe60();
                    break;
                case 5:
                    Aufgabe.Aufgabe62();
                    break;
                default:
                    Console.WriteLine("Please, select from the options provided!");
                    TaskSelector();
                    break;
            }
        }
    }

    class Aufgabe
    {
        public static void Aufgabe54()
        {
            Console.WriteLine("GB C# Homework. Stage 8, Task 1 ('Задача 54').");
        // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2
        }

        public static void Aufgabe56()
        {
            Console.WriteLine("GB C# Homework. Stage 8, Task 2 ('Задача 56').");
        // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
        }

        public static void Aufgabe58()
        {
            Console.WriteLine("GB C# Homework. Stage 8, Task 3 ('Задача 58').");
        // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        // Например, даны 2 матрицы:
        // 2 4 | 3 4
        // 3 2 | 3 3
        // Результирующая матрица будет:
        // 18 20
        // 15 18
        }

        public static void Aufgabe60()
        {
            Console.WriteLine("GB C# Homework. Stage 8, Task 4 ('Задача 60').");
        // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        // Массив размером 2 x 2 x 2
        // 66(0,0,0) 25(0,1,0)
        // 34(1,0,0) 41(1,1,0)
        // 27(0,0,1) 90(0,1,1)
        // 26(1,0,1) 55(1,1,1)
        }

        public static void Aufgabe62()
        {
            Console.WriteLine("GB C# Homework. Stage 8, Task 5 ('Задача 62').");
        // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07
        }
    }

    class Array
    {
        
    }
}
//Конец программы