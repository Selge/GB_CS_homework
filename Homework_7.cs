// Старт программы
Console.WriteLine("GB C# Homework. Stage 7.");
// Вызываем меню выбора задачи
TaskSelector();
// Меню выбора задачи с комментариями
void TaskSelector()
{   // На этом моменте я устал постоянно копипастить Console.Write... 
    Console.WriteLine(@"Please, select the task  you're interested in from the list below:
    - 1.Task_1 ('Задача 47').
    - 2.Task_2 ('Задача 50').
    - 3.Task_3 ('Задача 52').");
    Console.WriteLine("Please, type in a target Task number: ");
    int task = Convert.ToInt32(Console.ReadLine());

    if (task == 1) Aufgabe.Aufgabe47();
    else if (task == 2) Aufgabe.Aufgabe50();
    else if (task == 3) Aufgabe.Aufgabe52();
    else
    {
        Console.WriteLine("Please, select from the options provided!");
        TaskSelector();
    }
}


class Aufgabe  // Задачи
{
public static void Aufgabe47()
{
    Console.WriteLine("GB C# Homework. Stage 7, Task 1 ('Задача 47').");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
    RealNumbers.PrintArray(RealNumbers.ArrayFillerSelector());
}

public static void Aufgabe50()
{
    Console.WriteLine("GB C# Homework. Stage 7, Task 2 ('Задача 50').");
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)
    int [,] rows_cols = PrimeNumbers.ArrayFillerSelector();
    PrimeNumbers.PrintArray(rows_cols);

    int rows_rc = rows_cols.GetLength(0);
    int columns_rc = rows_cols.GetLength(1);

    Console.WriteLine(@"Please, type in target number coordinates below.
    Please, type in first coordinate: ");
    int erste = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, type in the second coordinate: ");
    int zweite = Convert.ToInt32(Console.ReadLine());

    if (erste<=rows_rc && zweite<=columns_rc && erste>=0 && zweite>=0)
    {
        int target_num = rows_cols[erste, zweite];
        Console.WriteLine($"The requested number with coordinates ({erste},{zweite}) is {target_num}.");
    }
    else Console.WriteLine("The array element with the given coordinates does not exist.");
}

public static void Aufgabe52()
{
    Console.WriteLine("GB C# Homework. Stage 7, Task 3 ('Задача 52').");
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    int [,] rows_cols = PrimeNumbers.ArrayFillerSelector();
    PrimeNumbers.PrintArray(rows_cols);
    Arithmetic.Columns(rows_cols);
    Arithmetic.Rows(rows_cols);
}
}


class PrimeNumbers  // Ввод и обработка массивов простых чисел
{    // Меню выбора режима ввода массивов - ручного или автоматического
    public static int[,] ArrayFillerSelector()  // Меню выбора режима ввода массивов - ручного или автоматического
{
    Console.WriteLine("We're kindly asking you to choose desired array formation type.");
    Console.WriteLine(@"Please, type in:
    - 'p' to open an robot array filler ('PAF')
    - 'm' to use manual ('MAF') shell.");
    var income = Convert.ToString(Console.ReadLine());
    if(income == "p")
    {
        return PrimeAutomaticFiller(); // Оболочка робота для автоматического заполнения массивов
    }
    else if (income == "m") return ManualPrimeFiller(); // Оболочка заполнения массивов вручную
    else
    {
        Console.WriteLine("Please, select from the options provided!");
        return ArrayFillerSelector();
    }
}

    public static int[,] PrimeAutomaticFiller()  // Этот робот заполняет массив простыми числами.
{
    Console.WriteLine("Welcome to the Automatic Filler Robot 2.0.");
    Console.WriteLine(@"The PAF Robot provides you with a double array of random prime numbers.
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
            rows_cols[i, e] = nummern.Next(-1000, 1000);
            }
        }
    return rows_cols;
}

    public static int[,] ManualPrimeFiller()  // Вручную заполним массив простыми числами
{
        Console.WriteLine(@"Welcome to the Manual array filler ('MAF') shell!
    Here you may manually set an array you want.
    Please, set the number of rows in the array: ");
    Console.WriteLine("Please, set the number of rows in the array: ");
    var rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, set the number of columns in the array: ");
    var columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(@$"Now please set up an array of {rows} rows and {columns} columns.
    Please, type in a {rows*columns} numbers of your array step by step.");
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

    // Метод вывода массива на печать
    public static void PrintArray(int [,] rows_cols)
{
        Console.WriteLine("Your array is: ");
        int [,] matr = rows_cols;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine(" ");
}
}


class RealNumbers  // Ввод и обработка массивов вещественных чисел
{
    public static double[,] ArrayFillerSelector()  // Меню выбора режима ввода массивов - ручного или автоматического
{
    Console.WriteLine("We're kindly asking you to choose desired array formation type.");
    Console.WriteLine("Please, type in 'r' to open an robot array filler ('RAF') or 'm' to use manual ('MAF') shell:");
    var income = Convert.ToString(Console.ReadLine());
    if(income == "r")
    {
        return RealAutomaticFiller(); // Оболочка робота для автоматического заполнения массивов
    }
    else if (income == "m") return ManualRealFiller(); // Оболочка заполнения массивов вручную
    else
    {
        Console.WriteLine("Please, select from the options provided!");
        return ArrayFillerSelector();
    }
}

    public static double[,] RealAutomaticFiller()  // Этот робот заполняет массив вещественными числами.
{
    Console.WriteLine("Welcome to the Automatic Filler Robot 2.0.");
    Console.WriteLine(@"This RAF Robot provides you with a double array of random real numbers.
    Please, set the number of rows in the array:");
    int c_rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, set the number of columns in the array:");
    int c_columns = Convert.ToInt32(Console.ReadLine());
    double [,] rows_cols = new double [c_rows, c_columns];
    Random nummern = new Random();
    for (int i = 0; i < c_rows; i++)
        {
            for (int e = 0; e < c_columns; e++)
            {
            rows_cols[i, e] = nummern.NextDouble() * 100;  // Можно не умножать, сделано для большей эстетичности вывода
            }
        }
    return rows_cols;
}

    public static double[,] ManualRealFiller()  // Вручную заполним массив вещественными числами
{
    Console.WriteLine(@"Welcome to the Manual array filler ('MAF') shell!
    Here you may manually set an array you want.
    Please, set the number of rows in the array: ");
    var rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, set the number of columns in the array: ");
    var columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Now please set up an array of {rows} rows and {columns} columns: ");
    double [,] rows_cols = new double [rows, columns];
    for (int i = 0; i < rows; i++)
        {
            for (int e = 0; e < columns; e++)
            {
            rows_cols[i, e] = Convert.ToDouble(Console.ReadLine());
            }
        }
    return rows_cols;
}

    // Метод вывода массива на печать
    public static void PrintArray(double [,] rows_cols)
{
        Console.WriteLine("Your array is: ");
        double [,] matr = rows_cols;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{String.Format("{0:f1}",matr[i, j])}  ");
        }
        Console.WriteLine();
        }
    Console.WriteLine(" ");
}
}  


class Arithmetic  // Обработка значений массивов
{
    public static void Columns(int [,] rows_cols)  // Среднее арифметическое по столбцам
{
    Console.WriteLine("Arithmetic mean over columns: ");
    Console.WriteLine(" ");
    int [,] mittel = rows_cols;
    double summe_mittel = 0;
    for (int a = 0; a < mittel.GetLength(1); a++)
    {
        for (int b = 0; b < mittel.GetLength(0); b++)
        {
            summe_mittel += mittel[b, a]; 
        }
        summe_mittel = (summe_mittel/mittel.GetLength(1));
        Console.WriteLine($"Row {a+1}: {String.Format("{0:f1}",summe_mittel)}");
    }
}

    public static void Rows(int [,] rows_cols)  // Среднее арифметическое по строкам
{
    Console.WriteLine("Arithmetic mean over rows: ");
    Console.WriteLine(" ");
    int [,] mittel = rows_cols;
    double summe_mittel = 0;
    for (int a = 0; a < mittel.GetLength(0); a++)
    {
        for (int b = 0; b < mittel.GetLength(1); b++)
        {
            summe_mittel += mittel[a, b]; 
        }
        summe_mittel = (summe_mittel/mittel.GetLength(0));
        Console.WriteLine($"Row {a+1}: {String.Format("{0:f1}",summe_mittel)}");
    }
}
}
//Конец программы