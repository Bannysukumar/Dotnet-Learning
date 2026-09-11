public class Switch
{
    public static void Run()
    {
        Console.WriteLine("Enter a number between 1 and 7 to get the corresponding day of the week:");
        if (!int.TryParse(Console.ReadLine(), out int day) || day < 1 || day > 7)
        {
            Console.WriteLine("Invalid day. Enter a number from 1 to 7.");
            return;
        }

        Console.WriteLine("Select Your Year: ");
        if (!int.TryParse(Console.ReadLine(), out int year) || year < 1)
        {
            Console.WriteLine("Invalid year.");
            return;
        }

        Console.WriteLine("Select Your Month (1-12 or name): ");
        string monthInput = Console.ReadLine()?.Trim() ?? string.Empty;
        int month;
        if (!int.TryParse(monthInput, out month))
        {
            string[] monthFormats = { "MMMM", "MMM" };
            if (!DateTime.TryParseExact(monthInput, monthFormats,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.AllowWhiteSpaces, out DateTime parsedMonth))
            {
                Console.WriteLine("Invalid month. Enter 1-12 or a month name.");
                return;
            }

            month = parsedMonth.Month;
        }

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month. Enter a number from 1 to 12.");
            return;
        }

        int daysInMonth = DateTime.DaysInMonth(year, month);
        Console.WriteLine($"Number of days in the selected month: {daysInMonth}");
        int daysInYear = DateTime.IsLeapYear(year) ? 366 : 365;
        Console.WriteLine($"Number of days in the selected year: {daysInYear}");
        int daysInWeek = 7;
        Console.WriteLine($"Number of days in a week: {daysInWeek}");
        int hoursInDay = 24;
        Console.WriteLine($"Number of hours in a day: {hoursInDay}");
        int minutesInHour = 60;
        Console.WriteLine($"Number of minutes in an hour: {minutesInHour}");
        int secondsInMinute = 60;
        Console.WriteLine($"Number of seconds in a minute: {secondsInMinute}");
        int millisecondsInSecond = 1000;
        Console.WriteLine($"Number of milliseconds in a second: {millisecondsInSecond}");
        int microsecondsInMillisecond = 1000;
        Console.WriteLine($"Number of microseconds in a millisecond: {microsecondsInMillisecond}");
        int nanosecondsInMicrosecond = 1000;
        Console.WriteLine($"Number of nanoseconds in a microsecond: {nanosecondsInMicrosecond}");
        int picosecondsInNanosecond = 1000;
        Console.WriteLine($"Number of picoseconds in a nanosecond: {picosecondsInNanosecond}");
        int femtosecondsInPicosecond = 1000;
        Console.WriteLine($"Number of femtoseconds in a picosecond: {femtosecondsInPicosecond}");
        int attosecondsInFemtosecond = 1000;
        Console.WriteLine($"Number of attoseconds in a femtosecond: {attosecondsInFemtosecond}");
        int zeptosecondsInAttosecond = 1000;
        Console.WriteLine($"Number of zeptoseconds in an attosecond: {zeptosecondsInAttosecond}");
        int yoctosecondsInZeptosecond = 1000;
        Console.WriteLine($"Number of yoctoseconds in a zeptosecond: {yoctosecondsInZeptosecond}");
        switch (day)
        {
            case 1:
                Console.WriteLine($"selected - Monday");
                break;
            case 2:
                Console.WriteLine($"selected - Tuesday");
                break;
            case 3:
                Console.WriteLine($"selected    - Wednesday");
                break;
            case 4:
                Console.WriteLine($"selected - Thursday");
                break;
            case 5:
                Console.WriteLine($"selected  - Friday");
                break;
            case 6:
                Console.WriteLine($"selected - Saturday");
                break;
            case 7:
                Console.WriteLine($"selected  -  Sunday");
                break;
            default:
                Console.WriteLine("Invalid day.");
                break;
        }
    }
}