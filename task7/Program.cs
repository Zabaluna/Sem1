﻿//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: "); // ввести подряд два числа с новой строчки 

int a = Convert.ToInt32(Console.ReadLine()); // число один

int b = Convert.ToInt32(Console.ReadLine()); // число два

int c = Convert.ToInt32(Console.ReadLine()); // число три

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("Максимальное число: " + max);

