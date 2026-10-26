while (true)
{
    Console.WriteLine("1 - Калькулятор");
    Console.WriteLine("2 - Игра Угадай число");
    Console.WriteLine("3 - Банкомат");
    Console.WriteLine("Выбери прогу:");
    
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Calculator.Run();
    }
    else if (choice == 2)
    {
        GuessGame.Run();
    }
    else if (choice == 3)
    {
        ATM.Run();
    }
}