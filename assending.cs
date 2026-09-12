public class assending
{
    public static void Run()
    {
        Console.WriteLine("enter the assending numbers");
        Console.WriteLine("Enter the array size:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        if (numbers == null)
        {
            Console.WriteLine("The number is null.");
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);
            Console.WriteLine("The numbers in ascending order are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}