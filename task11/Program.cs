﻿//  12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Error!, 0!!!");
    return;
}

if (b % a == 0)
{
    Console.WriteLine("кратно");
}
 else {
    int result = b % a;
    Console.WriteLine($"не кратно, остаток {result}");

 }