using GearboxCalculatorCore.Classes;

namespace GearboxCommons.Classes
{
    public class InputData
    {
        public GearBox Cambio;
        public Tire Tire;
        public Engine Engine;

        public InputData()
        {
            Cambio = new GearBox();
            Tire = new Tire();
            Engine = new Engine();
        }

    }
}