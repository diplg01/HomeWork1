﻿// задание 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число => ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);
if (A%2 == 0) Console.Write($"Число {A} четное");
else 
Console.WriteLine($"Число {A} не четное");