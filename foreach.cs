public class FavoriteApps
{
    public static void Run()
    {
        Console.WriteLine("Enter the names of 4 favourite apps:");
        string[] apps = new string[4];
        for (int i = 0; i < apps.Length; i++)
        {
            Console.Write($"App {i + 1}: ");
            apps[i] = Console.ReadLine() ?? string.Empty;
        }

        Console.WriteLine("Your favourite apps are:");
        foreach (string app in apps)
        {
            Console.WriteLine(app);
        }
    }
}