using ActionProject;
using System;
using System.Collections.Generic;

namespace SalesManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Product1 product1 = new Product1();
            Product2 product2 = new Product2();
            House house1 = new House(3, 1, true, true, 1, 1);


            Auction auction = new Auction(200, 100, DateTime.Now, product1);
            Auction auction2 = new Auction(400, 200, DateTime.Now, product2);
            Auction auction3 = new Auction(400, 200, DateTime.Now, house1);


            List<Iauction> auctions = new List<Iauction>();
            auctions.Add(auction);
            auctions.Add(auction2);

            Agent1 agent1 = new Agent1();
            Agent2 agent2 = new Agent2();
            Agent3 agent3 = new Agent3();

            Management management = new Management(auctions);

            management._agents.Add(agent1);
            management._agents.Add(agent2);
            management._agents.Add(agent3);


            management.Participante();
            auction.Newpricefromagent();
            auction2.Newpricefromagent();
            auction3.Newpricefromagent();

            Console.ReadLine();
            
        }
    }
}
