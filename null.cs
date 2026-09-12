public class Null
{
    public void Run()
    {
        Console.WriteLine("Enter the first number of the Number:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number of the Number:");
        int second = Convert.ToInt32(Console.ReadLine());
        if (first == null || second == null)
        {
            Console.WriteLine("The number is null.");
        }
        else
        {
            Console.WriteLine($"The number is: {first}, {second}");
        }
    }
}