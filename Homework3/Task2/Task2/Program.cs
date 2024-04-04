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

            Console.WriteLine(car.Drive());
            Console.WriteLine(motorBike.Wheelie());
            Console.WriteLine(boat.Sail());
            Console.WriteLine(plane.Fly());
        }
    }
}
