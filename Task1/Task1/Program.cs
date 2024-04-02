using System.Reflection;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInConsole<string> strings = new PrintInConsole<string>();

            List<string> stringsList = new List<string> { "Seavus", "Brainster", "Semos", "CreativeHub", "Code Academy" };

            strings.PrintCollection(stringsList);

            Random rand = new Random();
            int random = rand.Next(0, 1001);

            PrintInConsole<int> ints = new PrintInConsole<int>();

            ints.Print(random);

        }
    }
}
