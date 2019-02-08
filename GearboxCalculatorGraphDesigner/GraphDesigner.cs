using System;
using System.Drawing;
using GearboxCommons.Classes;

namespace GearboxCalculatorGraphDesigner
{
    public class GraphDesigner
    {
        private Graphics _drawing;

        private Pen _pen;
        public Image DisegnaGrafico(OutputData datiCalcolati)
        {
            var img = new Bitmap(355, 443);

            _drawing = Graphics.FromImage(img);

            _pen = new Pen(Color.Black);

            _drawGearLine(datiCalcolati.Prima);
            _drawGearLine(datiCalcolati.Seconda);
            _drawGearLine(datiCalcolati.Terza);
            _drawGearLine(datiCalcolati.Quarta);
            _drawGearLine(datiCalcolati.Quinta);
            _drawGearLine(datiCalcolati.Sesta);
            _drawGearLine(datiCalcolati.Settima);
            
            //_disegnaAsseX()
            //_disegnaAsseY()
            //_disegnaMarce();

            return img;
        }

        private void _drawGearLine(GearRatio gear)
        {
            if (gear.Enable)
            {
                _drawing.DrawLine(_pen, (int)gear.MinSpeed, 0, (int)gear.MaxSpeed, 6800);
            }
        }
    }
}
