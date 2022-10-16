//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа: "); // ввести подряд два числа с новой строчки 

int a = Convert.ToInt32(Console.ReadLine()); // число один

int b = Convert.ToInt32(Console.ReadLine()); // число два

if( b > a) 
{
     Console.WriteLine("Наибольшее число: " + b);
     Console.WriteLine("Наименьшее число: " + a);
}
else 
{
     Console.WriteLine("Наибольшее число: " + a);
     Console.WriteLine("Наименьшее число: " + b);
}

// int a = new Random().Next(); // -n ...n   тут комп уже сам выдает рандом. оставить для др задач, чтоб не забыть
// Console.WriteLine(a);
// int b = new Random().Next();
// Console.WriteLine(b);



