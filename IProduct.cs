//-----------------------------------------------------------------------
// <copyright file="IProduct.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace SingleToneDemo
{
    using System;
    using System.Collections.Generic; 
    
    /// <summary>
    /// this is interface class 
    /// </summary>
    
       interface IProduct
    {
        /// <summary>
        /// this Subscribe method
        /// </summary>
        /// <param name="customer"></param>
        void Subscribe(Customer customer);

        /// <summary>
        /// this UnSubscribe method
        /// </summary>
        /// <param name="customer"></param> 
        void UnSubscribe(Customer customer);

        /// <summary>
        /// this Notify method
        /// </summary>
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
      
        /// <summary>
        /// 
        /// </summary>
        public float Price
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        public void UnSubscribe(Customer customer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    interface ICustomer
    {
        void Update(Product product);
    }
    public class Customer : ICustomer
    {
        string name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
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
