// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine ("Программа для расчета кубов ряда чисел от 1 до N. V 1.0");

Console.WriteLine ("Введите целое число N");
int n = Convert.ToInt32(Console.ReadLine());

int count =1;

while (count<=n)
{
    Console.WriteLine(count*count*count);
    // Console.Write( );
    count++;
}