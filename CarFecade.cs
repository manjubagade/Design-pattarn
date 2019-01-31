using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
        public class CarFecade1
        {
         private  CarModel model;
           private CarEngine engine;
            private CarBody body;
           private CarAccessories accssores;

            public CarFecade1()
        {
                model = new CarModel();
                engine = new CarEngine();
                body = new CarBody();
                accssores = new CarAccessories();
            }
            public void CompleteDetails()
            {
                model.SetModel();
                engine.SetEngine();
                body.SetBoby();
                accssores.SetAccssories();
            }
        }
}

