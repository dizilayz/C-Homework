/*Эльвира: 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
Эльвира: 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    int N = number* -1;
    while (N <= number)
    {
        Console.Write(N);
        Console.Write(", ");
        N = N + 1;

    }
}
else 
{
    int N = number;
    while (N <= number*-1)
    {
        Console.Write(N);
        Console.Write(", ");
        N = N + 1;;
    }
}