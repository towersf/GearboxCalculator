using System;
using System.Drawing;
using GearboxCommons.Classes;

namespace GearboxCalculatorGraphDesigner
{
    public class GraphDesigner
    {
        private const int IMG_WIDTH = 450;
        private const int IMG_HEIGHT = 350;

        private const int OFFSET_X = 20;
        private const int OFFSET_Y = 20;

        private Color PEN_LAYOUT_COLOR = Color.Black;
        private Color PEN_GEAR_COLOR = Color.Red;

        private Graphics _drawing;

        private Pen _penLayout;
        private Pen _penGear;

        private Point _offset;

        public Image DisegnaGrafico(OutputData datiCalcolati)
        {
            _offset = new Point(OFFSET_X, OFFSET_Y);

            _penLayout = new Pen(PEN_LAYOUT_COLOR);
            _penGear = new Pen(PEN_GEAR_COLOR);
            
            var img = new Bitmap(IMG_WIDTH, IMG_HEIGHT);

            _drawing = Graphics.FromImage(img);
            
            _drawLayout();

            _drawGearLine(datiCalcolati.Prima);
            _drawGearLine(datiCalcolati.Seconda);
            _drawGearLine(datiCalcolati.Terza);
            _drawGearLine(datiCalcolati.Quarta);
            _drawGearLine(datiCalcolati.Quinta);
            _drawGearLine(datiCalcolati.Sesta);
            _drawGearLine(datiCalcolati.Settima);

            return img;
        }

        private void _drawLayout()
        {
            var asseXStart = _getPoint(_offset.X, _offset.Y);
            var asseXEnd = _getPoint(IMG_WIDTH - _offset.X, _offset.Y);
            _drawing.DrawLine(_penLayout, asseXStart, asseXEnd);

            var asseYStart = _getPoint(_offset.X, _offset.Y);
            var asseYEnd = _getPoint(_offset.X, IMG_WIDTH - _offset.Y);
            _drawing.DrawLine(_penLayout, asseYStart, asseYEnd);
        }

        private void _drawGearLine(GearRatio gear)
        {
            if (gear.Enable)
            {
                _drawing.DrawLine(_penGear, (int)gear.MinSpeed, 0, (int)gear.MaxSpeed, 6800);
            }
        }

        private Point _getPoint(int x, int y)
        {
            return new Point(x, IMG_HEIGHT - y);
        }

    }
}
