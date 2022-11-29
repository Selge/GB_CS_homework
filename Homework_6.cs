// Старт программы
namespace Homework_6
{
    class App
        {
            static void Main()
            {
                // Вызываем меню выбора задачи
                Start.TaskSelector();
            }
        }

    class Start
    {
        // Меню выбора задачи с комментариями
        void TaskSelector()
        {
            Console.WriteLine("GB C# Homework. Stage 6.");
            Console.WriteLine(@"Please, select the task  you're interested in from the list below:
            - 1.Task_1 ('Задача 41').
            - 2.Task_2 ('Задача 43').");
            Console.WriteLine("Please, type in a target Task number: ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Aufgaben.Aufgabe41();
                    break;
                case 2:
                    Aufgaben.Aufgabe43();
                    break;
                default:
                    Console.WriteLine("Please, select from the options provided!");
                    TaskSelector();
                    break;
            }
        }
    }

    class Aufgaben
    {
        void Aufgabe41()
        {
        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 3
            Console.WriteLine("GB C# Homework. Stage 6, Task 1 ('Задача 41').");
            // Получаем на вход массив и конвертируем его в нужный нам формат:
            int [] Eingang = Array.ConvertAll(Service.ArrayFillerSelector(), s => int.Parse(s));

            Console.WriteLine($"Your array is ({string.Join(",", Eingang)}).");
            Console.WriteLine($"Your array consists of {Eingang.Count()} numbers.");
            Service.Zahlen41(Eingang);
        }


        void Aufgabe43()
        {
        // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
        // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
            // Принимаем введённые пользователем координаты:
            Console.WriteLine("GB C# Homework. Stage 6, Task 2 ('Задача 43').");
            (double b1, double k1) SatzKoordinatenA = Service.KoordinatenA43();
            (double b2, double k2) SatzKoordinatenB = Service.KoordinatenB43();
        
            // Выводим введённые пользователем координаты:
            Console.WriteLine($"Straight line A coordinates: {SatzKoordinatenA}.");
            Console.WriteLine($"Straight line B coordinates: {SatzKoordinatenB}.");

            // Чтоб не нагружать систему, сразу на входе проверяем, что прямые не параллельны и не совпадают:
            if (SatzKoordinatenA.b1 == SatzKoordinatenB.b2 && SatzKoordinatenA.k1 == SatzKoordinatenB.k2) Console.WriteLine("Straight lines matched.");
            else if (SatzKoordinatenA.k1 == SatzKoordinatenB.k2) Console.WriteLine("Straight lines are parallel.");

            else
            // Если прямые не параллельны и не совпали, то рассчитываем и выводим координаты точки пересечения:
            {
            double SchnittKoordinatenX = (SatzKoordinatenB.b2 - SatzKoordinatenA.b1) / (SatzKoordinatenA.k1 - SatzKoordinatenB.k2);
            double SchnittKoordinatenY = SatzKoordinatenA.k1 * SchnittKoordinatenX + SatzKoordinatenA.b1;
            Console.WriteLine($"Straight lines A & B intersection point coordinates are: {SchnittKoordinatenX}, {SchnittKoordinatenY}.");
            }
        }
    }


    class Service
    {
            // Меню выбора режима ввода массивов - ручного или автоматического
        public static string[] ArrayFillerSelector()
        {
            Console.WriteLine("We're kindly asking you to choose desired array formation type.");
            Console.WriteLine("Please, type in 'r' to open an robot array filler ('RAF') or 'm' to use manual ('MAF') shell:");
            var income = Convert.ToString(Console.ReadLine());
            if(income == "r")
            {
                return RobotAutomaticFiller(); // Оболочка робота для автоматического заполнения массивов
            }
            else if (income == "m") return ManualFillerShell(); // Оболочка заполнения массивов вручную
            else
            {
                Console.WriteLine("Please, select from the options provided!");
                return ArrayFillerSelector();
            }
        }

