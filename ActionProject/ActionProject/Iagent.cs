using System;
using System.Collections.Generic;
using System.Text;

namespace ActionProject
{
    public interface InterfaceAgent
    {
        public void getstartcost(int num);
        public void abouttheproduct(string description);
        public void nameofproduct(string name);
        public void AuctionStart(Iproduct product);
        public bool Participantion(Iauction add);
        public void getsellgap(int number);
        public int Newprice();
        public bool Suggestion();
        public string agentname { get;  }
        public void Messages(string message);


    }
}
