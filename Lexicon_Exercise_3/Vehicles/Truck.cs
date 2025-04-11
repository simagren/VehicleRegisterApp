using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    internal class Truck : Vehicle, ICleanable
    {
        private int capacity;
        public override string StartEngine()
        {
            return "Starting truck...";
        }

        public int Capacity
        {
            get => capacity;
            set
            {
                if(value <= 0)
                    throw new ArgumentException("Cannot have negative or 0 capacity");
                capacity = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Storage capacity: {capacity}\n";
        }

        public string Clean()
        {
            return "Cleaning truck...";
        }
    }
}
