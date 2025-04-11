using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    internal class Car : Vehicle, ICleanable
    {
        private int numDoors;
        public override string StartEngine()
        {
            return "Starting car...";
        }

        public int NumDoors
        {
            get => numDoors;
            set
            {
                if (value < 1)
                    throw new ArgumentException("A car has atleast one door");
                numDoors = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Number of doors: {numDoors}\n";
        }

        public string Clean()
        {
            return "Cleaning car...";
        }
    }
}
