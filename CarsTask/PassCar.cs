using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsTask
{
    public class PassCar : Cars
    {
        // Дополнительные свойства легковых авто
        public double FullPassanger { get; set; }
        public double CurrentPassanger { get; set; }
        // Коэффициент уменшения запаса хода в зависимости от количесва пассажиров
        protected const double FuelRangeDecreaseForPass = 0.06;

        public PassCar(double averageFuelConsumption, double fuelVoluem, double currentFuelVolume,
            double speed, double fullPassanger, double currentPassanger) : base(CarsTypes.B, averageFuelConsumption, fuelVoluem, currentFuelVolume, speed)
        {
            FullPassanger = fullPassanger;
            CurrentPassanger = currentPassanger;

            // Проверка на количество пассажиров, если пассажиров больше чем вместимость, то программа завершается 
            if (FullPassanger < CurrentPassanger)
            {
                Console.WriteLine($"Вы не можете перевозить людей больше {FullPassanger}");
                System.Environment.Exit(0);
            }
        }
        // Подсчет запаса ход в зависимости от количества пассажиров
        protected override double CalcDistanceCurrentFuelVolume(double currentFuelVolume)
        {
            return base.CalcDistanceCurrentFuelVolume(currentFuelVolume) * (1 - CurrentPassanger * (FuelRangeDecreaseForPass / 1));
        }
    }
}
