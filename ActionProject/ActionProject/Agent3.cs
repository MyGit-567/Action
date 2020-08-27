using System;
using System.Collections.Generic;
using System.Text;

namespace ActionProject 
{
    public class Agent3 : InterfaceAgent
    {
        public string agentname => "agent3";
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

        public bool Participantion(Iauction add)
        {
            Random _random7 = new Random();
            double num7 = _random7.NextDouble();
            return num7 > 0.5;
        }

        public void getsellgap(int number)
        {

        }

        public int Newprice()
        {
            Random _random8 = new Random();
            int num8 = _random8.Next(800);
            return num8;
        }

        public bool Suggestion()
        {
            Random _random9 = new Random();
            double num9 = _random9.NextDouble();
            return num9 > 0.5;

        }

        public void AuctionStart(Iproduct product)
        {

        }

        public void Messages(string message)
        {

        }


    }
     
}
