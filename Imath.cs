
namespace SingleToneDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMath
    {
        /// <summary>
        /// Adds the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        double Add(double x, double y);

        /// <summary>
        /// Subs the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        double Sub(double x, double y);
        
        /// <summary>
        /// Mals the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        double Mal(double x, double y);

        /// <summary>
        /// Divs the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        double Div(double x, double y);

    }

    /// <summary>
    /// this class math
    /// </summary>
    /// <seealso cref="SingleToneDemo.IMath" />
    public class Math : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mal(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }
    }
    public class MathProxy : IMath

    {
        private Math m = new Math();
        public double Add(double x, double y)
        {
            return m.Add(x, y);
        }

        public double Div(double x, double y)
        {
            return m.Sub(x, y);
        }

        public double Mal(double x, double y)
        {
            return m.Mal(x, y);
        }

        public double Sub(double x, double y)
        {
            return m.Div(x,y);
        }
    }
}

 