using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairedTemperatureCalculator
{
    internal class Calc : BindableObject
    {
        private int temperature;
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public bool Farenheit { get; set; }
        public bool Celsjusz { get; set; }

        private string returnMessage;
        public string ReturnMessage
        {
            get { return returnMessage; }
            set { returnMessage = value; OnPropertyChanged(); }
        }

        public Command Calculating { get; set; }
        public Calc()
        {
            Calculating = new Command(Calculate);
        }

        private void Calculate()
        {
            double result = 0;
            if (Farenheit)
            {
                result = (32 + (9.0 / 5.0) * Temperature);
            }
            if (Celsjusz)
            {
                result = ((5.0 / 9.0) * (Temperature - 32));
            }
            ReturnMessage = $"Wynik operacji {result}";
        }
    }
}
