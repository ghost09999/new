public class Calculator
{
    public static void Run()
    {
        int a;
int b;


while (true)
{
    Console.WriteLine("введите первое число: (или 0, чтобы выйти)");
    try 
    {
        a = Convert.ToInt32(Console.ReadLine());
    } 
    catch 
    {
        Console.WriteLine("это не число");
        continue;
    }
    if (a == 0)
    {
        break;
    }

    Console.WriteLine("введите второе число: (или 0, чтобы выйти)");
    try
    {
        b = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("нужно число");
        continue;
    }
    if (b == 0)
    {
        break;
    }
    int summa = a + b;

    Console.WriteLine("сумма:" + summa);

    int minus = a - b;
    int umnozit = a * b;
    double delit = (double) a / b;

    Console.WriteLine("вычитание: " + minus);
    Console.WriteLine("умножение: " + umnozit);
    Console.WriteLine("деление: " + delit);
}
    }
}

