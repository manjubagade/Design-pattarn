using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
  public  interface IClint
    {
        string Getdata();
    }
    public class RealClient : IClint
    {
        string data;
        public RealClient()
        {
            Console.WriteLine("THE REALCLINT IS : 1");
            data = "HELLO MANJU";

        }
        public String Getdata()
        {
            return data;
        }
    }
    public class ProXyClint : IClint
    {
        RealClient clint = new RealClient();
        public ProXyClint()
        {
            Console.WriteLine("THE PXOXY CLINT :2");
        }
        public String Getdata()
        {
            return clint.Getdata();
        }
    }
}
