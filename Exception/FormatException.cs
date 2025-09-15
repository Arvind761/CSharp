internal class FormatExcep
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter First no. ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second no. ");
            int y = Convert.ToInt32(Console.ReadLine());

            double d = x / y;
            Console.WriteLine($"Divide is : {d}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Error: Both value should be Integer formate");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error:{e}");
        }
        Console.WriteLine($"Complete program");
    }
    
}