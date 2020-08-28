using System;



namespace ActionProject 
{
    public class Agent3 : IAgent
    {
        private Randomclass _randomclass3;
        public string Name => "agent3";
        public Agent3()
        {
            _randomclass3 = new Randomclass();
        }

        public bool Participantion(Iauction add)
        {
            return _randomclass3.RandomBool();
        }
     
        public int Newprice()
        {
            Random _random8 = new Random();
            int num8 = _random8.Next(800);
            Console.WriteLine($"{Name} suggested {num8}");
            return num8;
        }

        public bool Suggestion()
        {
            return _randomclass3.RandomBool();

        }

    }
     
}
