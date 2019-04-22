using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Class;

namespace FleetSim.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car01 = new Car(2011, "VW", "Golf");
            Car car02 = new Car(2012, "Chevy", "Impala");
            Car car03 = new Car(2013, "Ford", "Taurus");
            Car car04 = new Car(2014, "Chrysler", "New Yorker");
            Car car05 = new Car(2015, "Toyota", "Corolla");
        
             
            System.Console.WriteLine(car01.Year + car01.Make + car01.Model+car01.color );    //test only
            System.Console.WriteLine("juice");

            string something = System.Console.ReadLine();
        }
    }
 

}

