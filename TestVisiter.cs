

namespace SingleToneDemo
{
    using System;
    using System.Collections.Generic;

    public class TestVisiter
    {
        public void TestVihicle()
        {

            List<IStore> store = new List<IStore>();
            store.Add(new Car() { CarName = "A1", price = 200M, CarType = "MArcedes" });
            store.Add(new Car() { CarName = "A2", price = 100M, CarType = "HONDACITY" });

            store.Add(new BIke() { BikeName = "B1", Price = 200, BikeType = "BULLET" });
            store.Add(new BIke() { BikeName = "B2", Price = 250, BikeType = "HONDA" });

            //Show price of each item
             PriceVisiter pv = new PriceVisiter();
            foreach (var element in store)
            {
                element.Visit(pv);
            }
            Console.WriteLine("");
            //Show weight of each item
            WeightVisiter  wv= new WeightVisiter();
            foreach (var element in store)
            {
                element.Visit(wv);
            }
            Console.WriteLine("");
            Mileage ml = new Mileage();
            foreach (var element in store)
            {
                element.Visit(ml);
            }

            Console.ReadLine();

        }
    }
}

