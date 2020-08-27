using System;
using System.Collections.Generic;
using System.Text;

namespace ActionProject
{
    class House
    {
        public int airConditioner { get; }
        public int safeRoom { get; }
        public bool hithway { get; }
        public bool accessfordisabled { get; }
        public int toilet { get; }
        public int diningroom { get; }

        public House(int AirConditioner, int SafeRoom, bool Hithway, bool Accessfordisabled, int Toilet, int Diningroom)
        {
            airConditioner = AirConditioner;
            safeRoom = SafeRoom;
            hithway = Hithway;
            accessfordisabled = Accessfordisabled;
            toilet = Toilet;
            diningroom = Diningroom;
        }
    }
}
