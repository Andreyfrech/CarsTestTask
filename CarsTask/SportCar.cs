using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTask
{
    public class SportCar : Cars
    {
        public SportCar(double averageFuelConsumption, double fuelVoluem, double currentFuelVolume,
            double speed) : base(CarsTypes.B, averageFuelConsumption, fuelVoluem, currentFuelVolume, speed)
        {
        }
    }
}
