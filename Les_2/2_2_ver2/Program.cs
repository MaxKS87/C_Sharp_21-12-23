﻿// 2. Напишите программу, которая принимает на вход трёхзначное
//    число и возводит вторую цифру этого числа в степень, равную
//    третьей цифре.
// Второй вариант решения.

Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine()!);
int n3 = n % 10;
int n2 = n / 10 % 10;
Console.WriteLine(Math.Pow(n2, n3));