using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public double CargoCapacity { get; set; }
        public bool HasChildDoorLocks { get; set; }
        public double EngineDisplacement { get; set; }
        public string ExteriorColor { get; set; }
        public string TireSize { get; set; }
        public int SeatingCapacity { get; set; }
        public string CompanyName { get; set; }
        public int YearsInBusiness { get; set; }
    }
}
