

namespace ActionProject
{
    public interface IAgent
    {        
        public bool Participantion(Iauction add);
        public int Newprice();
        public bool Suggestion();
        public string Name { get;  }
    }
}
