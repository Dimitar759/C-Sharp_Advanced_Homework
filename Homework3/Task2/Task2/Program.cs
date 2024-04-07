using Models;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Motorbike motorBike = new Motorbike();
            Boat boat = new Boat();
            Airplane plane = new Airplane();

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(motorBike.DisplayInfo());
            Console.WriteLine(boat.DisplayInfo());
            Console.WriteLine(plane.DisplayInfo());

            Console.WriteLine("----------------------------------");

            string car2 = "Driving";
            string driving = car2.Drive();
            Console.WriteLine(driving);

            string boat2 = "Boat";
            string sailing = boat2.Sale();
            Console.WriteLine(sailing);

            string plane2 = "Plane";
            string flying = plane2.Fly();
            Console.WriteLine(flying);

            string motorbike2 = "Motorbike";
            string wheeling = motorbike2.Wheelie();
            Console.WriteLine(wheeling);
        }
    }
}
