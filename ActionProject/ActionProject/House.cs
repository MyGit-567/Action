using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ActionProject
{
    public class House
    {
        public int airConditioner { get; }
        public int safeRoom { get; }
        public bool highway { get; }
        public bool accessfordisabled { get; }
        public int toilet { get; }
        public int diningroom { get; }

        public House(int AirConditioner, int SafeRoom, bool Hithway, bool Accessfordisabled, int Toilet, int Diningroom)
        {
            airConditioner = AirConditioner;
            safeRoom = SafeRoom;
            highway = Hithway;
            accessfordisabled = Accessfordisabled;
            toilet = Toilet;
            diningroom = Diningroom;
        }

        public void DescriptionAttribute()
        {
            Console.WriteLine("1.aircondishiner" = airConditioner);
            Console.WriteLine("2.saferoom" = safeRoom);
            Console.WriteLine("3.highway" = highway);
            Console.WriteLine("4.access for disables" = accessfordisabled);
            Console.WriteLine("5.toilet" = toilet);
            Console.WriteLine("6.dining room" + diningroom);
        }

    }
}
