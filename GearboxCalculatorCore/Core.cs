using GearboxCalculatorCore.Classes;
using GearboxCalculatorGraphDesigner;
using System;
using GearboxCommons.Classes;

namespace GearboxCalculatorCore
{
    public class Core
    {
        private GraphDesigner _designer;
        private SpeedCalculator _speedCalculator;

        public Core()
        {
            _designer = new GraphDesigner();
            _speedCalculator = new SpeedCalculator();
        }


        public RatioCalculatorResult CalcolaGearbox(InputData data)
        {
            var datiCalcolati = _calcolaDati(data);

            var image = _designer.DisegnaGrafico(datiCalcolati);

            return new RatioCalculatorResult
            {
                Dati = datiCalcolati,
                GraphImage = image,
            };

        }

        private OutputData _calcolaDati(InputData data)
        {
            var output = new OutputData();

            output.Prima = _speedCalculator.GearRatioDeltaSpeed(data.Cambio.Prima, data.Cambio.Finale, data.Tire, data.Engine);
            output.Seconda = _speedCalculator.GearRatioDeltaSpeed(data.Cambio.Seconda, data.Cambio.Finale, data.Tire, data.Engine);
            output.Terza = _speedCalculator.GearRatioDeltaSpeed(data.Cambio.Terza, data.Cambio.Finale, data.Tire, data.Engine);
            output.Quarta = _speedCalculator.GearRatioDeltaSpeed(data.Cambio.Quarta, data.Cambio.Finale, data.Tire, data.Engine);
            output.Quinta = _speedCalculator.GearRatioDeltaSpeed(data.Cambio.Quinta, data.Cambio.Finale, data.Tire, data.Engine);
            output.Sesta = _speedCalculator.GearRatioDeltaSpeed(data.Cambio.Sesta, data.Cambio.Finale, data.Tire, data.Engine);
            output.Settima = _speedCalculator.GearRatioDeltaSpeed(data.Cambio.Settima, data.Cambio.Finale, data.Tire, data.Engine);

            return output;
        }
    }
}
