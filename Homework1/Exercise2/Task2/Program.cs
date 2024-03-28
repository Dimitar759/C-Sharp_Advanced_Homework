namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee managerEmployee = new Manager(6000,12);
            Programmer programmerEmployee = new Programmer(4500, 12);

            Console.WriteLine(managerEmployee.DisplayInfo());
            Console.WriteLine(programmerEmployee.DisplayInfo());
        }
    }
}
