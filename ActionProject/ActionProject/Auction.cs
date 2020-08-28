using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActionProject
{
    public class Auction : Iauction
    {
        private Object _locker = new object();
        ConcurrentBag<IAgent> wantbuy = new ConcurrentBag<IAgent> { };
        public int JumpPrice { get; set; }
        public int CurrentPrice { get; set; }
        public DateTime StartDatime { get; set; }
        public IAgent CurrentWinnerAgent { get; set; }
        public Iproduct Product { get; set; }

        public Auction(int startPrice, int jumpPrice, DateTime startDatime, Iproduct product)
        {
            JumpPrice = jumpPrice;
            CurrentPrice = startPrice;
            StartDatime = startDatime;
            Product = product;
        }

        private string agent10 = "";
        public void addtolist(IAgent agent)
        {
            wantbuy.Add(agent);
        }

        public bool CheckTheprice(int price)
        {
            if (price > CurrentPrice + JumpPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Newpricefromagent()
        {
            int count = 0;
            List<Task> tasks = new List<Task>();
          
            while (count < 100)
            {
                foreach (var agent in wantbuy)
                {
                    var obj = agent;
                    tasks.Add(Task.Factory.StartNew(itsobject =>
                    {
                        lock (_locker)
                        { 
                            bool choice = ((IAgent)itsobject).Suggestion();
                            if (choice)
                            {


                                int price = ((IAgent)itsobject).Newprice();
                                bool check = CheckTheprice(price); //validate the offer price
                                if (check)
                                {
                                    CurrentPrice = price; // update the current price
                                    agent10 = ((IAgent)itsobject).Name;

                                }
                            }
                            
                        }

                    }, obj));
                }
                count++;
            }

            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("The winner is: " + agent10 + " The product is sold at: " + CurrentPrice);
        }
    }
}
