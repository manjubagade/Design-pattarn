using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    public interface Imath
    {
        double add(double x, double y);
        double sub(double x, double y);
        double mal(double x, double y);
        double div(double x, double y);

    }
    public class math : Imath
    {
        public double add(double x, double y)
        {
            return x + y;
        }

        public double sub(double x, double y)
        {
            return x - y;
        }

        public double mal(double x, double y)
        {
            return x * y;
        }

        public double div(double x, double y)
        {
            return x / y;
        }
    }
    public class MathProxy : Imath

    {
        private math m = new math();
        public double add(double x, double y)
        {
            return m.add(x, y);
        }

        public double div(double x, double y)
        {
            return m.sub(x, y);
        }

        public double mal(double x, double y)
        {
            return m.mal(x, y);
        }

        public double sub(double x, double y)
        {
            return m.div(x,y);
        }
    }
}

 