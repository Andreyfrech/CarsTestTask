using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTask
{
    public class Truck : Cars
    {
        // Дополнительные свойства грузовика
        public double FullLoadCapacity { get; set; }
        public double LoadCapacity { get; set; }
        // Коэффициент уменшения запаса хода в зависимости от массы груза
        protected const double FuelRangeDecreaseForNKg = 0.04;
        protected const double ExtraWeight = 200;

        public Truck(double averageFuelConsumption, double fuelVoluem, double currentFuelVolume,
            double speed, double fullLoadCapacity, double loadCapacity) : base(CarsTypes.C, averageFuelConsumption, fuelVoluem, currentFuelVolume, speed)
        {
            FullLoadCapacity = fullLoadCapacity;
            LoadCapacity = loadCapacity;
            // Проверка на вместимость груза, если масса груза больше грузоподъемности грузовика, то программа завершается
            if (FullLoadCapacity < LoadCapacity)
            {
                Console.WriteLine($"Вы не можете загрузить больше {FullLoadCapacity} кг");
                System.Environment.Exit(0);
            }
        }
        // Подсчет запаса ход в зависимости от массы груза
        protected override double CalcDistanceCurrentFuelVolume(double currentFuelVolume)
        {
            return base.CalcDistanceCurrentFuelVolume(currentFuelVolume) * (1 - LoadCapacity * (FuelRangeDecreaseForNKg / ExtraWeight));
        }
    }
}
