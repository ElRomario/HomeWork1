 
 
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int maxInt(int a, int b, int c)
{
        int max = a;
       if(max<b)max = b;
       if(max<c)max = c;
        return max;
}  
int inputInt()
{
   Console.WriteLine("Введите число:");
   int number = int.Parse(Console.ReadLine());
   return number;
}

int a = inputInt();
int b = inputInt();
int c = inputInt();
int max = maxInt(a, b, c);
Console.WriteLine($"Максимальное число среди {a} {b} и {c} - {max}"); 
