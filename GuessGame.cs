public class GuessGame
{
    public static void Run()
    {
     

Random random = new Random();
int secretNumber = random.Next(1, 101);
int attempts = 0;
int guess = 0;

Console.WriteLine("число от 1 до 100 ,угадай");

while (true)
{
    Console.WriteLine("твое число: (0 - выйти из игры)");
    try
    {
        guess = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("это не число число");
        continue;
    }

    attempts++;

    if (guess == 0)
    {
        break;
    }

    if (guess > secretNumber)
    {
        Console.WriteLine("это много ,меньше");
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("это мало ,больше");
    }
    else
    {
        Console.WriteLine("ты угадал ,ты потратил попыток:" + attempts);
        break;
    }
}
        Console.WriteLine("Калькулятор запущен...");
    }
}