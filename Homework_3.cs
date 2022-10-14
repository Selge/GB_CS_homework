Console.WriteLine("GB C# Homework. Stage 3.");

Console.WriteLine("Homework_3. Task_1 ('Задача 10')");
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void Palindrome()
{
Console.WriteLine("Please type in a 5-digit number: ");
var incoming = Console.ReadLine();
int changed = Convert.ToInt32(incoming);
char[] converted = incoming!.ToCharArray();

if (changed > 0 && converted.Length > 4)
{
Array.Reverse(converted);
string reversed = new String(converted);
if (incoming == reversed) Console.WriteLine($"Your number {incoming} is a palindrome.");
else Console.WriteLine($"Your number {incoming} is not a palindrome. {incoming} is not equal to {reversed}.");
}

else
{
    Console.WriteLine("Please, enter a positive 5-digit integer!");
    Palindrome();
}
}

Palindrome();


Console.WriteLine("Homework_3. Task_2 ('Задача 21')");
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Please, type in three (X, Y, Z) coordinates for points A and B.");

(int, int, int) CoordinatesA()
{
    Console.WriteLine("Please, type in X coordinates of the point A:");
    var xA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, type in Y coordinates of the point A:");
    var yA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, type in Z coordinates of the point A:");
    var zA = Convert.ToInt32(Console.ReadLine());

    (int, int, int) arrA = (xA, yA, zA);
    return arrA;
}

(int, int, int) CoordinatesB()
{
    Console.WriteLine("Please, type in X coordinates of the point B:");
    var xB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, type in Y coordinates of the point B:");
    var yB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, type in Z coordinates of the point B:");
    var zB = Convert.ToInt32(Console.ReadLine());

    (int, int, int) arrB = (xB, yB, zB);
    return arrB;
}

void Distance((int, int, int) A, (int, int, int) B)
{
    Console.WriteLine("Coordinates of the point A:");
    Console.WriteLine(A);
    Console.WriteLine("Coordinates of the point B:");
    Console.WriteLine(B);

    var arr_A = A;
    var arr_B = B;

    var distance = Math.Sqrt((arr_A.Item1 - arr_B.Item1) *  (arr_A.Item1 - arr_B.Item1) + (arr_A.Item2 - arr_B.Item2) *  (arr_A.Item2 - arr_B.Item2) + (arr_A.Item3 - arr_B.Item3) *  (arr_A.Item3 - arr_B.Item3));
    Console.WriteLine($"The distance between points A and B is: {Math.Round(distance, 2)}.");
}

Distance(CoordinatesA(), CoordinatesB());


Console.WriteLine("Homework_3. Task_3 ('Задача 23').");
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Number()
{
    Console.WriteLine("Please type in a number: ");
    var income = Console.ReadLine();
    var N = Convert.ToInt32(income);
    return N;
}

void Cube(int N)
{
    Console.WriteLine($"Your number is: {N}");
    Console.WriteLine($"Numbers from 1 to {N} cubed:");
    for (int number = 1; number <= N; number++)
    {
        var result = number*number*number;
        string f_result = string.Format("{0:# ### ###}", result);
        Console.WriteLine($"{number}^3 = {f_result}");
    }
}

Cube(Number());