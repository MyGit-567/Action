using ActionProject;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ActionProject
{
    class Auction : Iauction
    {
        ConcurrentBag<InterfaceAgent> wantbuy = new ConcurrentBag<InterfaceAgent> { };
        public int JumpPrice { get; set; }
        public int CurrentPrice { get; set; }

        public DateTime StartDatime { get; set; }
        public InterfaceAgent CurrentWinnerAgent { get; set; }
        public Iproduct Product { get; set; }
        public Auction(int startPrice, int jumpPrice, DateTime startDatime , Iproduct product)
        {
            JumpPrice = jumpPrice;
            CurrentPrice = startPrice;
            StartDatime = startDatime;
            Product = product;
        }

        private string agent10 = "";
        public void addtolist(InterfaceAgent agent)
        {
            wantbuy.Add(agent);
        }

        public bool CheckTheprice (int price)
        {
            if(price > CurrentPrice + JumpPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Newpricefromagent(int cost)
        {
            int count = 0;
            while (count < 100)
            {
                foreach (var agent in wantbuy)
                {
                    var obj = agent;
                    Task.Factory.StartNew(itsobject =>
                    {
                        bool answer = ((InterfaceAgent)itsobject).Suggestion();
                        if (answer)
                        {
                            int price = agent.Newprice();
                            bool check = CheckTheprice(price); //validate the offer price
                            if (check)
                            {
                                CurrentPrice = price; // update the current price
                                agent10 = agent.agentname;
                            }
                        }
                        
                    }, obj);
                }
                count++;              
            }
                Console.WriteLine("The winner is:" + agent10 + "The product is sold at: " + CurrentPrice);            
        }
    }
}
