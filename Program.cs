using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = null;
            do
            {
                Console.WriteLine("PRESS 1 TO SINGLETONE DESIGN PATTARN");
                Console.WriteLine("PRESS 2 TO FACTORY PATTARNA");
                Console.WriteLine("PRESS 3 TO ADAPTER DESIGN PATTARN");
                Console.WriteLine("PRESSS 4 TO FACADE PATTERN ");
                Console.WriteLine("PRESS 5 TO PrOXY DESIGN PATTARN");
                Console.WriteLine("PRESS 6 TO PROXY DESIGN");
                Console.WriteLine("PRESS 7");
                Console.WriteLine("PRESS 8");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        SingleTonExp se = new SingleTonExp();
                        se.SingleToneExp();
                        break;
                    case 2:
                        TestFactory tf = new TestFactory();
                        tf.TestFFac();
                        break;
                    case 3:
                        TestAdp td = new TestAdp();
                        td.Testadpt();
                        break;
                    case 4:
                        CarFecade1 facade = new CarFecade1();
                        facade.CompleteDetails();
                        break;
                    case 5:
                        ProXyClint pc = new ProXyClint();
                        pc.Getdata();
                        break;
                    case 6:
                        MathProxy m = new MathProxy();
                       Console.WriteLine(+ m.add(4,2));
                       Console.WriteLine(+ m.sub(10, 2));
                       Console.WriteLine(+  m.mal(10, 6));
                       Console.WriteLine(+  m.div(10, 2));
                        break;
                    case 7:
                        IBM ibm = new IBM("IBM", 120.00);
                        ibm.Attach(new Investor("Sorros"));
                        ibm.Attach(new Investor("Berkshire"));

                        // Fluctuating prices will notify investors
                        ibm.Price = 120.10;
                        ibm.Price = 121.00;
                        ibm.Detach(new Investor("Sorros"));
                        ibm.Detach(new Investor("Berkshire"));

                        Googgle go = new Googgle("google", 100.00);
                        go.Attach(new Investor(" google Keep"));
                        go.Attach(new Investor("GooglePay"));

                        // Fluctuating prices will notify investors

                        go.Price = 110.10;
                        go.Price = 115.00;
                        break;
                    case 8:
                        Observe o = new Observe();
                        o.ObservePattarn();
                        break;




                }
                Console.WriteLine();
                Console.WriteLine("ENTER THE Y FOR CONTINUE");
                flag = Console.ReadLine();

            }
            while (flag=="y");

        }
    }
}
