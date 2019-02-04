//-----------------------------------------------------------------------
// <copyright file="SingleTone.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace SingleToneDemo
{
    using System;

   /// <summary>
   /// the singleTone design pattern 
   /// </summary>
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
        //// the private constracter 
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
