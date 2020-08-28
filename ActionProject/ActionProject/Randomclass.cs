using System;
using System.Collections.Generic;
using System.Text;

namespace ActionProject
{
    public class Randomclass 
    {
        public bool RandomBool()
        {
            Random _random = new Random();
            double num = _random.NextDouble();
            return num > 0.5;
        }
    }
}

