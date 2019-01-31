﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    class TestFactory
    {
        public void TestFFac()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(50);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(60);

            IFactory s = factory.GetVehicle("car");
            s.Drive(90);
        }
    }
}
