using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lexicon_Exercise_3
{
    public class VehicleHandler
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        enum VehicleType { Car, Scooter, Truck, MC };
        VehicleType vehicleType;

        public VehicleHandler()
        {
            FillVehicles();
            NumVehicles = vehicles.Count;
        }

        public int NumVehicles { get; private set; }

        void FillVehicles()
        {
            vehicles.Add(new Car
            {
                Brand = "SAAB",
                Model = "9000 Turbo",
                Year = 1996,
                Weight = 2000,
                NumDoors = 4
            });

            vehicles.Add(new ElectricScooter
            {
                Brand = "Yamaha",
                Model = "Speedster",
                Year = 2015,
                Weight = 10,
                MaxRangeInMinutes = 60
            });

            vehicles.Add(new Motorcycle
            {
                Brand = "Yamaha",
                Model = "R9",
                Year = 2018,
                Weight = 600,
                EngineCC = 600
            });
        }

        public Vehicle? GetVehicle(int index)
        {
            if(index >= 0 && index < vehicles.Count)
                return vehicles[index];
            return null;
        }

        public List<string> GetVehiclesAsString()
        {
            List<string> strings = new List<string>();
            vehicles.ForEach(vehicle => strings.Add(vehicle.ToString()));
            return strings; 
        }


        public void CreateVehicle(string brand, string model, 
            int year, int weight, int uniqueVal, int chosenVehicle)
        {
            vehicleType = (VehicleType)chosenVehicle;
            Vehicle vehicle = null;
            switch (vehicleType)
            {
                case VehicleType.Car:
                    vehicle = new Car() { NumDoors = uniqueVal };
                    //((Car)vehicle).NumDoors = uniqueVal;
                    break;
                case VehicleType.Scooter:
                    vehicle = new ElectricScooter() { MaxRangeInMinutes= uniqueVal };
                    //((ElectricScooter)vehicle).MaxRangeInMinutes = uniqueVal;
                    break;
                case VehicleType.Truck:
                    vehicle = new Truck() { Capacity = uniqueVal };
                    //((Truck)vehicle).Capacity = uniqueVal;
                    break;
                case VehicleType.MC:
                    vehicle = new Motorcycle() { EngineCC = uniqueVal };
                    //((Motorcycle)vehicle).EngineCC = uniqueVal;
                    break;
            }
            vehicle.Brand = brand;
            vehicle.Model = model;
            vehicle.Year = year;
            vehicle.Weight = weight;

            vehicles.Add(vehicle);
        }


        void RemoveVehicle()
        {
            
        }

        void EditVehicle(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Car:
                    break;
                case VehicleType.Scooter:
                    break;
                case VehicleType.MC:
                    break;
                case VehicleType.Truck:
                    break;
                default:
                    break;
            }
        }
    }
}
