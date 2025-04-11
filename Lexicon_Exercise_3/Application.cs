using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    internal class Application
    {
        private bool run = true;
        private int menuIndex = 0;
        private int prevMenuIndex = 0;
        private int maxMenuIndex = 1;
        private int numMenuOptions = 3;
        VehicleHandler vehicleHandler = new VehicleHandler();
        MenuNode currentMenu;
        enum MenuOptions { Main, View, ChooseType, Add };
        MenuOptions menuOption = MenuOptions.Main;

        public Application()
        {           
        }

        public void Run()
        {
            currentMenu = FillMenuNodes();
            while (run)
            {
                try
                {
                    currentMenu.Print();
                    if (menuOption == MenuOptions.Add)
                    {   if (EnterVehicleInfo())
                            Console.WriteLine("Success!");
                    }               
                    HandleNavigationInput();
                    currentMenu.HighlightIndex = menuIndex;
                }
                catch (ArgumentException e) 
                {
                    Console.WriteLine(e.Message);
                    HandleNavigationInput();
                }
            }
        }


        public void HandleNavigationInput()
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.UpArrow:
                    if(menuIndex > 0) menuIndex--; break;

                case ConsoleKey.DownArrow:
                    if(menuIndex < currentMenu.MaxIndex) menuIndex++; break;

                case ConsoleKey.Enter:
                    currentMenu = currentMenu.TryGetNext(menuIndex); 
                    prevMenuIndex = menuIndex;
                    menuIndex = 0; break;

                case ConsoleKey.Backspace:            
                    currentMenu = currentMenu.TryGetPrev();
                    menuIndex = 0; break;

                case ConsoleKey.Delete:
                    if (menuOption == MenuOptions.View) vehicleHandler.RemoveVehicle(menuIndex);
                    break;

                case ConsoleKey.Escape:
                    run = false; break;
            }
            menuOption = currentMenu.NodeID > (int)MenuOptions.Add ? MenuOptions.Add : (MenuOptions)currentMenu.NodeID;
            if (menuOption == MenuOptions.View)
                currentMenu.UpdateData(vehicleHandler.GetVehiclesAsString());
        }



        bool EnterVehicleInfo()
        {
            int chosenVehicle = prevMenuIndex;
            Console.CursorVisible = true;
            List<string> vehicleInput = new List<string>();
            for (int i=0; i<=currentMenu.MaxIndex; i++)
            {
                int cursorPos = vehicleHandler.NumVehicles - 1;
                Console.SetCursorPosition(cursorPos, i + 1);           
                vehicleInput.Add(Console.ReadLine());
            }
           
            string brand = vehicleInput[0];
            string model = vehicleInput[1];
            if (ValidateInput(vehicleInput, out int weight, out int year, out int uniqueVal))
            {
                vehicleHandler.CreateVehicle(brand, model, year, weight, uniqueVal, chosenVehicle);
                currentMenu = currentMenu.TryGetPrev();
                return true;
            }
            return false;
        }


        bool ValidateInput(List<string> input, 
            out int weight, out int year, out int last)
        {
            weight = 0; year = 0; last = 0;
            int numInputsRequired = currentMenu.MaxIndex + 1;
            if (input.Count < numInputsRequired)
            {
                int missingInputs = numInputsRequired - input.Count;
                throw new ArgumentException($"Failed to add vehicle. " +
                    $"{missingInputs} fields were left empty.");
            }      
            if(!int.TryParse(input[2], out year) || !int.TryParse(input[3], out weight)
              || !int.TryParse(input[4], out last))
            {
                throw new ArgumentException("Failed to parse input, expected value: integer");
            }
            return true;
        }


        MenuNode FillMenuNodes()
        {
            MenuNode mainMenu = new("Vehicle Register Menu", 
                ["View registered vehicles", "Add vehicle"]);
            MenuNode viewVehicles = new("Registered Vehicles", vehicleHandler.GetVehiclesAsString());
            MenuNode chooseType = new("Choose Vehicle Type", 
                ["Car","Electric Scooter", "Truck", "Motorcycle"]);
            MenuNode addCar = new("Enter Car Info", ["Brand: ", "Model: ", "Year: ", "Weight: ", "Doors: "]);
            MenuNode addScoter = new("Enter Scooter Info", ["Brand: ", "Model: ","Year: ","Weight: ","Range: "]);
            MenuNode addTruck = new("Enter Truck Info", ["Brand: ", "Model: ", "Year: ", "Weight: ", "Capacity: "]);
            MenuNode addMC = new("Enter Motorcycle Info", ["Brand: ", "Model: ", "Year: ", "Weight: ", "Engine CC: "]);
            
            addCar.Prev = chooseType;
            addScoter.Prev = chooseType;
            addTruck.Prev = chooseType;
            addMC.Prev = chooseType;
            viewVehicles.Prev = mainMenu;
            chooseType.Prev = mainMenu;
            chooseType.Next.Add(addCar);
            chooseType.Next.Add(addScoter);
            chooseType.Next.Add(addTruck);
            chooseType.Next.Add(addMC);
            mainMenu.Next.Add(viewVehicles);
            mainMenu.Next.Add(chooseType);
            return mainMenu;
        }
    }
}
