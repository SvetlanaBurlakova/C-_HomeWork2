// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int number=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"вторая цифра от числа {number} равна {(number/10)%10}");
