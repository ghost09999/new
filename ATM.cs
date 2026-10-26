public class ATM
{
    public static void Run()
    {
       int balance = 1000;

while(true)
{
    Console.WriteLine("1 - узнать баланс");
    Console.WriteLine("2 - снять деньги");
    Console.WriteLine("0 - выйти из игры");
    Console.WriteLine("Выберите действие: ");


int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 0)
{
    break;
}
if (choice == 1)
{
    Console.WriteLine("Ваш баланс: " + balance);
}
else if (choice == 2)
{
    Console.WriteLine("Сколько снять?");
    int sum = Convert.ToInt32(Console.ReadLine());

    if (sum > balance)
    {
        Console.WriteLine("Баланса не хватает");
    }
    else
    {
        balance = balance - sum;
        Console.WriteLine("Остаток: " + balance);
    }
}
else
{
    Console.WriteLine("Нужны цифры!");
}

}
     
    }
}
