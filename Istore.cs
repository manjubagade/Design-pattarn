

namespace SingleToneDemo
{
    using System;

    /// <summary>
    /// this is interfave IStore
    /// </summary>
    public interface IStore
    {
        /// <summary>
        /// Visits the specified visiter.
        /// </summary>
        /// <param name="visiter">The visiter.</param>
        void Visit(IVisiter visiter);
    }

    /// <summary>
    /// this is Interface IVisiter
    /// </summary>
    public interface IVisiter
    {
        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        void Accept(Car car);
        /// <summary>
        /// Accepts the specified b ike.
        /// </summary>
        /// <param name="bIke">The b ike.</param>
        void Accept(BIke bIke);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SingleToneDemo.IStore" />
    public class Car : IStore
    {
        /// <summary>
        /// Gets or sets the name of the car.
        /// </summary>
        /// <value>
        /// The name of the car.
        /// </value>
        public string CarName { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal price { get; set; }

        /// <summary>
        /// Gets or sets the type of the car.
        /// </summary>
        /// <value>
        /// The type of the car.
        /// </value>
        public string CarType { get; set; }

        /// <summary>
        /// Visits the specified visiter.
        /// </summary>
        /// <param name="visiter">The visiter.</param>
        public void Visit(IVisiter visiter)
        {
            visiter.Accept(this);
        }
    } 

    /// <summary>
    /// this is Bike class
    /// </summary>
    /// <seealso cref="SingleToneDemo.IStore" />
    public class BIke : IStore
    {
        /// <summary>
        /// Gets or sets the name of the bike.
        /// </summary>
        /// <value>
        /// The name of the bike.
        /// </value>
        
        public string BikeName { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the type of the bike.
        /// </summary>
        /// <value>
        /// The type of the bike.
        /// </value>
        public string BikeType { get; set; }

        /// <summary>
        /// Visits the specified visiter.
        /// </summary>
        /// <param name="visiter">The visiter.</param>
        public void Visit(IVisiter visiter)
        {
            visiter.Accept(this);
        }
    }
    /// <summary>
    /// this class  PriceVisiter 
    /// </summary>
    /// <seealso cref="SingleToneDemo.IVisiter" />
    public class PriceVisiter : IVisiter
    {
        private const int Car_Dis = 5;
        private const int Bike_dis = 2;
        public void Accept(Car car)
        {
            decimal CarPriceAfterDis = car.price - ((car.price / 100) * Car_Dis);
            Console.WriteLine("CAR {0} price {1} ", car.price, CarPriceAfterDis);

        }
        public void Accept(BIke bIke)
        {
            decimal BikePriceAfterDis = bIke.Price - ((bIke.Price / 100) * Bike_dis);
            Console.WriteLine("BIKE {0} price {1}", bIke.Price, BikePriceAfterDis);
        }
    }
    /// <summary>
    /// this is WeightVisiter Class
    /// </summary>
    /// <seealso cref="SingleToneDemo.IVisiter" />
    public class WeightVisiter : IVisiter
    {
        public void Accept(Car car)
        {
            switch (car.CarType)
            {
                case "MArcedes":
                    Console.WriteLine("THE CAR {0} WEIGHT {1} kg ", car.CarName, 2000);
                    break;
                case "HONDACITY":
                    Console.WriteLine("THE CAR {0} WEIGHT {1} Kg ", car.CarName, 1500);
                    break;
            }

        }
        /// <summary>
        /// Accepts the specified b ike.
        /// </summary>
        /// <param name="bIke">The b ike.</param>
        public void Accept(BIke bIke)
        {
            switch (bIke.BikeType)
            {
                case "BULLET":
                    Console.WriteLine("THE BIKE {0} WEIGHT {1} kg ", bIke.BikeName, 800);
                    break;
                case "HONDA":
                    Console.WriteLine("THE BIKE {0} WEight {1} kg ",bIke.BikeName,350);
                    break;
            }
        }
    }
    /// <summary>
    /// this class mileage
    /// </summary>
    /// <seealso cref="SingleToneDemo.IVisiter" />
    public class Mileage : IVisiter
    {
        public void Accept(Car car)
        {
            switch (car.CarType)
            {
                case "MArcedes":
                    Console.WriteLine("THE CAR {0} Mileage {1} kmph ", car.CarName, 40);
                     break;
                case "HONDACITY":
                    Console.WriteLine("THE CAR {0} Mileage {1} kmph ", car.CarName, 60);
                    break;
            }

        }
        /// <summary>
        /// Accepts the specified b ike.
        /// </summary>
        /// <param name="bIke">The b ike.</param>
        public void Accept(BIke bIke)
        {
            switch (bIke.BikeType)
            {
                case "BULLET":
                    Console.WriteLine("THE BIKE {0} mileage {1} kmph ", bIke.BikeName, 55);
                    break;
                case "HONDA":
                    Console.WriteLine("THE BIKE {0} mileage {1} kmph ", bIke.BikeName, 75);
                    break;
            }
        }
    }
}