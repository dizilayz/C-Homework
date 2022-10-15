//  Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите коррдинату x точки A");
double ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y точки A");
double ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x точки B");
double bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y точки B");
double by = int.Parse(Console.ReadLine());

//Math.Sqrt - квадратный корень, Math.Pow(a,2) - возведение в степень(2 - степень, в которую будет возводиться числo)
double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));

//Math.Round(a,2 ) - округление до сотых после запятой

Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(result, 2)}");



