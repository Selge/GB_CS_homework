//Старт программы
namespace Homework_9
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
            Console.WriteLine("GB C# Homework. Stage 9.");
            Console.WriteLine(@"Please, select the task  you're interested in from the list below:
            - 1.Task_1 ('Задача 64').
            - 2.Task_2 ('Задача 66').
            - 3.Task_3 ('Задача 68').");
            Console.WriteLine("Please, type in a target Task number: ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Aufgabe.Aufgabe64();
                    break;
                case 2:
                    Aufgabe.Aufgabe66();
                    break;
                case 3:
                    Aufgabe.Aufgabe68();
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
        public static void Aufgabe64()
        {
            Console.WriteLine("GB C# Homework. Stage 9, Task 1 ('Задача 64').");
            // Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
            // Выполнить с помощью рекурсии.
            // N = 5 -> "4, 2"
            // N = 8 -> "8, 6, 4, 2,"
        }

        public static void Aufgabe66()
        {
            Console.WriteLine("GB C# Homework. Stage 9, Task 2 ('Задача 66').");
            // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            // M = 1; N = 15 -> 120
            // M = 4; N = 8. -> 30
        }

        public static void Aufgabe68()
        {
            Console.WriteLine("GB C# Homework. Stage 9, Task 3 ('Задача 68').");
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            // m = 2, n = 3 -> A(m,n) = 9
            // m = 3, n = 2 -> A(m,n) = 29
        }
    }
}
//Конец программы