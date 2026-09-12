public class User
{
    private static readonly string PasswordFilePath = Path.Combine(AppContext.BaseDirectory, "passwords.txt");

    public static void Run()
    {
        Console.WriteLine("Enter the user name:");
        string userName = Console.ReadLine() ?? string.Empty;
        string adminUsername = "admin";
        string userUsername = "user";
        string[] passwords = LoadPasswords();
        string adminPassword = passwords[0];
        string userPassword = passwords[1];

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
                Console.WriteLine("Forgot password? (yes/no)");
                string forgotPasswordResponse = Console.ReadLine() ?? string.Empty;
                if (forgotPasswordResponse.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter new password:");
                    string newPassword = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Re-enter new password:");
                    string reEnteredPassword = Console.ReadLine() ?? string.Empty;

                    if (newPassword == reEnteredPassword)
                    {
                        if (userName == adminUsername)
                        {
                            adminPassword = newPassword;
                        }
                        else if (userName == userUsername)
                        {
                            userPassword = newPassword;
                        }

                        File.WriteAllLines(PasswordFilePath, [adminPassword, userPassword]);

                        Console.WriteLine("Password changed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match.");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid username.");
        }
    }

    private static string[] LoadPasswords()
    {
        if (File.Exists(PasswordFilePath))
        {
            string[] passwords = File.ReadAllLines(PasswordFilePath);
            if (passwords.Length >= 2)
            {
                return [passwords[0], passwords[1]];
            }
        }

        return ["admin123", "user123"];
    }
}