﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

int i = 2; // шаг в 2, тк четные


 if ( N > 1) // тк четные числа до единицы

 {
     while ( i <= N) // наше число больше или равно шагу в 2

   {
       Console.Write(i + " ");
       i += 2;
    } 
 }

     else 
   {
       Console.WriteLine("Попробуйте еще раз. Число меньше или равно единицы");
    }




