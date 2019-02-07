using GearboxCalculatorCore.Classes;

namespace GearboxCommons.Classes
{
    public class GearBox
    {
        public GearRatio Prima;
        public GearRatio Seconda;
        public GearRatio Terza;
        public GearRatio Quarta;
        public GearRatio Quinta;
        public GearRatio Sesta;
        public GearRatio Settima;

        public GearRatio Finale;

        public GearBox()
        {
            Prima = new GearRatio();
            Seconda = new GearRatio();
            Terza = new GearRatio();
            Quarta = new GearRatio();
            Quinta = new GearRatio();
            Sesta = new GearRatio();
            Settima = new GearRatio();

            Finale = new GearRatio();
        }
    }
}