public class Tuples
{
    public static void Run()
    {
        Console.WriteLine("Enter the no of Tuples");
        int n = Convert.ToInt32(Console.ReadLine());
        var tuples = new List<(int, int)>();
        while (n-- > 0)
        {
            Console.WriteLine("Enter the first number of the tuple:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number of the tuple:");
            int second = Convert.ToInt32(Console.ReadLine());
            tuples.Add((first, second));
            Console.WriteLine($"Tuple (first Tuple: {first}, second Tuple: {second}, Total Tuples: {tuples.Count}, Remaining: {n}) added.");
        }
    }
}