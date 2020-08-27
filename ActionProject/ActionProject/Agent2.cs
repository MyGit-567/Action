
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionProject
{
    public class Agent2 : InterfaceAgent
    {
        public string agentname => "agent2";
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
            Random _random8 = new Random();
            double num8 = _random8.NextDouble();
            return num8 > 0.5;
        }

        public void getsellgap(int number)
        {

        }

        public int Newprice()
        {
            Random _random8 = new Random();
            int num8 = _random8.Next(600);
            return num8;
        }

        public void AuctionStart(Iproduct product)
        {
            throw new NotImplementedException();
        }


        public bool Suggestion()
        {
            Random _random9 = new Random();
            double num9 = _random9.NextDouble();
            return num9 > 0.5;
        }

       
    }
}
