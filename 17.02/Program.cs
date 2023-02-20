// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//Task1

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Task1");
        Console.WriteLine();

        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt16(Console.ReadLine());

        if (a > b) Console.WriteLine("a > b");
        else if (b > a) Console.WriteLine("b > a");
        else if (a == b) Console.WriteLine("a == b");

        //Task2

        Console.WriteLine("Введите первое число:");
        int с = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int d = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите третье число:");
        int e = Convert.ToInt16(Console.ReadLine());

        int max = a;

        if (b > a) max = b;
        else if (b > c) max = c;
    }
}