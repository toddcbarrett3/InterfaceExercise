using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public double EngineDisplacement { get; set; }
        public string ExteriorColor { get; set; }
        public string TireSize { get; set; }
        public int SeatingCapacity { get; set; }
    }
}
