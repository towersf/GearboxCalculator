using GearboxCalculatorCore;
using GearboxCalculatorCore.Classes;
using System;
using System.Windows.Forms;
using GearboxCommons.Classes;

namespace GearboxCalculatorUI
{
    public partial class Form1 : Form
    {
        private bool _enableDraw;

        private Core _core;

        public Form1()
        {
            InitializeComponent();

            _core = new Core();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _enableDraw = true;

            _draw();
        }
        
        private InputData _getInputUserData()
        {
            var data = new InputData();

            data.Cambio.Prima.GearA = Convert.ToInt32(txPrimaA.Text);
            data.Cambio.Prima.GearB = Convert.ToInt32(txPrimaB.Text);
            data.Cambio.Seconda.GearA = Convert.ToInt32(txSecondaA.Text);
            data.Cambio.Seconda.GearB = Convert.ToInt32(txSecondaB.Text);
            data.Cambio.Terza.GearA = Convert.ToInt32(txTerzaA.Text);
            data.Cambio.Terza.GearB = Convert.ToInt32(txTerzaB.Text);
            data.Cambio.Quarta.GearA = Convert.ToInt32(txQuartaA.Text);
            data.Cambio.Quarta.GearB = Convert.ToInt32(txQuartaB.Text);
            data.Cambio.Quinta.GearA = Convert.ToInt32(txQuintaA.Text);
            data.Cambio.Quinta.GearB = Convert.ToInt32(txQuintaB.Text);
            data.Cambio.Sesta.GearA = Convert.ToInt32(txSestaA.Text);
            data.Cambio.Sesta.GearB = Convert.ToInt32(txSestaB.Text);
            data.Cambio.Settima.GearA = Convert.ToInt32(txSettimaA.Text);
            data.Cambio.Settima.GearB = Convert.ToInt32(txSettimaB.Text);
            data.Cambio.Finale.GearA = Convert.ToInt32(txFinaleA.Text);
            data.Cambio.Finale.GearB = Convert.ToInt32(txFinaleB.Text);

            data.Engine.MaxRpm = Convert.ToInt32(txRpm.Text);
            data.Engine.RefRpm = Convert.ToInt32(txRpmRef.Text);

            data.Tire.AspectRatio = Convert.ToInt32(txRapportoSpalla.Text);
            data.Tire.RimDiameterInch = Convert.ToInt32(txRaggio.Text);
            data.Tire.WidthMm = Convert.ToInt32(txBattistrada.Text);

            return data;
        }

        private void _draw()
        {
            if (!_enableDraw) { return; }

            var input = _getInputUserData();

            try
            {
                var graph = _core.CalcolaGearbox(input);
                picGraph.Image = graph.GraphImage;


                graph.GraphImage.Save("C:\\pippo.jpg");


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
        }

        #region Controls

        private void txPrimaA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txPrimaB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txSecondaA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txSecondaB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txTerzaA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txTerzaB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txQuartaA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txQuartaB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txQuintaA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txQuintaB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txSestaA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txSestaB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txSettimaA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txSettimaB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txFinaleA_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txFinaleB_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txRpm_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txRpmRef_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txBattistrada_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txRapportoSpalla_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void txRaggio_TextChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void chkAbilitaQuinta_CheckedChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void chkAbilitaSesta_CheckedChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void chkAbilitaSettima_CheckedChanged(object sender, EventArgs e)
        {
            _draw();
        }

        #endregion
    }
}
