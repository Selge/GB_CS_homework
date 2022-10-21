// Старт программы
Console.WriteLine("GB C# Homework. Stage 5.");
// Вызываем меню выбора задачи
TaskSelector();
// Меню выбора задачи с комментариями
void TaskSelector()
{
    Console.WriteLine("Please, select the task  you're interested in from the list below:");
    Console.WriteLine("1.Task_1 ('Задача 34'). This task requires an array of three-digit numbers.");
    Console.WriteLine("2.Task_2 ('Задача 36'). This task requires an array of prime numbers.");
    Console.WriteLine("3.Task_3 ('Задача 38'). This task requires an array of real numbers.");
    Console.Write("Please, type in a target Task number: ");
    int task = Convert.ToInt32(Console.ReadLine());

    if (task == 1) Aufgabe34();
    else if (task == 2) Aufgabe36();
    else if (task == 3) Aufgabe38();
    else
    {
        Console.WriteLine("Please, select from the options provided!");
        TaskSelector();
    }
}
// Каждая задача требует заполненного массива. Это меню выбора режима ввода массивов - ручного или автоматического
string[] ArrayFillerSelector()
{
    Console.WriteLine("We're kindly asking you to choose desired array formation type.");
    Console.WriteLine("Please, type in 'r' to open an robot array filler ('RAF') or 'm' to use manual ('MAF') shell:");
    var income = Convert.ToString(Console.ReadLine());
    if(income == "r")
    {
        return RobotSelectorShell(); // Оболочка робота для автоматического заполнения массивов
    }
    else if (income == "m") return ManualFillerShell(); // Оболочка заполнения массивов вручную
    else
    {
        Console.WriteLine("Please, select from the options provided!");
        return ArrayFillerSelector();
    }
}
// Оболочка для выбора роботов-заполнителей массивов
string[] RobotSelectorShell()
{
    Console.WriteLine("Welcome to the Automatic Filler Robot 1.0.");
    Console.WriteLine("Please, choose your Robot type from the options below or push 'e' to escape back to the previous point");
    Console.WriteLine("Please, type 's' to use SAF Robot to get an array of random prime numbers");
    Console.WriteLine("Please, type 't' to use TAF Robot to get an array of three-digit numbers");
    Console.WriteLine("Please, type 'r' to use RAF Robot to get an array of real numbers");
    Console.WriteLine("Please, make your choice: ");
    var anweisung_r = Convert.ToString(Console.ReadLine());
    if(anweisung_r == "e") return ArrayFillerSelector();
    else if(anweisung_r == "s") return SimpleAutomaticFiller();
    else if(anweisung_r == "t") return TripleAutomaticFiller();
    else if(anweisung_r == "r") return RealAutomaticFiller();
    else
    {
        Console.WriteLine("Please, select from the options provided!");
        return RobotSelectorShell();
    }
}
// Этот робот заполняет массив случайными числами
string[] SimpleAutomaticFiller()
{
    Console.WriteLine("This SAF Robot provides you with an array of random prime numbers.");
    Console.WriteLine("Please, type in desired array length:");
    var t_length = Console.ReadLine();
    var c_length = Convert.ToInt32(t_length);

    int [] mass = new int[c_length];
    Random nummern = new Random();
    for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = nummern.Next(-1000, 1000);
        }
    string [] massive = mass.Select(i => i.ToString()).ToArray();
    return massive;
}
// Этот робот заполняет массив положительными трёхзначными числами.
string[] TripleAutomaticFiller()
{
    Console.WriteLine("This TAF Robot provides you with an array of three-digit numbers.");
    Console.WriteLine("Please, type in desired array length:");
    var t_length = Console.ReadLine();
    var c_length = Convert.ToInt32(t_length);

    int [] mass = new int[c_length];
    Random nummern = new Random();
    for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = nummern.Next(100, 1000); // Всё то же самое, что и в SAF, но с ограничением по диапазону в .Next
        }
    string [] massive = mass.Select(i => i.ToString()).ToArray();
    return massive;
}
// Этот робот заполняет массив вещественными числами. 
string [] RealAutomaticFiller()
{
    Console.WriteLine("This RAF Robot provides you with an array of real numbers.");
    Console.WriteLine("Please, type in desired array length:");
    var t_length = Console.ReadLine();
    var c_length = Convert.ToInt32(t_length);

    double [] mass = new double[c_length];
    Random nummern = new Random();
    for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = nummern.NextDouble();
        }
    string [] massive = mass.Select(i => i.ToString()).ToArray();
    return massive;
}
// Оболочка ручного заполнения массива. Отсюда можно вернуться назад или начать заполнять массив.
string[] ManualFillerShell()
{
    Console.WriteLine("Welcome to the Manual array filler ('MAF') shell!");
    Console.WriteLine("Here you may manually set any type of array you want.");
    Console.WriteLine("Please type in 'f' to move forward or 'e' to escape: ");
    var anweisung_m = Convert.ToString(Console.ReadLine());
    if(anweisung_m == "f") return ManualArrayFiller();
    else if (anweisung_m == "e") return ArrayFillerSelector();
    else
    {
        Console.WriteLine("Please, select from the options provided!");
        return ManualFillerShell();
    }
}
// Функция ручного заполнения массива.
string[] ManualArrayFiller()
{
    Console.WriteLine("Please, type in desired length of array:");
    int new_length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Now please set up an array of {new_length} numbers:");
    int [] mass = new int[new_length];
    for (int i = 0; i < mass.Length; i++)
        {
            Console.WriteLine($"Please, type in a {i} number of your array:");
            mass[i] = Convert.ToInt32(Console.ReadLine());
        }
    string [] massive = mass.Select(i => i.ToString()).ToArray();
    return massive;
}

