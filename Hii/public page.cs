public class Test
{
    public static void Run()
    {
        int age = 21;
        string name = "John Doe";
        bool isStudent = true;
        double gpa = 3.75;
        string[] courses = { "Math", "Science", "History" };
        string address = "123 Main St, Anytown, USA";
        string phoneNumber = "555-1234";
        double salary = 50000.50;
        bool isActive = true;
        if (isStudent && isActive)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Student: {isStudent}, GPA: {gpa}");
            Console.WriteLine($"Courses: {string.Join(", ", courses)}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
        }
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}, Active: {isActive}");
    }
}
