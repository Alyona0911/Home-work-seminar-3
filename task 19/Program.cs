﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int lenght  = number.Lenght;

if (lenght == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 Console.WriteLine($"{number} - Палиндром");
    }
 else
    {
 Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
 Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}





