﻿// задание 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 44;
int b = 5;
int c = 78;

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine(max);