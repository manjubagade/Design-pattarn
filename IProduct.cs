using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
   interface IProduct
    {
        void Subscribe(Customer customer);
        void UnSubscribe(Customer customer);
        void Notify();
    }
    public class Product : IProduct
    {
        string name;
        float basePrice;
        float currentPrice;
        List<Customer> customers = new List<Customer>();
        public Product(string name,float basePrice)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.currentPrice = basePrice;
        }
        public float price
        {
            get
            {
                return currentPrice;
            }
            set
            {
                currentPrice = value;
                if (value <= basePrice)
                    Notify();
            }
        }
        public void Subscribe(Customer customer)
        {
            customers.Add(customer);
        }

        public void Unsubscribe(Customer customer)
        {
            customers.Remove(customer);
        }

        public void Notify()
        {
            foreach (Customer observer in customers)
            {
                observer.Update(this);
            }
        }

        public void UnSubscribe(Customer customer)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return name; }
        }

        public float discount
        {
            get { return (basePrice - currentPrice) * 100 / basePrice; }
        }
        public float CurrentPrice
        {
            get { return currentPrice; }
        }
    }
    interface ICustomer
    {
        void Update(Product product);
    }
    public class Customer : ICustomer
    {
        string name;
        public Customer(string name)
        {
            this.name = name;
        }
        public void Update(Product product)
        {
            Console.WriteLine("{0}: {1} Laptop is now available at {2}; Discount = {3}%", this.name, product.Name, product.CurrentPrice, product.discount);
        }
    }
}
