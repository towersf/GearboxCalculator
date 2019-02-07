using GearboxCommons.Classes;

namespace GearboxCalculatorCore.Classes
{
    public class SpeedCalculator
    {
        public GearRatio GearRatioDeltaSpeed(GearRatio marcia, GearRatio finale, Tire ruota, Engine engine)
        {
            marcia.MinSpeed = _calculateSpeed(marcia, finale, ruota, engine.RefRpm);
            marcia.MaxSpeed = _calculateSpeed(marcia, finale, ruota, engine.MaxRpm);

            return marcia;
        }

        private decimal _calculateSpeed(GearRatio marcia, GearRatio finale, Tire ruota, int rpm)
        {
            var gearBoxExitRpm = rpm / marcia.GearRatioNumber();

            var tireRpm = gearBoxExitRpm / finale.GearRatioNumber();

            var vehicleSpeedMeterMinute = tireRpm * ruota.TireRollingCircumferenceM();

            return (decimal) (vehicleSpeedMeterMinute / 1000) * 60;
        }

    }
}