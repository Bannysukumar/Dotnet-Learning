public class WhileLoop
{
    public static void Run()
    {
        Console.WriteLine("Enter a number to count down from:");
        int counter = int.Parse(Console.ReadLine() ?? "0");
        while (counter > 0)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}