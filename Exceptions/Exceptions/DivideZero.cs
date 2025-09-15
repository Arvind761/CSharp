

namespace Exceptions
{
    internal class DivideZero
    {
        public static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Enter First no. ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second no. ");
                int y = Convert.ToInt32(Console.ReadLine());

                double d = x / y;
                Console.WriteLine($"Divide is : {d}");
            }catch(DivideByZeroException e)
            {
                Console.WriteLine($"dividend should be greater than zero:");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e}");
            }
            Console.WriteLine($"Complete program");

        }
    }
}
