using System;
using System.Drawing;
using GearboxCommons.Classes;

namespace GearboxCalculatorGraphDesigner
{
    public class GraphDesigner
    {
        public Image DisegnaGrafico(OutputData datiCalcolati)
        {
            var img = new Bitmap(355, 443);
            var drawing = Graphics.FromImage(img);

            var pen = new Pen(Color.Black);

            drawing.DrawLine(pen, (int)datiCalcolati.Prima.MinSpeed, 0, (int)datiCalcolati.Prima.MaxSpeed, 6800);
            drawing.DrawLine(pen, (int)datiCalcolati.Seconda.MinSpeed, 0, (int)datiCalcolati.Seconda.MaxSpeed, 6800);
            drawing.DrawLine(pen, (int)datiCalcolati.Terza.MinSpeed, 0, (int)datiCalcolati.Terza.MaxSpeed, 6800);
            drawing.DrawLine(pen, (int)datiCalcolati.Quarta.MinSpeed, 0, (int)datiCalcolati.Quarta.MaxSpeed, 6800);
            drawing.DrawLine(pen, (int)datiCalcolati.Quinta.MinSpeed, 0, (int)datiCalcolati.Quinta.MaxSpeed, 6800);
            drawing.DrawLine(pen, (int)datiCalcolati.Sesta.MinSpeed, 0, (int)datiCalcolati.Sesta.MaxSpeed, 6800);
            drawing.DrawLine(pen, (int)datiCalcolati.Settima.MinSpeed, 0, (int)datiCalcolati.Settima.MaxSpeed, 6800);


            //_disegnaAsseX()
            //_disegnaAsseY()
            //_disegnaMarce();

            return img;
        }
    }
}
