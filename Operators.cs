public class Operators
{
    public static void Run()
    {
        Console.WriteLine("Enter your first number:");
        if (!int.TryParse(Console.ReadLine(), out int first))
        {
            Console.WriteLine("Invalid first number.");
            return;
        }

        Console.WriteLine("Enter your second number:");
        if (!int.TryParse(Console.ReadLine(), out int second))
        {
            Console.WriteLine("Invalid second number.");
            return;
        }

        Console.WriteLine($"Addition: {first + second}");
        Console.WriteLine($"Subtraction: {first - second}");
        Console.WriteLine($"Multiplication: {first * second}");

        if (second == 0)
        {
            Console.WriteLine("Division: Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine($"Division: {first / (double)second}");
        }

        Console.WriteLine($"Modulus: {first % second}");
        Console.WriteLine($"Equal: {first == second}");
        Console.WriteLine($"Not equal: {first != second}");
        Console.WriteLine($"Greater than: {first > second}");
        Console.WriteLine($"Less than: {first < second}");
        Console.WriteLine($"Greater than or equal: {first >= second}");
        Console.WriteLine($"Less than or equal: {first <= second}");
        Console.WriteLine($"Logical AND: {(first > 0 && second > 0)}");
        Console.WriteLine($"Logical OR: {(first > 0 || second > 0)}");
    }
}