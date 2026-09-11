public class Sample
{
    public static void Run()
    {
        Console.WriteLine("Enter your name (1-20 characters):");
        string? nameInput = Console.ReadLine();
        string name = nameInput?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(name) || name.Length > 20)
        {
            Console.WriteLine("Invalid name. Please enter 1 to 20 characters.");
            return;
        }

        Console.WriteLine("Select gender (Male/Female):");
        string? genderInput = Console.ReadLine();
        string gender = genderInput?.Trim() ?? string.Empty;
        string normalizedGender = gender.Trim();

        if (normalizedGender.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            gender = "Male";
        }
        else if (normalizedGender.Equals("Female", StringComparison.OrdinalIgnoreCase))
        {
            gender = "Female";
        }
        else
        {
            Console.WriteLine("Invalid gender. Please select Male or Female.");
            return;
        }

        Console.WriteLine("Enter your age (1-120):");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age) && age >= 1 && age <= 120)
        {
            if (age >= 18)
            {
                Console.WriteLine(name + " (" + gender + ") is an adult at age " + age + ".");
            }
            else
            {
                Console.WriteLine(name + " (" + gender + ") is a minor.");
            }
        }
        else
        {
            Console.WriteLine("Invalid age input. Age must be between 1 and 120.");
        }
    }
}