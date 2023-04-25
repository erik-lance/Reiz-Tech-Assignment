class Branch
{
    List<Branch> branches = new List<Branch>();
}

class Program
{
    static void Main(string[] args)
    {
        int hours = 0;
        int minutes = 0;

        Console.WriteLine("Analog Clock Console App");
        Console.WriteLine("Erik Lance Tiongquico (2023 April)");
        Console.WriteLine();

        Console.Write("Input the number of hours: ");
        hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the number of minutes: ");
        minutes = Convert.ToInt32(Console.ReadLine());

        // Converts clock time to degrees
        int hourDegrees = (hours * 30) + (minutes / 2); // 30 degrees per hour, 1 minute = 0.5 degrees
        int minuteDegrees = minutes * 6;                // 6 degrees per minute

        // Calculates the lesser angle between the two hands
        int angle = Math.Abs(hourDegrees - minuteDegrees);
        if (angle > 180)
        {
            angle = 360 - angle;
        }

        Console.WriteLine("The lesser angle between the two hands is: " + angle + " degrees");

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}
