// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine ("Программа для определения палиндрома. V 1.0");

Console.WriteLine ("Введите любое пятизначное число");

string five_gigit_num = Console.ReadLine();
int num1 = Convert.ToInt32(five_gigit_num);

if (num1>9999 && num1<99999)
{
if ((five_gigit_num[0]==five_gigit_num[4])&&(five_gigit_num[1]==five_gigit_num[3]))
{
Console.WriteLine ("ДА, это ПОЛИНДРОМ");
}
    else 
    {
        Console.WriteLine ("НЕТ, это  не ПОЛИНДРОМ");
    }
}
else 
{
    Console.WriteLine ("ОШИБКА программы. Введите все-таки пятизначное число!");
}
