using System;
using System.Collections.Generic;
using System.Text;

namespace ActionProject 
{
    public class Agent3 : InterfaceAgent
    {
        public void abouttheproduct(string description)
        {
            throw new NotImplementedException();
        }


        public void getstartcost(int num)
        {

        }

        public void nameofproduct(string name)
        {
            throw new NotImplementedException();
        }

        public bool Participantion()
        {
            Random _random7 = new Random();
            double num7 = _random7.NextDouble();
            return num7 > 0.5;
        }

        public void getsellgap(int number)
        {

        }

        public bool Newprice(string sentence)
        {
            Random _random8 = new Random();
            double num8 = _random8.NextDouble();
            return num8 > 0.5;
        }

    }
     
}
