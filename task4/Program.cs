// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

if( n > 0 && n <= 7)
{
    if (n == 1) Console.Write("Monday: ");
    if (n == 2) Console.Write("Tuesday: ");
    if (n == 3) Console.Write("Wednesday: ");
    if (n == 4) Console.Write("Thursday: ");
    if (n == 5) Console.Write("Friday: ");
    if (n == 6) Console.Write("Satuday: ");
    if (n == 7) Console.Write("Sunday: ");
}

else 
{
    Console.WriteLine("Попробуйте еще раз, введите число от 1 до 7: ");
}
   