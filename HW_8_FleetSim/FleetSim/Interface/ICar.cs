using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Interface
{
    interface ICar
    {
        int Year { get; set; }
        string Make { get; set; }
        string Model { get; set; }
   } 
}
