using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    internal class ElectricScooter : Vehicle
    {
        private int maxRangeInMinutes;
        public override string StartEngine()
        {
            return "Starting scooter...";
        }

        public int MaxRangeInMinutes
        {
            get => maxRangeInMinutes;
            set
            {
                if(value <= 0)
                    throw new ArgumentException("Cant have 0 or less in range");
                maxRangeInMinutes = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Max range: {maxRangeInMinutes} minutes\n";
        }
    }
}
