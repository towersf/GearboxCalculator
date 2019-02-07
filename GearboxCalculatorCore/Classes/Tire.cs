using System;

namespace GearboxCalculatorCore.Classes
{
    public class Tire
    {
        public int widthMm { get; set; }
        public int aspectRatio { get; set; }
        public int rimDiameterInch { get; set; }

        private double _TireDiameterM()
        {
            var aspectRatioMm = widthMm * (aspectRatio / 100);
            var rimDiameterMm = rimDiameterInch * 25.4;

            return (rimDiameterMm + (2 * aspectRatioMm)) / 1000;
        }

        public double TireRollingCircumferenceM()
        {
            return _TireDiameterM() * Math.PI;
        }
    }
}