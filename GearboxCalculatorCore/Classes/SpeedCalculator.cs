namespace GearboxCalculatorCore.Classes
{
    public class SpeedCalculator
    {
        public GearRatio Rapporto;
        public GearRatio Finale;
        public Tire Ruota;
        public Engine Engine;

        public SpeedCalculator()
        {
            Rapporto = new GearRatio();
            Ruota = new Tire();
            Engine = new Engine();
        }

        public double GearRatioMaxSpeedKmh()
        {
            var gearBoxExitRpm = Engine.RefRpm / Rapporto.GearRatioNumber();
            var tireRpm = gearBoxExitRpm / Finale.GearRatioNumber();
            var vehicleSpeedMeterMinute = tireRpm * Ruota.TireRollingCircumferenceM();
            return (vehicleSpeedMeterMinute / 1000) * 60;
        }

    }
}