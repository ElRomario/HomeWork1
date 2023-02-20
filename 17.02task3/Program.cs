// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int inputInt()
{
    Console.WriteLine("введите число:");
    int number = int.Parse(Console.ReadLine());
    return number;
}
bool evenRodd(int num)
{
    if( num % 2 == 0)return true;
    else
    return false;
    
}
int a = inputInt();
switch(evenRodd(a))
{
    case true: Console.WriteLine("Данное число чётно");
    break;
    case false: Console.WriteLine("Данное число нечётно");
    break;
}