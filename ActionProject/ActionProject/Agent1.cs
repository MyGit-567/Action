using System;


namespace ActionProject
{

    public class Agent1 : IAgent
    {
        private Randomclass _randomclass;
        public string Name => "agent1";

        public Agent1()
        {
            _randomclass = new Randomclass();
        }
     
        public bool Participantion(Iauction add)
        {
            return _randomclass.RandomBool();
        }

        public int Newprice()
        {
            Random _random8 = new Random();
            int num8 = _random8.Next(600);
            Console.WriteLine($"{Name} suggested {num8}");
            return num8;
        }

        public bool Suggestion()
        {
            return _randomclass.RandomBool();

        }    
    }    
}
