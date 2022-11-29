namespace Homework_4
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
            Console.WriteLine("GB C# Homework. Stage 4.");
            Console.WriteLine(@"Please, select the task  you're interested in from the list below:
            - 1.Task_1 ('Задача 25').
            - 2.Task_2 ('Задача 27').
            - 3.Task_3 ('Задача 29').");
            Console.WriteLine("Please, type in a target Task number: ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    Aufgaben.Aufgabe25();
                    break;
                case 2:
                    Aufgaben.Aufgabe27();
                    break;
                case 3:
                    Aufgaben.Aufgabe29();
                    break;
                default:
                    Console.WriteLine("Please, select from the options provided!");
                    TaskSelector();
                    break;
            }
        }
    }

    class Service
    {
        public static int Number()
        {
            Console.WriteLine("Please type in your target number: ");
            var income = Console.ReadLine();
            int N = Convert.ToInt32(income);
            return N;
        }
    }

    class Aufgaben
    {
        public static void Aufgabe25()
        {
            Console.WriteLine("GB C# Homework #4: Task_1 ('Задача 25').");
            // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            // 3, 5 -> 243 (3⁵)
            // 2, 4 -> 16
            void MathDegree()
            {
                var A = Service.Number();
                var B = Service.Number();
                int number = 1;
                for (int i=1;i<=B;i++) 
                {
                    number *= A;   
                }
                string f_result = string.Format("{0:# ### ###}", number);
                Console.WriteLine($"Your target number is: {A}.");
                Console.WriteLine($"Your degree number is: {B}.");
                Console.WriteLine($"{A}^{B} = {f_result}");
            }

            MathDegree();
        }

        public static void Aufgabe27()
        {
            Console.WriteLine("GB C# Homework #4: Task_2 ('Задача 27').");
            // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            // 452 -> 11
            // 82 -> 10
            // 9012 -> 12
            void Summary()
            {
                var number = Service.Number();
                Console.WriteLine($"Your start number is: {number}");
                int summ = 0;
                while (number > 0)
                {
                    summ += number%10;
                    number /= 10;
                }
                Console.WriteLine($"Your final number is: {summ}");
            }

            Summary();
        }

        public static void Aufgabe29()
        {
            Console.WriteLine("GB C# Homework #4: Task_3 ('Задача 29').");
            // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            // 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
            // 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]
            int [] Massive()
            {
                Console.WriteLine("Please, choose desired array formation type.");
                Console.WriteLine("Please, type in 'a' to create an array automatically or 'm' to put in the numbers manually:");
                var income = Convert.ToString(Console.ReadLine());
                Console.WriteLine($"You have chosen {income}");

                if(income == "a")
                {
                    Console.WriteLine("Please, type in desired array length:");
                    var t_length = Console.ReadLine();
                    var c_length = Convert.ToInt32(t_length);

                    int [] mass = new int[c_length];
                    Random chisla = new Random();
                    for (int i = 0; i < mass.Length; i++)
                    {
                        mass[i] = chisla.Next(-100, 100);
                    }
                    return mass;
                }

                else if(income == "m")
                {
                    Console.WriteLine("Please, type in desired length of array:");
                    int new_length = Convert.ToInt32(Console.ReadLine());
                    // int new_length = int.Parse(Console.ReadLine());
                    int [] mass = new int[new_length];
                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.WriteLine($"Please, type in a {i} number of your array:");
                        mass[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    return mass;
                }

                else
                {
                    Console.WriteLine("Please, select from the two options provided!");
                    return Massive();
                }  
            }

            void Print(int[] mass)
            {
                int [] income = mass;
                Console.WriteLine($"Here's your array: ({string.Join(",", income)}).");
            }

            Print(Massive());
        }
    }
}