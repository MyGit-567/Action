using ActionProject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesManager
{
    public class Management
    {
        public List<Iproduct> _products = new List<Iproduct> { };
        public List<IAgent> _agents = new List<IAgent> { };

        public List<Iauction> Auctions { get; set; }


        public Management(List<Iauction> auctions)
        {
            Auctions = auctions;
        }

        public void Participante()
        {
            List<Task> taks = new List<Task>();

            foreach (var auction in Auctions)
            {

                foreach (var agent in _agents)
                {
                    var obj = agent;
                    taks.Add(Task.Factory.StartNew(itsobject =>
                    {
                        bool answer = ((IAgent)itsobject).Participantion(auction);

                        if (answer)
                        {
                            auction.addtolist(agent);
                        }

                    }, obj));
                }
            }
            Task.WaitAll(taks.ToArray());
        }       
    }
}
