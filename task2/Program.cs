/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

Console.WriteLine("Введите номер: ");
int numberWeek = int.Parse(Console.ReadLine());






if (numberWeek > 1 || numberWeek < 7)
{
    Console.WriteLine("Введено неправильное значение");
}

if (numberWeek == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberWeek == 2)
{
    Console.WriteLine("Вторник");
}
if (numberWeek == 3)
{
    Console.WriteLine("Среда");
}
if (numberWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (numberWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (numberWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (numberWeek == 7)
{
    Console.WriteLine("Воскресенье");
}

