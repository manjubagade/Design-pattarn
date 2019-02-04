//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
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
    /// <summary>
    /// this class for Scooter
    /// </summary>
   
    public class Scooter : IFactory
    {
        /// <summary>
        /// this drive for Scooter this instance
        /// </summary>
        /// <param name="miles"></param>
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
    /// <summary>
    /// this class for Bike
    /// </summary>
    public class Bike : IFactory
    {
        /// <summary>
        /// this Drive For Bike this instance
        /// </summary>
        /// <param name="miles"></param>
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }
    /// <summary>
    /// this class for car
    /// </summary>
    public class car : IFactory
    {
        /// <summary>
        /// this car Drive for this instance
        /// </summary>
        /// <param name="miles"></param>
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike  :" + miles.ToString() + "km");
        }
    }
    /// <summary>
    /// this class for trian
    /// </summary>
    public class Train :IFactory
    {
        /// <summary>
        /// this train Drive for instance
        /// </summary>
        /// <param name="miles"></param>
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the train : " + miles.ToString() + "km");
        }
    }
    /// <summary>
    /// this class abstract class for VehicleFactory
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
    /// <summary>
    /// this class concreateVehicleFactory 
    /// </summary>
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
                case "Train":
                    return new Train();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }
}
