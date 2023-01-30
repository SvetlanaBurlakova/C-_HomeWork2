// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int number=Convert.ToInt32(Console.ReadLine());

bool ThirdDigit(int number)
{
    if (number/100>0)
        {
            return true;  
        }
    else return false;
}
bool thirdDigit=ThirdDigit(number);

if (thirdDigit==false) Console.WriteLine("Третьей цифры нет");
else {
    int numberForCycle=number;
    while (numberForCycle/100>10) numberForCycle=numberForCycle/10;
    Console.WriteLine($"третья цифра от числа {number} равна {numberForCycle%10}");
}