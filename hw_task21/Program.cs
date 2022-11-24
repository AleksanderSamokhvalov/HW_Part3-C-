// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Программа для определения расстояния между точками в 3D пространстве. V 1.0");

Console.WriteLine ("Введите координату первой точки Х1");
int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (x);

Console.WriteLine ("Введите координату первой точки Y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату первой точки Z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату второй точки Х2");
int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (x);

Console.WriteLine ("Введите координату второй точки Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату первой точки Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt (Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.WriteLine ("Длинна отрезка = " + result);
