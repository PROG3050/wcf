﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICalculatorService
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Mul(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Div(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
