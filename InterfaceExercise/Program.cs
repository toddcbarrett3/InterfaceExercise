using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car = new Car();
            car.HasTrunk = true;
            car.DriveType = "Front Wheel Drive";
            car.SeatingCapacity = 4;
            car.TireSize = "28\"";
            car.EngineDisplacement = 2.5;
            car.ExteriorColor = "Red";

            Truck truck = new Truck();
            truck.BedLength = 6.5;
            truck.IsFourWheelDrive = true;
            truck.SeatingCapacity = 5;
            truck.TireSize = "33\"";
            truck.EngineDisplacement = 6.7;
            truck.ExteriorColor = "Black";

            SUV sUV = new SUV();
            sUV.HasChildDoorLocks = true;
            sUV.CargoCapacity = 3.2;
            sUV.SeatingCapacity = 7;
            sUV.TireSize = "31\"";
            sUV.EngineDisplacement = 5.0;
            sUV.ExteriorColor = "Green";

            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(sUV);

            foreach (var item in vehicles)
            {
                if (item == car && car.HasTrunk)
                {
                    Console.WriteLine($"The {item.ExteriorColor} car can seat {item.SeatingCapacity} people comfortably and cruises down the road with a {item.EngineDisplacement} Liter engine.");
                    Console.WriteLine($"This car comes with brand new {item.TireSize} tires and has {car.DriveType} with a trunk.");
                }
                if (item == truck && truck.IsFourWheelDrive) 
                {
                    Console.WriteLine($"The {item.ExteriorColor} truck can seat {item.SeatingCapacity} people comfortably and cruises down the road with a {item.EngineDisplacement} Liter engine.");
                    Console.WriteLine($"This truck comes with brand new {item.TireSize} tires and has 4WD with a {truck.BedLength} foot bed.");
                }
                if (item == sUV && sUV.HasChildDoorLocks) 
                {
                    Console.WriteLine($"The {item.ExteriorColor} SUV can seat {item.SeatingCapacity} people comfortably and cruises down the road with a {item.EngineDisplacement} Liter engine.");
                    Console.WriteLine($"This SUV comes with brand new {item.TireSize} tires and has child door locks with a cargo capacity of {sUV.CargoCapacity} cubic feet.");
                }
                Console.WriteLine();
            }

            

        }
    }
}
