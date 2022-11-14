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
                    Aufgaben.Aufgabe64();
                    break;
                case 2:
                    Aufgaben.Aufgabe66();
                    break;
                case 3:
                    Aufgaben.Aufgabe68();
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
        public static void Aufgabe64()
        {
            Console.WriteLine("GB C# Homework. Stage 9, Task 1 ('Задача 64').");
            // Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
            // Выполнить с помощью рекурсии.
            // N = 5 -> "4, 2"
            // N = 8 -> "8, 6, 4, 2,"
            Console.WriteLine("Please, enter the target number: ");
            int N = Numbers.Nummer();
            Console.WriteLine($"Even numbers from N to 1 are:");
            Service.EvenNumber(N);
        }

        public static void Aufgabe66()
        {
            Console.WriteLine("GB C# Homework. Stage 9, Task 2 ('Задача 66').");
            // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            // M = 1; N = 15 -> 120
            // M = 4; N = 8. -> 30
            Console.WriteLine(@"Please, enter two target numbers
            Please, enter number A: ");
            int M = Numbers.Nummer();
            Console.WriteLine("Please, enter number B: ");
            int N = Numbers.Nummer();

            Console.Write(@$"Your first number is: {M}, your second number is {N}.
            The final summ is: ");
            
            int zeitv = M;
            if (M > N)
            {
                 M = N;
                 N = zeitv;
            }

            Service.AllesZusammenfassen(M, N, zeitv = 0);
        }

        public static void Aufgabe68()
        {
            Console.WriteLine("GB C# Homework. Stage 9, Task 3 ('Задача 68').");
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            // m = 2, n = 3 -> A(m,n) = 9
            // m = 3, n = 2 -> A(m,n) = 29
            Console.WriteLine(@"Please, enter two target numbers
            Please, enter number A: ");
            int m = Numbers.Nummer();
            Console.WriteLine("Please, enter number B: ");
            int n = Numbers.Nummer();
            
            Console.Write(@$"Your first number is: {m}, your second number is {n}.
            The Akkerman function result is: ");
            int result = Service.Akkerman(m, n);
            Console.WriteLine($"{result}");
        }
    }

    class Numbers
    {
        public static int Nummer()
        {
            int nummer = Convert.ToInt32(Console.ReadLine());
            if (nummer < 0)
            {
                Console.WriteLine("Please, enter a positive integer!");
                Nummer();
            }
            return nummer;
        }
    }

    class Service
    {
        public static void EvenNumber(int N)
        {
            if (N % 2 == 0) Console.Write($"{N}; ");
            if (N > 1)
                {
                    int mittel = N - 1;
                    EvenNumber(mittel);
                }
        }

        public static void AllesZusammenfassen(int M, int N, int summe)
        {
            summe = summe + N;
            if (N <= M)
            {
                Console.Write($"{summe}");
                return;
            }
            AllesZusammenfassen(M, N - 1, summe);
        }

        public static int Akkerman(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
            else return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}
//Конец программы