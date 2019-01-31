﻿using System;

namespace SingleToneDemo
{
    using System;

    /// <summary>
    /// define the interface class
    /// </summary>
    public interface IFactory
    {
        void Drive(int miles);
        
    }
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }

    public class car : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike  :" + miles.ToString() + "km");
        }
    }
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                case "car":
                    return new car();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }
}
