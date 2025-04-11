using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    internal class Motorcycle : Vehicle
    {
        private int engineCC;
        public override string StartEngine()
        {
            return "Starting motorcycle...";
        }

        public int EngineCC
        {
            get => engineCC;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Cannot have negative or 0 CC");
                engineCC = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Engine CC: {engineCC}\n";
        }
    }
}