            // Этот робот заполняет массив случайными числами.
        public static string[] RobotAutomaticFiller()
        {
            Console.WriteLine("The RAF Robot provides you with an array of random prime numbers.");
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
            
            // Оболочка ручного заполнения массива. Отсюда можно вернуться назад или начать заполнять массив.
        public static string[] ManualFillerShell()
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
        public static string[] ManualArrayFiller()
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
            
            // Получаем координаты для первого отрезка за задачи 43
        public static (double b1, double k1) KoordinatenA43()
        {
            Console.WriteLine("Please, type in coordinates for the straight line A.");
            
            Console.WriteLine("Please, type in 'b' coordinates for the straight line A:");
            var b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, type in 'k' coordinates for the straight line A:");
            var k1 = Convert.ToDouble(Console.ReadLine());

            (double, double) ReiheA43 = (b1, k1);
            return ReiheA43;
        }

            // Получаем координаты для второго отрезка за задачи 43
        public static (double b2, double k2) KoordinatenB43()
        {
            Console.WriteLine("Please, type in coordinates for straight line B.");

            Console.WriteLine("Please, type in 'b' coordinates for the straight line B:");
            var b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, type in 'k' coordinates for the straight line B:");
            var k2 = Convert.ToInt32(Console.ReadLine());

            (double, double) ReiheB43 = (b2, k2);
            return ReiheB43;
        }

            // Метод обработки входящего массива для задачи 41. Обрабатывает положительные и отрицательные числа и выдаёт результат
        public static void Zahlen41(int [] Eingang)
        {
            // Положительные числа
            int [] PositiveZahlen = new int [Eingang.Length]; //создаём массив-аккумулятор для сбора положительных чисел
            for(int i = 0; i < PositiveZahlen.Length; i++) 
            {
                PositiveZahlen[i] = -1; // Назначаем всем элементам аккумулятора значение -1;
            }

            for (int e = 0; e < Eingang.Length; e++) // Циклом выбираем из входящего массива все положительные
            {
                if(Eingang[e] > 0) PositiveZahlen[e] = Eingang[e]; // И вот таким образом сохраняем в аккумулятор
            }

            int menge = 0; // количество положительных чисел в аккумуляторе
            for (int f = 0; f < PositiveZahlen.Length; f++)
            {
                if (PositiveZahlen[f] != -1) menge++;
            }

            int [] NeuePositiveZahlen = new int[menge]; // Результирующий массив для положительных
            int a = 0;
            for (int i = 0; i < PositiveZahlen.Length; i++)
            {
                if (PositiveZahlen[i] != -1)
                {
                    NeuePositiveZahlen[a] = PositiveZahlen[i];
                    a++;
                }
            }
            int [] PositiveList = NeuePositiveZahlen;


            // Отрицательные числа
            int [] NegativeZahlen = new int [Eingang.Length]; //создаём массив-аккумулятор для сбора отрицательных чисел
            for(int i = 0; i < NegativeZahlen.Length; i++) 
            {
                NegativeZahlen[i] = -1; // Назначаем всем элементам аккумулятора значение -1;
            }

            for (int e = 0; e < Eingang.Length; e++) // Циклом выбираем из входящего массива все отрицательные
            {
                if(Eingang[e] < 0) NegativeZahlen[e] = Eingang[e]; // И вот таким образом сохраняем в отрицательный аккумулятор
            }

            int un_menge = 0; // Количество отрицательных
                for (int uf = 0; uf < NegativeZahlen.Length; uf++)
            {
                if (NegativeZahlen[uf] != -1) un_menge++;
            }

            int [] NeueNegativeZahlen = new int[un_menge]; // Результирующий массив для отрицательных
                int b = 0;
            for (int i = 0; i < NegativeZahlen.Length; i++)
            {
                if (NegativeZahlen[i] != -1)
                {
                    NeueNegativeZahlen[b] = NegativeZahlen[i];
                    b++;
                }
            }
            int [] NegativeList = NeueNegativeZahlen;


            // Обработка '0'
            int [] NullZahlen = new int [Eingang.Length]; //создаём массив-аккумулятор для сбора '0'
            for(int i = 0; i < NullZahlen.Length; i++) 
            {
                NullZahlen[i] = -1; // Назначаем всем элементам аккумулятора значение -1;
            }

            for (int e = 0; e < Eingang.Length; e++) // Циклом выбираем из входящего массива все нули
            {
                if(Eingang[e] == 0) NullZahlen[e] = Eingang[e]; // И вот таким образом сохраняем в нулевой аккумулятор
            }

            int null_menge = 0; // Количество нолей
            for (int uf = 0; uf < NullZahlen.Length; uf++)
            {
                if (NullZahlen[uf] != -1) null_menge++;
            }

            int [] NeueNullZahlen = new int[null_menge]; // Результирующий массив для нолей
            int d = 0;
            for (int i = 0; i < NullZahlen.Length; i++)
            {
                if (NullZahlen[i] != -1)
                {
                    NeueNullZahlen[d] = NullZahlen[i];
                    b++;
                }
            }
            int [] ZeroList = NeueNullZahlen;


            Console.WriteLine($"Positive numbers are: ({string.Join(",", PositiveList)}), {PositiveList.Count()} in total.");
            Console.WriteLine($"Negative numbers are: ({string.Join(",", NegativeList)}), {NegativeList.Count()} in total.");
            Console.WriteLine($"{ZeroList.Count()} zeros in total.");
        }
    }
}
//Конец программы