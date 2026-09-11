public class forloop
{
    public static void Run ()
    {
       Console.WriteLine("Enter a number for print it in line");
       int n = Convert.ToInt32(Console.ReadLine());
       for (int i = 1; i <= n; i++)
       {
           Console.Write(i + " ");
       }
    }
}