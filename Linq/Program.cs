using System;
using System.Collections.Generic;
using System.Linq;

namespace CathyLinq
{
    class Car
    {
        // auto set properties
        public String Make { get; set; }
        public String Model { get; set; }
        public String Registration { get; set; }
        public int EngineSize { get; set; }

        public override string ToString()
        {
            return "This car is a " + Make + " " + Model + "\n"
                + " : Reg: " + Registration + " : with an EngineSize of: " + EngineSize + "cc";
        }

        // constructor

        public Car(String make, String model, String reg, int engSize)
        {
            Make = make;
            Model = model;
            Registration = reg;
            EngineSize = engSize;
        }

    }
}
