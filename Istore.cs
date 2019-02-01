using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    public interface Istore
    {
        void visit(IVisiter visiter);
    }
    public interface IVisiter
    {
        void Accept(Car car);
        void Accept(BIke bIke);
    }
    public class Car : Istore
    {
        public string CarName { get; set; }
        public decimal price { get; set; }
        public string CarType { get; set; }

        public void visit(IVisiter visiter)
        {
            visiter.Accept(this);
        }
    }
    public class BIke : Istore
    {
        public string BikeName { get; set; }
        public decimal price { get; set; }
        public string BikeType { get; set; }

        public void visit(IVisiter visiter)
        {
            visiter.Accept(this);
        }
    }
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
            decimal BikePriceAfterDis = bIke.price - ((bIke.price / 100) * Bike_dis);
            Console.WriteLine("BIKE {0} price {1}", bIke.price, BikePriceAfterDis);
        }
    }

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