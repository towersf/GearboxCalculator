namespace GearboxCalculatorCore.Classes
{
    public class GearRatio
    {
        public int GearA { get; set; }
        public int GearB { get; set; }

        public float GearRatioNumber()
        {
            return GearB / GearA;
        }
    }
}