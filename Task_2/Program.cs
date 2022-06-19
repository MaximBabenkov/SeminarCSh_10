// Написать программу возведения числа A в целую степень B при помощи рекурсии
int PowerOfNumb(int number, int power)
{
    if (power==0) return 1;
    else return number*PowerOfNumb(number,power-1);
}

Console.Clear();
Console.Write("Enter your number: ");
int a=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your power of number: ");
int b=int.Parse(Console.ReadLine()??"0");
Console.WriteLine($"Number {a} raised to the {b}th power: {PowerOfNumb(a,b)}");
