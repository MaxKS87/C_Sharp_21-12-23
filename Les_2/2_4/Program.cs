﻿// 4. Напишите программу, которая выводит третью с конца
//    цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine ());

if (num >= 100)
{
    int res = num / 100 % 10;
    Console.Write("Третья с конца цифра числа - " + res + "\n");
}
else
    Console.Write("Вы ввели число меньше ста.\nВ нём либо одна, либо две ЗНАЧИМЫЕ цифры\n");