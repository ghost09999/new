public class PasswordGen
{
    public static void Run()
    {
        string allsmbl = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
        string password = "";
        int length = 10;

        Random rnd = new Random();
        for (int i = 0; i < length; i++)
{
    int index = rnd.Next(0,allsmbl.Length);
    char symbol = allsmbl[index];
    password += symbol;
}
Console.WriteLine("Твой пароль: " + password);
    }
}