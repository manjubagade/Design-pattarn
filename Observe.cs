using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    class Observe
    {
        public void ObservePattarn()
        {
            Product Laptop = new Product("Sony", 20000);
            Console.WriteLine("--------Customer 1 and Customer 2  and  customer 3 is subscribed to the Laptop Product----------");
            // attach or subscribe customer 1
            Customer Customer1 = new Customer("customer 1");
            Laptop.Subscribe(Customer1);
            // attach or subscribe customer 2
            Customer Customer2 = new Customer("customer 2");
            Laptop.Subscribe(Customer2);
            // publish notification to the subscribers
            Laptop.price = 16000;
 
            Console.WriteLine("--------customer 2 is unsubscribed and customer 3 is subscribed to the Laptop Product----------");
            // customer 2 is unsubscribed and customer 3 is subscribed
            Laptop.Unsubscribe(Customer2);
            Customer Customer3 = new Customer("customer 3");
            Laptop.Subscribe(Customer3);
            Laptop.price = 14500;
            Console.ReadLine();
        }
    }
}
