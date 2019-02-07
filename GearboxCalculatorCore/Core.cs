using GearboxCalculatorCore.Classes;
using GearboxCalculatorGraphDesigner;
using System;

namespace GearboxCalculatorCore
{
    public class Core
    {
        private GraphDesigner _designer;

        public Core()
        {
            _designer = new GraphDesigner();
        }
        

        public RatioCalculatorResult CalcolaGearbox(SpeedCalculator data)
        {
            var datiCalcolati = _calcolaDati(data);

            var image = _designer.DisegnaGrafico(datiCalcolati);

            return new RatioCalculatorResult
            {
                Dati = datiCalcolati,
                GraphImage = image,
            };
            
        }

        private object _calcolaDati(SpeedCalculator data)
        {

            return new object();
        }
    }
}
