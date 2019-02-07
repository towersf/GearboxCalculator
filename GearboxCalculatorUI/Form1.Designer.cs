namespace GearboxCalculatorUI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.cmbBattistrada = new System.Windows.Forms.ComboBox();
            this.lblRotolamento = new System.Windows.Forms.Label();
            this.txRpm = new System.Windows.Forms.TextBox();
            this.lblMaxGiriMotore = new System.Windows.Forms.Label();
            this.chkAbilitaSettima = new System.Windows.Forms.CheckBox();
            this.chkAbilitaSesta = new System.Windows.Forms.CheckBox();
            this.chkAbilitaQuinta = new System.Windows.Forms.CheckBox();
            this.lblFinaleNumerico = new System.Windows.Forms.Label();
            this.lblSettimaNumerico = new System.Windows.Forms.Label();
            this.lblSestaNumerico = new System.Windows.Forms.Label();
            this.lblQuintaNumerico = new System.Windows.Forms.Label();
            this.lblQuartaNumerico = new System.Windows.Forms.Label();
            this.lblTerzaNumerico = new System.Windows.Forms.Label();
            this.lblSecondaNumerico = new System.Windows.Forms.Label();
            this.lblPrimaNumerico = new System.Windows.Forms.Label();
            this.txFinaleB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txFinaleA = new System.Windows.Forms.TextBox();
            this.lblFinale = new System.Windows.Forms.Label();
            this.txSettimaB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txSettimaA = new System.Windows.Forms.TextBox();
            this.lblSettima = new System.Windows.Forms.Label();
            this.txSestaB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txSestaA = new System.Windows.Forms.TextBox();
            this.lblSesta = new System.Windows.Forms.Label();
            this.txQuintaB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txQuintaA = new System.Windows.Forms.TextBox();
            this.lblQuinta = new System.Windows.Forms.Label();
            this.txQuartaB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txQuartaA = new System.Windows.Forms.TextBox();
            this.lblQuarta = new System.Windows.Forms.Label();
            this.txTerzaB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txTerzaA = new System.Windows.Forms.TextBox();
            this.lblTerza = new System.Windows.Forms.Label();
            this.txSecondaB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSecondaA = new System.Windows.Forms.TextBox();
            this.lblSeconda = new System.Windows.Forms.Label();
            this.txPrimaB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txPrimaA = new System.Windows.Forms.TextBox();
            this.lblPrima = new System.Windows.Forms.Label();
            this.cmbRapportoSpalla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRaggio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picGraph);
            this.groupBox1.Location = new System.Drawing.Point(321, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // picGraph
            // 
            this.picGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGraph.Location = new System.Drawing.Point(6, 19);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(443, 355);
            this.picGraph.TabIndex = 0;
            this.picGraph.TabStop = false;
            // 
            // cmbBattistrada
            // 
            this.cmbBattistrada.FormattingEnabled = true;
            this.cmbBattistrada.Location = new System.Drawing.Point(34, 307);
            this.cmbBattistrada.Name = "cmbBattistrada";
            this.cmbBattistrada.Size = new System.Drawing.Size(61, 21);
            this.cmbBattistrada.TabIndex = 94;
            this.cmbBattistrada.SelectedIndexChanged += new System.EventHandler(this.cmbBattistrada_SelectedIndexChanged);
            // 
            // lblRotolamento
            // 
            this.lblRotolamento.AutoSize = true;
            this.lblRotolamento.Location = new System.Drawing.Point(33, 292);
            this.lblRotolamento.Name = "lblRotolamento";
            this.lblRotolamento.Size = new System.Drawing.Size(96, 13);
            this.lblRotolamento.TabIndex = 93;
            this.lblRotolamento.Text = "Misura pneumatico";
            // 
            // txRpm
            // 
            this.txRpm.Location = new System.Drawing.Point(34, 269);
            this.txRpm.Name = "txRpm";
            this.txRpm.Size = new System.Drawing.Size(72, 20);
            this.txRpm.TabIndex = 92;
            this.txRpm.TextChanged += new System.EventHandler(this.txRpm_TextChanged);
            // 
            // lblMaxGiriMotore
            // 
            this.lblMaxGiriMotore.AutoSize = true;
            this.lblMaxGiriMotore.Location = new System.Drawing.Point(31, 252);
            this.lblMaxGiriMotore.Name = "lblMaxGiriMotore";
            this.lblMaxGiriMotore.Size = new System.Drawing.Size(75, 13);
            this.lblMaxGiriMotore.TabIndex = 91;
            this.lblMaxGiriMotore.Text = "Max Giri Motre";
            // 
            // chkAbilitaSettima
            // 
            this.chkAbilitaSettima.AutoSize = true;
            this.chkAbilitaSettima.Location = new System.Drawing.Point(154, 155);
            this.chkAbilitaSettima.Name = "chkAbilitaSettima";
            this.chkAbilitaSettima.Size = new System.Drawing.Size(15, 14);
            this.chkAbilitaSettima.TabIndex = 90;
            this.chkAbilitaSettima.UseVisualStyleBackColor = true;
            this.chkAbilitaSettima.CheckedChanged += new System.EventHandler(this.chkAbilitaSettima_CheckedChanged);
            // 
            // chkAbilitaSesta
            // 
            this.chkAbilitaSesta.AutoSize = true;
            this.chkAbilitaSesta.Location = new System.Drawing.Point(154, 115);
            this.chkAbilitaSesta.Name = "chkAbilitaSesta";
            this.chkAbilitaSesta.Size = new System.Drawing.Size(15, 14);
            this.chkAbilitaSesta.TabIndex = 89;
            this.chkAbilitaSesta.UseVisualStyleBackColor = true;
            this.chkAbilitaSesta.CheckedChanged += new System.EventHandler(this.chkAbilitaSesta_CheckedChanged);
            // 
            // chkAbilitaQuinta
            // 
            this.chkAbilitaQuinta.AutoSize = true;
            this.chkAbilitaQuinta.Location = new System.Drawing.Point(154, 75);
            this.chkAbilitaQuinta.Name = "chkAbilitaQuinta";
            this.chkAbilitaQuinta.Size = new System.Drawing.Size(15, 14);
            this.chkAbilitaQuinta.TabIndex = 88;
            this.chkAbilitaQuinta.UseVisualStyleBackColor = true;
            this.chkAbilitaQuinta.CheckedChanged += new System.EventHandler(this.chkAbilitaQuinta_CheckedChanged);
            // 
            // lblFinaleNumerico
            // 
            this.lblFinaleNumerico.AutoSize = true;
            this.lblFinaleNumerico.Location = new System.Drawing.Point(250, 183);
            this.lblFinaleNumerico.Name = "lblFinaleNumerico";
            this.lblFinaleNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblFinaleNumerico.TabIndex = 87;
            // 
            // lblSettimaNumerico
            // 
            this.lblSettimaNumerico.AutoSize = true;
            this.lblSettimaNumerico.Location = new System.Drawing.Point(250, 135);
            this.lblSettimaNumerico.Name = "lblSettimaNumerico";
            this.lblSettimaNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblSettimaNumerico.TabIndex = 86;
            // 
            // lblSestaNumerico
            // 
            this.lblSestaNumerico.AutoSize = true;
            this.lblSestaNumerico.Location = new System.Drawing.Point(250, 95);
            this.lblSestaNumerico.Name = "lblSestaNumerico";
            this.lblSestaNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblSestaNumerico.TabIndex = 85;
            // 
            // lblQuintaNumerico
            // 
            this.lblQuintaNumerico.AutoSize = true;
            this.lblQuintaNumerico.Location = new System.Drawing.Point(250, 55);
            this.lblQuintaNumerico.Name = "lblQuintaNumerico";
            this.lblQuintaNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblQuintaNumerico.TabIndex = 84;
            // 
            // lblQuartaNumerico
            // 
            this.lblQuartaNumerico.AutoSize = true;
            this.lblQuartaNumerico.Location = new System.Drawing.Point(109, 175);
            this.lblQuartaNumerico.Name = "lblQuartaNumerico";
            this.lblQuartaNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblQuartaNumerico.TabIndex = 83;
            // 
            // lblTerzaNumerico
            // 
            this.lblTerzaNumerico.AutoSize = true;
            this.lblTerzaNumerico.Location = new System.Drawing.Point(109, 135);
            this.lblTerzaNumerico.Name = "lblTerzaNumerico";
            this.lblTerzaNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblTerzaNumerico.TabIndex = 82;
            // 
            // lblSecondaNumerico
            // 
            this.lblSecondaNumerico.AutoSize = true;
            this.lblSecondaNumerico.Location = new System.Drawing.Point(109, 95);
            this.lblSecondaNumerico.Name = "lblSecondaNumerico";
            this.lblSecondaNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblSecondaNumerico.TabIndex = 81;
            // 
            // lblPrimaNumerico
            // 
            this.lblPrimaNumerico.AutoSize = true;
            this.lblPrimaNumerico.Location = new System.Drawing.Point(109, 56);
            this.lblPrimaNumerico.Name = "lblPrimaNumerico";
            this.lblPrimaNumerico.Size = new System.Drawing.Size(0, 13);
            this.lblPrimaNumerico.TabIndex = 80;
            // 
            // txFinaleB
            // 
            this.txFinaleB.Location = new System.Drawing.Point(236, 200);
            this.txFinaleB.Name = "txFinaleB";
            this.txFinaleB.Size = new System.Drawing.Size(32, 20);
            this.txFinaleB.TabIndex = 79;
            this.txFinaleB.TextChanged += new System.EventHandler(this.txFinaleB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "//";
            // 
            // txFinaleA
            // 
            this.txFinaleA.Location = new System.Drawing.Point(175, 200);
            this.txFinaleA.Name = "txFinaleA";
            this.txFinaleA.Size = new System.Drawing.Size(32, 20);
            this.txFinaleA.TabIndex = 77;
            this.txFinaleA.TextChanged += new System.EventHandler(this.txFinaleA_TextChanged);
            // 
            // lblFinale
            // 
            this.lblFinale.AutoSize = true;
            this.lblFinale.Location = new System.Drawing.Point(172, 183);
            this.lblFinale.Name = "lblFinale";
            this.lblFinale.Size = new System.Drawing.Size(35, 13);
            this.lblFinale.TabIndex = 76;
            this.lblFinale.Text = "Finale";
            // 
            // txSettimaB
            // 
            this.txSettimaB.Location = new System.Drawing.Point(236, 152);
            this.txSettimaB.Name = "txSettimaB";
            this.txSettimaB.Size = new System.Drawing.Size(32, 20);
            this.txSettimaB.TabIndex = 75;
            this.txSettimaB.TextChanged += new System.EventHandler(this.txSettimaB_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "//";
            // 
            // txSettimaA
            // 
            this.txSettimaA.Location = new System.Drawing.Point(175, 152);
            this.txSettimaA.Name = "txSettimaA";
            this.txSettimaA.Size = new System.Drawing.Size(32, 20);
            this.txSettimaA.TabIndex = 73;
            this.txSettimaA.TextChanged += new System.EventHandler(this.txSettimaA_TextChanged);
            // 
            // lblSettima
            // 
            this.lblSettima.AutoSize = true;
            this.lblSettima.Location = new System.Drawing.Point(172, 135);
            this.lblSettima.Name = "lblSettima";
            this.lblSettima.Size = new System.Drawing.Size(42, 13);
            this.lblSettima.TabIndex = 72;
            this.lblSettima.Text = "Settima";
            // 
            // txSestaB
            // 
            this.txSestaB.Location = new System.Drawing.Point(236, 112);
            this.txSestaB.Name = "txSestaB";
            this.txSestaB.Size = new System.Drawing.Size(32, 20);
            this.txSestaB.TabIndex = 71;
            this.txSestaB.TextChanged += new System.EventHandler(this.txSestaB_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "//";
            // 
            // txSestaA
            // 
            this.txSestaA.Location = new System.Drawing.Point(175, 112);
            this.txSestaA.Name = "txSestaA";
            this.txSestaA.Size = new System.Drawing.Size(32, 20);
            this.txSestaA.TabIndex = 69;
            this.txSestaA.TextChanged += new System.EventHandler(this.txSestaA_TextChanged);
            // 
            // lblSesta
            // 
            this.lblSesta.AutoSize = true;
            this.lblSesta.Location = new System.Drawing.Point(172, 95);
            this.lblSesta.Name = "lblSesta";
            this.lblSesta.Size = new System.Drawing.Size(34, 13);
            this.lblSesta.TabIndex = 68;
            this.lblSesta.Text = "Sesta";
            // 
            // txQuintaB
            // 
            this.txQuintaB.Location = new System.Drawing.Point(236, 72);
            this.txQuintaB.Name = "txQuintaB";
            this.txQuintaB.Size = new System.Drawing.Size(32, 20);
            this.txQuintaB.TabIndex = 67;
            this.txQuintaB.TextChanged += new System.EventHandler(this.txQuintaB_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "//";
            // 
            // txQuintaA
            // 
            this.txQuintaA.Location = new System.Drawing.Point(175, 72);
            this.txQuintaA.Name = "txQuintaA";
            this.txQuintaA.Size = new System.Drawing.Size(32, 20);
            this.txQuintaA.TabIndex = 65;
            this.txQuintaA.TextChanged += new System.EventHandler(this.txQuintaA_TextChanged);
            // 
            // lblQuinta
            // 
            this.lblQuinta.AutoSize = true;
            this.lblQuinta.Location = new System.Drawing.Point(172, 55);
            this.lblQuinta.Name = "lblQuinta";
            this.lblQuinta.Size = new System.Drawing.Size(38, 13);
            this.lblQuinta.TabIndex = 64;
            this.lblQuinta.Text = "Quinta";
            // 
            // txQuartaB
            // 
            this.txQuartaB.Location = new System.Drawing.Point(95, 192);
            this.txQuartaB.Name = "txQuartaB";
            this.txQuartaB.Size = new System.Drawing.Size(32, 20);
            this.txQuartaB.TabIndex = 63;
            this.txQuartaB.TextChanged += new System.EventHandler(this.txQuartaB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "//";
            // 
            // txQuartaA
            // 
            this.txQuartaA.Location = new System.Drawing.Point(34, 192);
            this.txQuartaA.Name = "txQuartaA";
            this.txQuartaA.Size = new System.Drawing.Size(32, 20);
            this.txQuartaA.TabIndex = 61;
            this.txQuartaA.TextChanged += new System.EventHandler(this.txQuartaA_TextChanged);
            // 
            // lblQuarta
            // 
            this.lblQuarta.AutoSize = true;
            this.lblQuarta.Location = new System.Drawing.Point(31, 175);
            this.lblQuarta.Name = "lblQuarta";
            this.lblQuarta.Size = new System.Drawing.Size(39, 13);
            this.lblQuarta.TabIndex = 60;
            this.lblQuarta.Text = "Quarta";
            // 
            // txTerzaB
            // 
            this.txTerzaB.Location = new System.Drawing.Point(95, 152);
            this.txTerzaB.Name = "txTerzaB";
            this.txTerzaB.Size = new System.Drawing.Size(32, 20);
            this.txTerzaB.TabIndex = 59;
            this.txTerzaB.TextChanged += new System.EventHandler(this.txTerzaB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "//";
            // 
            // txTerzaA
            // 
            this.txTerzaA.Location = new System.Drawing.Point(34, 152);
            this.txTerzaA.Name = "txTerzaA";
            this.txTerzaA.Size = new System.Drawing.Size(32, 20);
            this.txTerzaA.TabIndex = 57;
            this.txTerzaA.TextChanged += new System.EventHandler(this.txTerzaA_TextChanged);
            // 
            // lblTerza
            // 
            this.lblTerza.AutoSize = true;
            this.lblTerza.Location = new System.Drawing.Point(31, 135);
            this.lblTerza.Name = "lblTerza";
            this.lblTerza.Size = new System.Drawing.Size(34, 13);
            this.lblTerza.TabIndex = 56;
            this.lblTerza.Text = "Terza";
            // 
            // txSecondaB
            // 
            this.txSecondaB.Location = new System.Drawing.Point(95, 112);
            this.txSecondaB.Name = "txSecondaB";
            this.txSecondaB.Size = new System.Drawing.Size(32, 20);
            this.txSecondaB.TabIndex = 55;
            this.txSecondaB.TextChanged += new System.EventHandler(this.txSecondaB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "//";
            // 
            // txSecondaA
            // 
            this.txSecondaA.Location = new System.Drawing.Point(34, 112);
            this.txSecondaA.Name = "txSecondaA";
            this.txSecondaA.Size = new System.Drawing.Size(32, 20);
            this.txSecondaA.TabIndex = 53;
            this.txSecondaA.TextChanged += new System.EventHandler(this.txSecondaA_TextChanged);
            // 
            // lblSeconda
            // 
            this.lblSeconda.AutoSize = true;
            this.lblSeconda.Location = new System.Drawing.Point(31, 96);
            this.lblSeconda.Name = "lblSeconda";
            this.lblSeconda.Size = new System.Drawing.Size(50, 13);
            this.lblSeconda.TabIndex = 52;
            this.lblSeconda.Text = "Seconda";
            // 
            // txPrimaB
            // 
            this.txPrimaB.Location = new System.Drawing.Point(95, 73);
            this.txPrimaB.Name = "txPrimaB";
            this.txPrimaB.Size = new System.Drawing.Size(32, 20);
            this.txPrimaB.TabIndex = 51;
            this.txPrimaB.TextChanged += new System.EventHandler(this.txPrimaB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "//";
            // 
            // txPrimaA
            // 
            this.txPrimaA.Location = new System.Drawing.Point(34, 73);
            this.txPrimaA.Name = "txPrimaA";
            this.txPrimaA.Size = new System.Drawing.Size(32, 20);
            this.txPrimaA.TabIndex = 49;
            this.txPrimaA.TextChanged += new System.EventHandler(this.txPrimaA_TextChanged);
            // 
            // lblPrima
            // 
            this.lblPrima.AutoSize = true;
            this.lblPrima.Location = new System.Drawing.Point(31, 56);
            this.lblPrima.Name = "lblPrima";
            this.lblPrima.Size = new System.Drawing.Size(33, 13);
            this.lblPrima.TabIndex = 48;
            this.lblPrima.Text = "Prima";
            // 
            // cmbRapportoSpalla
            // 
            this.cmbRapportoSpalla.FormattingEnabled = true;
            this.cmbRapportoSpalla.Location = new System.Drawing.Point(119, 307);
            this.cmbRapportoSpalla.Name = "cmbRapportoSpalla";
            this.cmbRapportoSpalla.Size = new System.Drawing.Size(42, 21);
            this.cmbRapportoSpalla.TabIndex = 95;
            this.cmbRapportoSpalla.SelectedIndexChanged += new System.EventHandler(this.cmbRapportoSpalla_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "R";
            // 
            // cmbRaggio
            // 
            this.cmbRaggio.FormattingEnabled = true;
            this.cmbRaggio.Location = new System.Drawing.Point(188, 307);
            this.cmbRaggio.Name = "cmbRaggio";
            this.cmbRaggio.Size = new System.Drawing.Size(42, 21);
            this.cmbRaggio.TabIndex = 98;
            this.cmbRaggio.SelectedIndexChanged += new System.EventHandler(this.cmbRaggio_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 404);
            this.Controls.Add(this.cmbRaggio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRapportoSpalla);
            this.Controls.Add(this.cmbBattistrada);
            this.Controls.Add(this.lblRotolamento);
            this.Controls.Add(this.txRpm);
            this.Controls.Add(this.lblMaxGiriMotore);
            this.Controls.Add(this.chkAbilitaSettima);
            this.Controls.Add(this.chkAbilitaSesta);
            this.Controls.Add(this.chkAbilitaQuinta);
            this.Controls.Add(this.lblFinaleNumerico);
            this.Controls.Add(this.lblSettimaNumerico);
            this.Controls.Add(this.lblSestaNumerico);
            this.Controls.Add(this.lblQuintaNumerico);
            this.Controls.Add(this.lblQuartaNumerico);
            this.Controls.Add(this.lblTerzaNumerico);
            this.Controls.Add(this.lblSecondaNumerico);
            this.Controls.Add(this.lblPrimaNumerico);
            this.Controls.Add(this.txFinaleB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txFinaleA);
            this.Controls.Add(this.lblFinale);
            this.Controls.Add(this.txSettimaB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txSettimaA);
            this.Controls.Add(this.lblSettima);
            this.Controls.Add(this.txSestaB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txSestaA);
            this.Controls.Add(this.lblSesta);
            this.Controls.Add(this.txQuintaB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txQuintaA);
            this.Controls.Add(this.lblQuinta);
            this.Controls.Add(this.txQuartaB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txQuartaA);
            this.Controls.Add(this.lblQuarta);
            this.Controls.Add(this.txTerzaB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txTerzaA);
            this.Controls.Add(this.lblTerza);
            this.Controls.Add(this.txSecondaB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSecondaA);
            this.Controls.Add(this.lblSeconda);
            this.Controls.Add(this.txPrimaB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txPrimaA);
            this.Controls.Add(this.lblPrima);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.ComboBox cmbBattistrada;
        private System.Windows.Forms.Label lblRotolamento;
        private System.Windows.Forms.TextBox txRpm;
        private System.Windows.Forms.Label lblMaxGiriMotore;
        private System.Windows.Forms.CheckBox chkAbilitaSettima;
        private System.Windows.Forms.CheckBox chkAbilitaSesta;
        private System.Windows.Forms.CheckBox chkAbilitaQuinta;
        private System.Windows.Forms.Label lblFinaleNumerico;
        private System.Windows.Forms.Label lblSettimaNumerico;
        private System.Windows.Forms.Label lblSestaNumerico;
        private System.Windows.Forms.Label lblQuintaNumerico;
        private System.Windows.Forms.Label lblQuartaNumerico;
        private System.Windows.Forms.Label lblTerzaNumerico;
        private System.Windows.Forms.Label lblSecondaNumerico;
        private System.Windows.Forms.Label lblPrimaNumerico;
        private System.Windows.Forms.TextBox txFinaleB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txFinaleA;
        private System.Windows.Forms.Label lblFinale;
        private System.Windows.Forms.TextBox txSettimaB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txSettimaA;
        private System.Windows.Forms.Label lblSettima;
        private System.Windows.Forms.TextBox txSestaB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txSestaA;
        private System.Windows.Forms.Label lblSesta;
        private System.Windows.Forms.TextBox txQuintaB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txQuintaA;
        private System.Windows.Forms.Label lblQuinta;
        private System.Windows.Forms.TextBox txQuartaB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txQuartaA;
        private System.Windows.Forms.Label lblQuarta;
        private System.Windows.Forms.TextBox txTerzaB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txTerzaA;
        private System.Windows.Forms.Label lblTerza;
        private System.Windows.Forms.TextBox txSecondaB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSecondaA;
        private System.Windows.Forms.Label lblSeconda;
        private System.Windows.Forms.TextBox txPrimaB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPrimaA;
        private System.Windows.Forms.Label lblPrima;
        private System.Windows.Forms.ComboBox cmbRapportoSpalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRaggio;
    }
}

