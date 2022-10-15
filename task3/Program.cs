// Написать программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите два числа: "); // ввести подряд два числа с новой строчки 

int numberA = Convert.ToInt32(Console.ReadLine()); // число один

int numberB = Convert.ToInt32(Console.ReadLine()); // число два


if (numberA*numberA == numberB)  
{
    Console.Write("Второе число является квадратом первого: " );
}
else
{
    Console.Write("Второе число НЕ является квадратом первого: " );
}

