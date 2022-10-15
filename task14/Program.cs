// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
// нужно чтобы вводились две переменные пользователем x и y, и сделать условие на каждую четверть

Console.Clear();
Console.WriteLine("Введите X: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("1");
// }

// if (X < 0 && Y > 0)
// {
//     Console.WriteLine("2");
// }

// if (X < 0 && Y < 0)
// {
//     Console.WriteLine("3");
// }
// if (X > 0 && Y < 0)
// {
//     Console.WriteLine("4");
// }


if (X > 0 )
{
    if (Y > 0)
    Console.WriteLine("1");
    else 
    Console.WriteLine("4");
}
if (X < 0)
{
    if(Y > 0)
    Console.WriteLine("2");
    else
    Console.WriteLine("3");
}




