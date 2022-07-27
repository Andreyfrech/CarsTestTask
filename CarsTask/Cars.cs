using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTask
{
    public enum CarsTypes
    {
        A,
        B,
        C,
        D,
        E
    }

    public abstract class Cars
    {
        public CarsTypes Type { get; set; }
        public double AverageFuelConsumption { get; set; }
        public double FuelVoluem { get; set; } 
        public double CurrentFuelVolume { get; set; }
        public double Speed { get; set; }

        public Cars(CarsTypes type, double averageFuelConsumption, double fuelVoluem, double currentFuelVolume, double speed)
        {
            Type = type;
            AverageFuelConsumption = averageFuelConsumption;
            FuelVoluem = fuelVoluem;
            Speed = speed;
            CurrentFuelVolume = currentFuelVolume;
        }

        public void DisplayDistance()
        {
            Console.WriteLine($"Текущий запас хода - {DistanceCurrentFuelVolume()} км");
        }
        public void DisplayDistanceDefault()
        {
            Console.WriteLine($"Запас хода - {DistanceCurrentFuelVolume()} км");
        }
        public void DisplayTimeDistance(double distace)
        {
            Console.WriteLine($"Указанное расстояние вы проедите за {TimeDistance(distace)} часа(ов)");
        }

        public double DistanceCurrentFuelVolume()
        {
            return CalcDistanceCurrentFuelVolume(CurrentFuelVolume);
        }

        public double TimeDistance(double distance)
        {
            return CalcDistanceCurrentFuelVolume(CurrentFuelVolume) > distance ? distance / Speed : 0; //Если топлива не хватит на заданное расстояние, то 0
        }

        protected virtual double CalcDistanceCurrentFuelVolume(double currentFuelVolume)
        {
            return currentFuelVolume / (double)AverageFuelConsumption * 100;
        }
    }
}
