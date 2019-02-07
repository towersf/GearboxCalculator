using GearboxCalculatorCore;
using GearboxCalculatorCore.Classes;
using System;
using System.Windows.Forms;

namespace GearboxCalculatorUI
{
    public partial class Form1 : Form
    {
        private Core _core;

        public Form1()
        {
            InitializeComponent();

            _core = new Core();
        }

        private SpeedCalculator _getInputUserData()
        {
            SpeedCalculator data = new SpeedCalculator();

            //todo farcire l'oggetto data con i valori presi dalla form

            data.Prima.A = Convert.ToInt32(txPrimaA.Text);
            data.Prima.B = Convert.ToInt32(txPrimaB.Text);



            return data;
        }

        private void _draw()
        {
            var input = _getInputUserData();

            try
            {
                var graph = _core.CalcolaGearbox(input);
                picGraph.Image = graph.GraphImage;
            }
            catch (Exception err)
            {
                MessageBox.Show("Errore", err.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbBattistrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void cmbRapportoSpalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            _draw();
        }

        private void cmbRaggio_SelectedIndexChanged(object sender, EventArgs e)
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
