using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    public abstract class Vehicle
    {
        private string brand, model;
        private int year;
        private int weight;

        const int minYear = 1886;

        public Vehicle()
        {
            
        }


        public string Brand {
            get => brand;
            set => ValidateString(value, out brand, "brand");
        }

        public string Model {
            get => model;
            set => ValidateString(value, out model, "model");
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < minYear || value > DateTime.Now.Year)
                    throw new ArgumentException("Invalid year");
                year = value;
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid weight");
                weight = value;
            }
        }

        private void ValidateString(string input, out string output, string message)
        {
            if(string.IsNullOrEmpty(input) || (input.Length < 2 || input.Length > 20))
                throw new ArgumentException($"Invalid {message}");
            output = input;
        }

        public string Stats()
        {
            // Fattar inte riktigt vad ni vill att man ska göra med denna
            return "Vehicle stats..?";
        }

        public abstract string StartEngine();

        public override string ToString()
        {
            return $"Brand: {brand}, Model: {model}, Year: {year}, Weight: {weight}";
        }
    }
}
