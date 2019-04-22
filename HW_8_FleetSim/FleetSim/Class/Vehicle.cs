using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Class
{
    public class Vehicle : IVehicle
    {
        public string VIN { get; set; }
        public int mileage { get; set; }
        public enum CarColor { red, white, blue };
        public CarColor color { get; set; }
        public DateTime LastServiceDate { get; set; }
        public int LastServicedMileage { get; set; }
        public string car01 { get; private set; }
        public string car02 { get; private set; }

        int mileageSinceLastService = 0;

        public Vehicle()
        {
            VIN = Guid.NewGuid().ToString();
            mileage = 0;
            LastServiceDate = DateTime.Now;
            LastServicedMileage = 0;

            Console.WriteLine($" abc  {VIN}, {mileage}, {LastServiceDate}, {LastServicedMileage} ");    //just to check

            CalculateMileage();

            Console.ReadLine();        //just to check
        }

        public void CalculateMileage()
        {
            Random randomNumber = new Random();
            int MileageCalculation = randomNumber.Next(5000, 15000);
            Console.WriteLine($"The mileage since the last service is:  { MileageCalculation} ");

            mileage = mileage + MileageCalculation;
            Console.WriteLine($"The current mileage is:  { MileageCalculation } ");

            ServiceCheck();
        }

        public void ServiceCheck()
                        {
                            string[] checkService = { car01, car02, "car03", "car04", "car05" };
                            foreach(string value in checkService )
                                {
                               Console.WriteLine(value
                                   );
                                }
                         }       
                        

        



        public void TuneUp()                        //add return type
                {
                    mileageSinceLastService = mileage - LastServicedMileage;

                    if (mileageSinceLastService >= 30000 && mileageSinceLastService < 100000)
                        {
                            LastServicedMileage = mileage;
                            LastServiceDate = DateTime.Now;
                        }
                    else if ((mileageSinceLastService < 30000) && (mileage < 100000))
                        {
                            Console.WriteLine("This vehicle did not need service or an engine rebuild.");
                            return;
                        }
                    else
                        {
                            RebuildEngine();
                        }
                }


        public virtual void RebuildEngine()
                    {
                        mileage = 0;
                        LastServicedMileage = 0;
            
                    }
    }
}
