internal class FileNotFound
{
    public static void Main(string[] args)
    {
        string path = "D:\\@2025\\Nit\\CSharp\\Exceptions\\Exceptions\\Note.txt";
        try
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            Console.WriteLine("File Open succesfully");



        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"Error : File not persent in Project");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}