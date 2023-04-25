class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Reiz Tech Assessment");
        Console.WriteLine("Erik Lance Tiongquico (2023 April)");
        Console.WriteLine();

        Console.WriteLine("1. Clock");
        Console.WriteLine("2. Branching");

        Console.Write("Input the number of the program you want to run: ");
        int program = Convert.ToInt32(Console.ReadLine());

        switch (program)
        {
            case 1:
                Clock.run();
                break;
            case 2:
                Branching.run();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}