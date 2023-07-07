using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public string DriveType { get; set; }
        public double EngineDisplacement { get; set; }
        public string ExteriorColor { get; set; }
        public string TireSize { get; set; }
        public int SeatingCapacity { get; set; }
        public string CompanyName { get; set; }
        public int YearsInBusiness { get; set; }
    }
}
