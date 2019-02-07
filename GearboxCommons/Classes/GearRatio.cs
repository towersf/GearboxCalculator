namespace GearboxCommons.Classes
{
    public class GearRatio
    {
        public int GearA { get; set; }
        public int GearB { get; set; }
        public int Enable { get; set; }
        public decimal MinSpeed { get; set; }
        public decimal MaxSpeed { get; set; }

        public float GearRatioNumber()
        {
            return GearB / (float)GearA;
        }
    }
}