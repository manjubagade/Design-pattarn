using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    public class TestVisiter
    {
        public void TestVihicle()
        {

            List<Istore> store = new List<Istore>();
            store.Add(new Car() { CarName = "A1", price = 200M, CarType = "MArcedes" });
            store.Add(new Car() { CarName = "A2", price = 100M, CarType = "HONDACITY" });

            store.Add(new BIke() { BikeName = "B1", price = 200, BikeType = "BULLET" });
            store.Add(new BIke() { BikeName = "B2", price = 250, BikeType = "HONDA" });

            //Show price of each item
             PriceVisiter pv = new PriceVisiter();
            foreach (var element in store)
            {
                element.visit(pv);
            }
            Console.WriteLine("");
            //Show weight of each item
            WeightVisiter  wv= new WeightVisiter();
            foreach (var element in store)
            {
                element.visit(wv);
            }
            Console.WriteLine("");
            Mileage ml = new Mileage();
            foreach (var element in store)
            {
                element.visit(ml);
            }

            Console.ReadLine();

        }
    }
}

