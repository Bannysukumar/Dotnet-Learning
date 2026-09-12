public class User
{
    public static void Run()
    {
        Console.WriteLine("Enter the user name:");
        string userName = Console.ReadLine() ?? string.Empty;
        string adminUsername = "admin";
        string adminPassword = "admin123";
        string userUsername = "user";
        string userPassword = "user123";

        if (userName == adminUsername || userName == userUsername)
        {
            Console.WriteLine("Enter the password:");
            string enteredPassword = Console.ReadLine() ?? string.Empty;

            if (userName == adminUsername && enteredPassword == adminPassword)
            {
                Console.WriteLine("The admin login was successful.");
            }
            else if (userName == userUsername && enteredPassword == userPassword)
            {
                Console.WriteLine("The user login was successful.");
            }
            else
            {
                Console.WriteLine("Invalid password.");
            }
            Console.WriteLine("Forgot password? (yes/no)");
            string forgotPasswordResponse = Console.ReadLine() ?? string.Empty;
            if (forgotPasswordResponse.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter new password:");
                string newPassword = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Re-enter new password:");
                string reEnteredPassword = Console.ReadLine() ?? string.Empty;
                if (userName == adminUsername)
                {
                    adminPassword = reEnteredPassword; // Update the admin password
                }
                else if (userName == userUsername)
                {
                    userPassword = reEnteredPassword; // Update the user password
                }

                if (newPassword == reEnteredPassword)
                {
                    Console.WriteLine("Password changed successfully.");
                }
                else
                {
                    Console.WriteLine("Passwords do not match.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid username.");
        }
    }
}