void Aufgabe34()
{
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
    Console.WriteLine("GB C# Homework. Stage 5, Task 1 ('Задача 34').");

    string[] A34 = ArrayFillerSelector(); // Принимаем на вход массив
    int[] Reihe34 = Array.ConvertAll(A34, s => int.Parse(s)); // И конвертируем его в нужный формат
     
    Console.WriteLine($"Your array({string.Join(",", Reihe34)}) consists of {Reihe34.Length} numbers.");

    Gerade34(Reihe34);
    UnGerade34(Reihe34);
}
Console.WriteLine();
TaskSelector();

void Gerade34(int [] Reihe34) // Метод обрабатывает чётные числа массива для Задачи 34
{
    int [] gerade_nummer = new int [Reihe34.Length]; //создаём массив-аккумулятор для сбора чётных чисел
    for(int i = 0; i < gerade_nummer.Length; i++) 
    {
        gerade_nummer[i] = -1; // Назначаем всем элементам аккумулятора значение -1;
    }

    for (int e = 0; e < Reihe34.Length; e++) // Циклом выбираем из входящего массива все чётные
    {
        if(Reihe34[e] % 2 == 0) gerade_nummer[e] = Reihe34[e]; // И вот таким образом сохраняем в аккумулятор
    }

    int menge = 0; // количество чётных чисел (т.е. не равных -1) в аккумуляторе
    for (int f = 0; f < gerade_nummer.Length; f++)
    {
        if (gerade_nummer[f] != -1) menge++;
    }

    int [] rei_gerade = new int[menge]; // Результирующий массив для чётных
    int a = 0;
    for (int i = 0; i < gerade_nummer.Length; i++)
    {
        if (gerade_nummer[i] != -1)
        {
            rei_gerade[a] = gerade_nummer[i];
            a++;
        }
    }
    int [] zrg = rei_gerade;

    int zahlen = rei_gerade.Sum(); // Сюда запишем сумму чётных чисел
    
    Console.WriteLine($"Array consists of {menge} even numbers.");
    Console.WriteLine($"Even numbers in the array are the following: ({string.Join(",", zrg)}).");
    Console.WriteLine($"Total summ of even numbers is {zahlen}.");
}

