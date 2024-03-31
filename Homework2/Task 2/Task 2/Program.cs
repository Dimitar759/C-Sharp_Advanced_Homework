using Models;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IVehichle car = new Car();
            IVehichle motorBike = new Motorbike();
            IVehichle boat = new Boat();
            IVehichle plane = new Airplane();

            Console.WriteLine(car.DisplayInfo());
            Console.WriteLine(motorBike.DisplayInfo());
            Console.WriteLine(boat.DisplayInfo());
            Console.WriteLine(plane.DisplayInfo());
        }
    }
}
