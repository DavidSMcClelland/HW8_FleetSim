using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Class
{
    public class Car : Vehicle, FleetSim.Interface.ICar
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(int Year, string Make, string Model)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
        }

        public Car(int Year, string Make, string Model, CarColor color)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.color = color;
        }
        public override void RebuildEngine()
        {
            base.RebuildEngine();
            Console.WriteLine("Engine rebuilt on " + LastServiceDate + " for " + Model);
        }
    }
}

