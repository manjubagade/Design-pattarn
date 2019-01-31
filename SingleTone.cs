using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
   public sealed class SingleTone
    {
        private static int count = 10;
        private static readonly Lazy<SingleTone> instance = new Lazy<SingleTone>(()=> new SingleTone());
        //private static readonly object obj = new object();
        public static SingleTone GetInstance
        {
            get 
            {
               //// if (instance == null)
                ////{
                    ////lock (obj)
                    ////{
                        ////if (instance == null)
                            ////instance = new SingleTone();
                    ////}
                ////}
                return instance.Value;
            }
            
        }
        private SingleTone()
        {
            count++;
            Console.WriteLine("THE COUNTER values  " + count.ToString());
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
       
    }

}
