// Найти сумму цифр числа при помощи рекурсии
int SumDigOfNumb(int number)
{
    if (number==0) return 0;
    else return number%10+SumDigOfNumb(number/10);
}

Console.Clear();
Console.Write("Enter your number: ");
int a=int.Parse(Console.ReadLine()??"0");
Console.WriteLine($"{SumDigOfNumb(a)}");
