using ActionProject;
using System;

namespace SalesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent1 agent1 = new Agent1();
            Agent2 agent2 = new Agent2();
            Agent3 agent3 = new Agent3();
            Product1 product1 = new Product1();
            Product2 product2 = new Product2();
            Management management = new Management();
            management._agents.Add(agent1);
            management._agents.Add(agent2);
            management._agents.Add(agent3);
            management._products.Add(product1);
            management._products.Add(product2);

        }
    }
}
