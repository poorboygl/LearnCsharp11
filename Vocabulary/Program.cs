using System.Reflection;

namespace Vocabulary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? password;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
            }
            while (password != "Pa$$w0rd");
            WriteLine("Correct!");
        }
    }
}