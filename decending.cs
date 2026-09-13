public class Decending
{
    public static void Run()
    {
        Console.WriteLine("Enter a list of numbers separated by commas:");
        int [] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        Array.Sort(numbers);
        Array.Reverse(numbers);
        Console.WriteLine("The numbers in descending order are:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}