void UnGerade34(int [] Reihe34) // Метод обрабатывает нечётные числа массива для Задачи 34
{
    int [] ungerade_nummer = new int [Reihe34.Length]; //создаём массив-аккумулятор для сбора нечётных чисел
    for(int i = 0; i < ungerade_nummer.Length; i++) 
    {
        ungerade_nummer[i] = -1; // Назначаем всем элементам аккумулятора значение -1;
    }

    for (int e = 0; e < Reihe34.Length; e++) // Циклом выбираем из входящего массива все нечётные
    {
        if(Reihe34[e] % 2 != 0) ungerade_nummer[e] = Reihe34[e]; // И вот таким образом сохраняем в нечетный аккумулятор
    }

    int un_menge = 0; // Количество нечётных
    for (int uf = 0; uf < ungerade_nummer.Length; uf++)
    {
        if (ungerade_nummer[uf] != -1) un_menge++;
    }

    int [] rei_ungerade = new int[un_menge]; // Результирующий массив для нечётных
    int b = 0;
    for (int i = 0; i < ungerade_nummer.Length; i++)
    {
        if (ungerade_nummer[i] != -1)
        {
            rei_ungerade[b] = ungerade_nummer[i];
            b++;
        }
    }
    int [] un_zrg = rei_ungerade;

    int un_zahlen = rei_ungerade.Sum(); // Сюда запишем сумму нечётных чисел

    Console.WriteLine($"Array consists of {un_menge} odd numbers.");
    Console.WriteLine($"Odd numbers in the array are the following: ({string.Join(",", un_zrg)}).");
    Console.WriteLine($"Total summ of odd numbers is {un_zahlen}.");
}

// Дальше по идее тоже должны были быть циклы, но на них очень не хватило времени :'-(
// Плюс хотелось немного поупражняться со встроенными методами

void Aufgabe36()
{
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
    Console.WriteLine("GB C# Homework. Stage 5, Task 2 ('Задача 36').");

    string [] A36 = ArrayFillerSelector(); // Принимаем на вход массив
    int[] Reihe36 = Array.ConvertAll(A36, s => int.Parse(s)); // И конвертируем его в нужный формат

    Console.WriteLine($"Your array is ({string.Join(",", Reihe36)}).");
    UnGerade36(Reihe36);
    Gerade36(Reihe36);
}
Console.WriteLine();
TaskSelector();

void Gerade36(int [] Reihe36) // Метод обрабатывает чётные позиции массива для Задачи 36
{
    var zahlen_R36 = Reihe36.Where((element, index) => index % 2 == 0); //создаём массив-аккумулятор для сбора чисел с нечётных позиций
    var menge36 = zahlen_R36.Count();
    var zahlen36 = zahlen_R36.Sum();

    Console.WriteLine($"The incoming array has ({menge36}) even position elements.");
    Console.WriteLine($"Even position elements are the following: ({string.Join(",",zahlen_R36)}).");
    Console.WriteLine($"Even position numbers summ is {zahlen36}.");
}

void UnGerade36(int [] Reihe36) // Метод обрабатывает нечётные позиции массива для Задачи 36
{
    var zahlen_unR36 = Reihe36.Where((element, index) => index % 2 != 0); //создаём массив-аккумулятор для сбора чисел с нечётных позиций
    var un_menge36 = zahlen_unR36.Count();
    var un_zahlen36 = zahlen_unR36.Sum();

    Console.WriteLine($"The incoming array has ({un_menge36}) odd position elements.");
    Console.WriteLine($"Odd position elements are the following: ({string.Join(",",zahlen_unR36)}).");
    Console.WriteLine($"Odd position numbers summ is {un_zahlen36}.");
}

void Aufgabe38()
{
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
    Console.WriteLine("GB C# Homework. Stage 5, Task 3 ('Задача 3').");

    string[] A38 = ArrayFillerSelector(); // Принимаем на вход массив
    double[] Reihe38 = A38.Select<string, double>(s => Double.Parse(s)).ToArray<double>(); // И конвертируем его в нужный формат

    double grosste = Reihe38.Max();
    double kleinste = Reihe38.Min();
    double differenz = grosste - kleinste;

    Format38(Reihe38, grosste, kleinste, differenz);
}
Console.WriteLine();
TaskSelector();

void Format38(double [] Reihe38, double grosste, double kleinste, double differenz) // Метод форматирования вывода для Задачи 38
{
    string gr_out = String.Format("{0:0.00}", grosste);
    string kl_out = String.Format("{0:0.00}", kleinste);
    string d_out = String.Format("{0:0.00}", differenz);

    Console.WriteLine($"Your array is: ");
    foreach (double p in Reihe38) Console.WriteLine("{0:0.00}", p);
    Console.WriteLine();
    Console.WriteLine($"Max element of the array is {gr_out}.");
    Console.WriteLine($"Min element of the array is {kl_out}.");
    Console.WriteLine($"Difference {gr_out} from {kl_out} is {d_out}.");
}
//Конец программы