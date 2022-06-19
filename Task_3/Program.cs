/* Написать программу, показывающую первые N чисел, для которых каждое следущее равно
сумме двух предыдущих. Первые два элемента последовательности задаются пользователем*/

void NextIsSumTwoPrev(int first, int second, int n)
{
    if (n==0) return;
    Console.Write($"{first+second} ");
    int temp=first;
    first=second;
    second+=temp;
    NextIsSumTwoPrev(first,second,n-1);
}

Console.Clear();
Console.Write("Enter your first number: ");
int a=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your second number: ");
int b=int.Parse(Console.ReadLine()??"0");
Console.Write("Enter your amount of numbers: ");
int n=int.Parse(Console.ReadLine()??"0");
Console.Write($"{a} {b} ");
NextIsSumTwoPrev(a,b,n);
