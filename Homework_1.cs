namespace Homework_1
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
            Console.WriteLine("GB C# Homework. Stage 1.");
            Console.WriteLine(@"Please, select the task  you're interested in from the list below:
            - 1.Task_1 ('Задача 2').
            - 2.Task_2 ('Задача 4').
            - 3.Task_3 ('Задача 6').
            - 4.Task_4 ('Задача 8').");
            
            Console.WriteLine("Please, type in a target Task number: ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Aufgaben.Aufgabe2();
                    break;
                case 2:
                    Aufgaben.Aufgabe4();
                    break;
                case 3:
                    Aufgaben.Aufgabe6();
                    break;
                case 4:
                    Aufgaben.Aufgabe8();
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
        public static void Aufgabe2()
        {
            // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            // a = 5; b = 7 -> max = 7
            // a = 2 b = 10 -> max = 10
            // a = -9 b = -3 -> max = -3
            Console.WriteLine("Homework_1. Task_1.");
            Console.Write ("Please enter number A: ");
            var a = Console.ReadLine();
            Console.Write ("Please enter number B: ");
            var b = Console.ReadLine();
            int num_a = Convert.ToInt32(a);
            int num_b = Convert.ToInt32(b);
            int max_1 = 0;
            if(num_a > num_b)
            {
                max_1 = num_a;
            }
            else{
                max_1 = num_b;
            }
            Console.WriteLine($"Max number is {max_1}");
        }

        public static void Aufgabe4()
        {
            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            // 2, 3, 7 -> 7
            // 44 5 78 -> 78
            // 22 3 9 -> 22
            Console.WriteLine("Homework_1. Task_2. Type_1.");
            Console.Write ("Please enter number D: ");
            var d = Console.ReadLine();
            Console.Write ("Please enter number E: ");
            var e = Console.ReadLine();
            Console.Write ("Please enter number F: ");
            var f = Console.ReadLine();
            int num_d = Convert.ToInt32(d);
            int num_e = Convert.ToInt32(e);
            int num_f = Convert.ToInt32(f);
            int max_2 = num_e > num_d ? num_e : num_d; // использование тернарного оператора
            max_2 = max_2 > num_f ? max_2 : num_f; 
            Console.WriteLine($"Max number is {max_2}");

            Console.WriteLine("Homework_1. Task_2. Type_2.");
            Console.Write ("Please enter number D: ");
            var d1 = Console.ReadLine();
            Console.Write ("Please enter number E: ");
            var e1 = Console.ReadLine();
            Console.Write ("Please enter number F: ");
            var f1 = Console.ReadLine();
            int num_d1 = Convert.ToInt32(d1);
            int num_e1 = Convert.ToInt32(e1);
            int num_f1 = Convert.ToInt32(f1);
            int [] array_1 = {num_d1, num_e1, num_f1};
            int max_21 = array_1.Max();
            Console.WriteLine($"Max number is {max_21}");
        }

        public static void Aufgabe6()
        {
            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            // 4 -> да
            // -3 -> нет
            // 7 -> нет
            Console.WriteLine("Homework_1. Task_3.");
            Console.Write ("Please enter number AB: ");
            var ab = Console.ReadLine();
            int num_ab = Convert.ToInt32(ab);
            if(num_ab % 2 == 0)
            {
                Console.WriteLine($"{ab} is an even number");
            }
            else
            {
                Console.WriteLine($"{ab} is an odd number");
            }
        }

        public static void Aufgabe8()
        {
            // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            // 5 -> 2, 4
            // 8 -> 2, 4, 6, 8
            Console.WriteLine("Homework_1. Task_4.");
            Console.Write ("Please enter number N: ");
            var N = Console.ReadLine();
            int num_N = Convert.ToInt32(N);
            int start = 1;
            var list = new int[] {};
            while(start <= num_N)
            {
                if(start % 2 == 0)
                {
                    Console.Write("{0} ", start);
                    start++;
                }
                else{
                    start++;
                }
            }
        }
    }
}