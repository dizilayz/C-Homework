﻿// /*Эльвира: 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8*/



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{


    int lastnumber = number % 10;
    if (lastnumber < 0)
    {
        lastnumber = lastnumber * -1;
    }
    Console.WriteLine(lastnumber);

}
else
{
    Console.WriteLine("Введено некорректное значение");

}

