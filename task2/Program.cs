
// 5 Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Math.Abs((Convert.ToInt32(Console.ReadLine())));
if (num > 99 && num <= 999)
{
    Console.Write("Последняя цифра: " + num % 10);
}
else
{
    Console.WriteLine("Введенное число не трехзначное");
}
