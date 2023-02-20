// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
void print(int i, int max)
{
if(i == 0) Console.Write("[");
else Console.Write(", ");
Console.Write(i);
if(i==max || i==max-1) Console.Write("]");
}
void allEven(int num)
{
    int i =0;
    while(i<=num)
    {
        print(i, num);
        i+=2;
    }
}
allEven(122);