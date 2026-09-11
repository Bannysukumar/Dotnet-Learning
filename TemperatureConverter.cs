public class TemperatureConverter
{
    public static void Run() // this is the main method that will be called to run the temperature conversion program. It will prompt the user for input, perform the conversions, and display the results.
    {
        Console.WriteLine("Enter the temperature in Celsius:"); // we taking the input from the user in celsius and converting it to other temperature units
        if (!double.TryParse(Console.ReadLine(), out double celsius)) // iam using the double .TryParse method to convert the input string to a double. If the conversion fails, it will return false and we will print an error message and return from the method.
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        // from here iam calculating the equivalent temperature in other units using the formulas for each conversion. The formulas are based on the relationships between Celsius and other temperature scales.
        double fahrenheit = (celsius * 9 / 5) + 32; //from this to 
        double kelvin = celsius + 273.15; 
        double rankine = (celsius + 273.15) * 9 / 5;
        double reaumur = celsius * 4 / 5;
        double delisle = (100 - celsius) * 3 / 2;
        double newton = celsius * 33 / 100;
        double romer = celsius * 21 / 40 + 7.5; //from this valid temperature conversions
        double planck = celsius * 1.380649e-23;
        double atomicMassUnit = celsius * 1.66053906660e-27;
        double electronVolt = celsius * 1.602176634e-19;
        double joule = celsius * 4.184;
        double calorie = celsius * 4.184;
        //from here iam printing the converted values to the console using Console.WriteLine method. The output will show the original Celsius temperature and its equivalent in other temperature units.
        Console.WriteLine($"this is calorie: {celsius}°C is equal to {calorie} cal");
        Console.WriteLine($"this is joule: {celsius}°C is equal to {joule} J");
        Console.WriteLine($"this is electron volt: {celsius}°C is equal to {electronVolt} eV");
        Console.WriteLine($"this is atomic mass unit: {celsius}°C is equal to {atomicMassUnit} u");
        Console.WriteLine($"this is planck: {celsius}°C is equal to {planck}K");
        Console.WriteLine($"this is romer: {celsius}°C is equal to {romer}°Rø");
        Console.WriteLine($"this is newton: {celsius}°C is equal to {newton}°N");
        Console.WriteLine($"this is delisle: {celsius}°C is equal to {delisle}°De");
        Console.WriteLine($"this is reaumur: {celsius}°C is equal to {reaumur}°Re");
        Console.WriteLine($"this is rankine: {celsius}°C is equal to {rankine}°R");
        Console.WriteLine($"this is fahrenheit: {celsius}°C is equal to {fahrenheit}°F");
        Console.WriteLine($"this is kelvin: {celsius}°C is equal to {kelvin}K");
    }
}