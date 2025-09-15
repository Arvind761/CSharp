namespace Exceptions
{
    internal class IndexOutOfRange
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 3, 2, 4, 5, 4, 6 };
            try
            {
                
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.Write($"{arr[i]}  ");
                }
                
            }catch(IndexOutOfRangeException e)
            {
                //Console.WriteLine();
                Console.WriteLine($"\nError: Array length should be (arr.length-1)");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e}");
            }
            Console.WriteLine("\nProgram execution Completed");
        }

    }
}
