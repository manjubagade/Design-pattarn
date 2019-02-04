//-----------------------------------------------------------------------
// <copyright file="SingleTonExp.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace SingleToneDemo
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// this is SingleTonExp design pattern
    /// </summary>
    public class SingleTonExp
    {
        /// <summary>
        /// the SingleToneExp pattern this instance
        /// </summary>
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