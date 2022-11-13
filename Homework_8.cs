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
            int[,] arr = Numbers.ArrayFillerSelector();
            Console.WriteLine("Your start array: ");
            Specials.PrintArr(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(1) - 1; k++)
                    {
                        if (arr[i, k] < arr[i, k + 1])
                        {
                        int temp = arr[i, k + 1];
                        arr[i, k + 1] = arr[i, k];
                        arr[i, k] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Your final array: ");
            Specials.PrintArr(arr);
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
            int[,] arr = Numbers.ArrayFillerSelector();
            Console.WriteLine("Your array: ");
            Specials.PrintArr(arr);

            int dasMinimum = 0;
            int Summe = Specials.Rechnung(arr, 0);
            Console.WriteLine($"Line sums:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int MittelSumme = Specials.Rechnung(arr, i);
                if (Summe > MittelSumme)
                {
                    Summe = MittelSumme;
                    dasMinimum = i;
                }
                Console.WriteLine($"{i+1}: {MittelSumme}");
            }

            Console.WriteLine($"Smallest element summ row is: {dasMinimum+1} ({Summe})");
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
            int[,] arr_1 = Numbers.ArrayFillerSelector();
            int[,] arr_2 = Numbers.ArrayFillerSelector();
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

    class Numbers
    {
        public static int[,] ArrayFillerSelector()  // Меню выбора режима ввода массивов - ручного или автоматического
        {
            Console.WriteLine(@"We're kindly asking you to choose desired array formation type.
            Please, type in 'r' to open an robot array filler ('RAF') or 'm' to use manual ('MAF') shell:");
            var income = Convert.ToString(Console.ReadLine());
            switch (income)
            {
                case "r":
                    return RealAutomaticFiller(); // Оболочка робота для автоматического заполнения массивов
                case "m":
                    return ManualRealFiller(); // Оболочка заполнения массивов вручную
                default:
                    Console.WriteLine("Please, select from the options provided!");
                    return ArrayFillerSelector();
            }
        }

        public static int[,] RealAutomaticFiller()  // Этот робот заполняет массив натуральными числами.
        {
            Console.WriteLine("Welcome to the Automatic Filler Robot 2.0.");
            Console.WriteLine(@"This RAF Robot provides you with a double array of random numbers.
            Please, set the number of rows in the array:");

            int c_rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, set the number of columns in the array:");
            int c_columns = Convert.ToInt32(Console.ReadLine());

            int [,] rows_cols = new int [c_rows, c_columns];
            Random nummern = new Random();
            for (int i = 0; i < c_rows; i++)
                {
                    for (int e = 0; e < c_columns; e++)
                    {
                    rows_cols[i, e] = nummern.Next(11, 100); 
                    }
                }
            return rows_cols;
        }

        public static int[,] ManualRealFiller()  // Вручную заполним массив натуральными числами
        {
            Console.WriteLine(@"Welcome to the Manual array filler ('MAF') shell!
            Here you may manually set an array you want.
            Please, set the number of rows in the array: ");
            var rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, set the number of columns in the array: ");
            var columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Now please set up an array of {rows} rows and {columns} columns: ");
            int [,] rows_cols = new int [rows, columns];
            for (int i = 0; i < rows; i++)
                {
                    for (int e = 0; e < columns; e++)
                    {
                        rows_cols[i, e] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            return rows_cols;
        }
    }

    class Specials
    {
        public static void PrintArr(int [,] rows_cols)
        {
            Console.WriteLine("Your array is: ");
            int [,] matr = rows_cols;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{String.Format("{0}",matr[i, j])}  ");
                }
            Console.WriteLine();
            }
            Console.WriteLine(" ");
        }

        // Служебный метод для суммирования строк массивов
        public static int Rechnung(int[,] arr, int i)
        {
            int Summe = arr[i,0];
            for (int j = 1; j < arr.GetLength(1); j++)
            {
                Summe += arr[i,j];
            }
            return Summe;
        }
    }
}
//Конец программы