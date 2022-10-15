//  Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.WriteLine("Введите четверть: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("X>0;Y>0");
}
if (number ==2)
{
    Console.WriteLine("X<0;Y>0");
}
if (number ==3)
{
    Console.WriteLine("X<0;Y<0");
}
if (number ==4)
{
    Console.WriteLine("X>0;Y<0");
}
