using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All cars that have an origin from europe");
            Console.WriteLine("");
            var originEurope = CarsData.Cars.Where(car => car.Origin == "Europe").ToList();
            foreach (var car in originEurope)
            {
                Console.WriteLine($"Model: {car.Model}, Origin: {car.Origin}");
            }
            

            /////////////////////////////////////////////////////


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("All cars that have more than 6 Cylinders not including 6, after that Filter all cars that have exactly 4 Cylinders and have HorsePower more than 110.0");
            Console.WriteLine("");

            var result = CarsData.Cars
             .Where(car => (car.Cylinders > 6) || (car.Cylinders == 4 && car.HorsePower > 110.0))
             .ToList();

            foreach (var car in result)
            {
                Console.WriteLine($"Model: {car.Model}, Cylinders: {car.Cylinders}, HorsePower: {car.HorsePower}");
            }


            /////////////////////////////////////////////////////


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Count all cars based on their Origin");
            Console.WriteLine("");

            var carsByOrigin = CarsData.Cars.GroupBy(car => car.Origin);
            foreach (var group in carsByOrigin)
            {
                Console.WriteLine($"Origin: {group.Key}, Count: {group.Count()}");
            }


            /////////////////////////////////////////////////////


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("All cars that have more than 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon");
            Console.WriteLine("");

            var carsWMoreThan200HP = CarsData.Cars.Where(car => car.HorsePower > 200).ToList();

            if (carsWMoreThan200HP.Any())
            {
                var lowestMPG = carsWMoreThan200HP.Min(car => car.MilesPerGalon);
                var highestMPG = carsWMoreThan200HP.Max(car => car.MilesPerGalon);
                var averageMPG = carsWMoreThan200HP.Average(car => car.MilesPerGalon);

                Console.WriteLine($"Lowest Miles per Gallon: {lowestMPG}");
                Console.WriteLine($"Highest Miles per Gallon: {highestMPG}");
                Console.WriteLine($"Average Miles per Gallon: {averageMPG}");
            }
            else
            {
                Console.WriteLine("No cars have more than 200 horsepower.");
            }


            /////////////////////////////////////////////////////


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Top 3 fastest accelerating cars");
            Console.WriteLine("");

            var threeFastestAccCars = CarsData.Cars.OrderBy(car => car.AccelerationTime).Take(3).ToList();

            foreach (var car in threeFastestAccCars)
            {
                Console.WriteLine($"Car Model: {car.Model}, Acceleration time: {car.AccelerationTime}");
            }


            /////////////////////////////////////////////////////


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Total weight of cars with more than 6 cylinders");
            Console.WriteLine("");

            var moreThan6Cylinders = CarsData.Cars.Where(car => car.Cylinders > 6).ToList();
            double sum = 0;
            foreach (var car in moreThan6Cylinders)
            {
                sum += car.Weight; 
            }
            Console.WriteLine("Total weight of cars with more than 6 Cylinders:" + sum);


            /////////////////////////////////////////////////////


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The average MilesPerGalon for cars with even number of cylinders");
            Console.WriteLine("");


            var averageMilesPerGallonOnCarsWithEvenNumOfCylinders = CarsData.Cars.Where(car => car.Cylinders % 2 == 0).Average(car => car.MilesPerGalon);

            Console.WriteLine($"The average MilesPerGalon for cars with even number of cylinders: {averageMilesPerGallonOnCarsWithEvenNumOfCylinders}");
        }
    }
}
