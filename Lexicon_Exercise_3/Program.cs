using Lexicon_Exercise_3.Errors;

namespace Lexicon_Exercise_3
{
    class Program
    {
        static void Main()
        {
            #region DEL 1 & 3
            Application app = new Application();
            app.Run();
            #endregion

            #region DEL 2 Polymorfism
            //ErrorManager errorManager = new ErrorManager();
            //errorManager.Run();
            #endregion

            #region DEL 4
            //List<Vehicle> vehicles = new List<Vehicle>();
            //vehicles.Add(new Car
            //{
            //    Brand = "SAAB",
            //    Model = "9000 Turbo",
            //    Year = 1996,
            //    Weight = 2000,
            //    NumDoors = 4
            //});

            //vehicles.Add(new ElectricScooter
            //{
            //    Brand = "Yamaha",
            //    Model = "Speedster",
            //    Year = 2015,
            //    Weight = 10,
            //    MaxRangeInMinutes = 60
            //});

            //vehicles.Add(new Motorcycle
            //{
            //    Brand = "Yamaha",
            //    Model = "R9",
            //    Year = 2018,
            //    Weight = 600,
            //    EngineCC = 600
            //});

            //foreach (var vehicle in vehicles)
            //{
            //    Console.WriteLine(vehicle.Stats());
            //    Console.WriteLine(vehicle.StartEngine());
            //    if(vehicle is ICleanable cleanable)
            //    {
            //        Console.WriteLine(cleanable.Clean());
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}