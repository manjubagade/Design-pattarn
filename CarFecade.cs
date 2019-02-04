//-----------------------------------------------------------------------
// <copyright file="CarFecade1.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace SingleToneDemo
{
    using System;

    /// <summary>
    /// this CarFecade1 class
    /// </summary>
    public class CarFecade1
        {
         private  CarModel model;
           private CarEngine engine;
            private CarBody body;
           private CarAccessories accssores;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFecade1"/> class.
        /// </summary>
        public CarFecade1()
        {
                model = new CarModel();
                engine = new CarEngine();
                body = new CarBody();
                accssores = new CarAccessories();
            }
        /// <summary>
        /// Completes the details.
        /// </summary>
        public void CompleteDetails()
            {
                model.SetModel();
                engine.SetEngine();
                body.SetBoby();
                accssores.SetAccssories();
            }
        }
}

