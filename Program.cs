using System.Linq.Expressions;

namespace FileNotFoundExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string filePath = "C://abc.txt";
                File.ReadAllText(filePath);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Couldn't found the file");
            }
            
            
            
        }
    }
}
