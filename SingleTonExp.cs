using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    public class SingleTonExp
    {
        public void SingleToneExp()
        {
            Parallel.Invoke(
                () => PrintDetails2(),
                () => PrintDetails1()
                );
            //Console.ReadKey();
        }

        private static void PrintDetails1()
        {
            SingleTone s1 = SingleTone.GetInstance;
            s1.PrintDetails("HOW ARE YOU");
        }

        private static void PrintDetails2()
        {
            SingleTone s2 = SingleTone.GetInstance;
            s2.PrintDetails("HI HELLO");
        }
    }
}