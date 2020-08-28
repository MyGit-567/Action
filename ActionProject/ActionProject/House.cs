
namespace ActionProject
{
    public class House : Iproduct
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

        public string Description()
        {
            var sb = new System.Text.StringBuilder();

            sb.AppendLine($"1.aircondishiner {airConditioner}");
            sb.AppendLine($"2.saferoom  {safeRoom}");
            sb.AppendLine($"3.highway { highway}");
            sb.AppendLine($"4.access for disables { accessfordisabled}");
            sb.AppendLine($"5.toilet {toilet}");
            sb.AppendLine($"6.dining room {diningroom}");

            return sb.ToString();
        }

        public string name()
        {
            return "bla";
        }        
    }
}
