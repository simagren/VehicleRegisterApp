using Lexicon_Exercise_3.Errors;

namespace Lexicon_Exercise_3
{
    // Svar på frågor:
    // * Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
    //     - Det går inte. Kan ha en lista av vehicle och
    //     lägga till både car och motorcycle men inte tvärt om.
    // * Vilken typ bör en lista vara för att rymma alla fordonstyper?
    //     - Vehicle
    // * Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
    //     - Ja, om någon av objekten i listan är ICleanable.
    // * Vad är fördelarna med att använda ett interface här istället för arv?
    //     - C# stödjer inte multiple inheritance, men är möjligt
    //       för en klass att ärva flera interfaces.
    //     - Interfaces är mindre strikt än arv. Kan användas för att säga åt en
    //       klass att något måste implementeras, men bryr sig inte om hur.

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