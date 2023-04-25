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

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}
