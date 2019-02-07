using System;

namespace GearboxCommons.Classes
{
    public class Tire
    {
        public int WidthMm { get; set; }
        public int AspectRatio { get; set; }
        public int RimDiameterInch { get; set; }

        private double _tireDiameterM()
        {
            var aspectRatioMm = WidthMm * (AspectRatio / 100);
            var rimDiameterMm = RimDiameterInch * 25.4;

            return (rimDiameterMm + (2 * aspectRatioMm)) / 1000;
        }

        public double TireRollingCircumferenceM()
        {
            return _tireDiameterM() * Math.PI;
        }
    }
}