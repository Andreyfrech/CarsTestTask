using System;
using System.Collections.Generic;

namespace CarsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирете тип автомобиля\n1: Спорткар\n2: Легковой автомобиль\n3: Грузовик");
            int carsType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите средний расход топлива(л/100 км)");
            double avrFuel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите объем топливного бака");
            double fuelVoluem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите текущие количество топлива");
            double currentFuel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость (км/ч)");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите расстояние (км)");
            double distance = Convert.ToDouble(Console.ReadLine());
            switch (carsType)
            {
                case 1:
                    Cars sport = new SportCar(avrFuel, fuelVoluem, currentFuel, speed);
                   sport.DisplayDistance();
                    break;
                case 2:
                    Console.WriteLine("Введите максимальное число пассажиров");
                    double maxPass =  Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите текущие количество пассажиров");
                    double currentPass = Convert.ToDouble(Console.ReadLine());
                    Cars passDefault = new SportCar(avrFuel, fuelVoluem, currentFuel, speed);
                    passDefault.DisplayDistanceDefault();
                    Cars pass = new PassCar(avrFuel, fuelVoluem, currentFuel, speed, maxPass, currentPass);
                    pass.DisplayDistance();
                    pass.DisplayTimeDistance(distance);
                    break;
                case 3:
                    Console.WriteLine("Введите грузоподъемность (кг)");
                    double fullCapacity = Convert.ToDouble(Console.ReadLine()); 
                    Console.WriteLine("Введите массу груза (кг)");
                    double loadCapacity = Convert.ToDouble(Console.ReadLine());
                    Cars truckDefault = new SportCar(avrFuel, fuelVoluem, currentFuel, speed);
                    truckDefault.DisplayDistanceDefault();
                    Cars truck = new Truck(avrFuel, fuelVoluem, currentFuel, speed, fullCapacity, loadCapacity);
                    truck.DisplayDistance();
                    truck.DisplayTimeDistance(distance);
                    break;
                    
            }


        }
    }
}
