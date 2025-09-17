namespace CsharpPractice
{
    internal static class ExtensionMethods
    {
        public static void Test5(this Program P)
        {
            Console.WriteLine("Adding this method in program by using extension method");
        }
        public static void Test6(this Program P,int i)
        {
            Console.WriteLine($"Adding this method in program by using extension method {i}");
        }
    }
}
