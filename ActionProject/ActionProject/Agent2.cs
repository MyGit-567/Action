
using System;


namespace ActionProject
{
    public class Agent2 : IAgent
    {
        private Randomclass _randomclass2;
        public string Name => "agent2";

        public Agent2()
        {
            _randomclass2 = new Randomclass();
        }

        public bool Participantion(Iauction add)
        {
            return _randomclass2.RandomBool();
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
            return _randomclass2.RandomBool();
        }

    }
}
