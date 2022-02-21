
namespace ESERCIZI_FOGLIO_1_2
{
    partial class Es_Folgio_1_2
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
            this.calc = new System.Windows.Forms.Button();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txb_a = new System.Windows.Forms.TextBox();
            this.txb_b = new System.Windows.Forms.TextBox();
            this.txb_c = new System.Windows.Forms.TextBox();
            this.Esito = new System.Windows.Forms.Label();
            this.Risultato_esito = new System.Windows.Forms.Label();
            this.calcola = new System.Windows.Forms.Button();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.result_x1 = new System.Windows.Forms.Label();
            this.result_x2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calc.Location = new System.Drawing.Point(138, 30);
            this.calc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(0, 0);
            this.calc.TabIndex = 0;
            this.calc.Text = "Calcola";
            this.calc.UseVisualStyleBackColor = true;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(9, 7);
            this.lbl_a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(16, 13);
            this.lbl_a.TabIndex = 1;
            this.lbl_a.Text = "a:";
            // 
            // txb_a
            // 
            this.txb_a.Location = new System.Drawing.Point(29, 7);
            this.txb_a.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_a.Name = "txb_a";
            this.txb_a.Size = new System.Drawing.Size(76, 20);
            this.txb_a.TabIndex = 4;
            // 
            // txb_b
            // 
            this.txb_b.Location = new System.Drawing.Point(29, 39);
            this.txb_b.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_b.Name = "txb_b";
            this.txb_b.Size = new System.Drawing.Size(76, 20);
            this.txb_b.TabIndex = 5;
            // 
            // txb_c
            // 
            this.txb_c.Location = new System.Drawing.Point(29, 66);
            this.txb_c.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_c.Name = "txb_c";
            this.txb_c.Size = new System.Drawing.Size(76, 20);
            this.txb_c.TabIndex = 6;
            // 
            // Esito
            // 
            this.Esito.AutoSize = true;
            this.Esito.Location = new System.Drawing.Point(69, 154);
            this.Esito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Esito.Name = "Esito";
            this.Esito.Size = new System.Drawing.Size(33, 13);
            this.Esito.TabIndex = 7;
            this.Esito.Text = "Esito:";
            // 
            // Risultato_esito
            // 
            this.Risultato_esito.AutoSize = true;
            this.Risultato_esito.Location = new System.Drawing.Point(106, 154);
            this.Risultato_esito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Risultato_esito.Name = "Risultato_esito";
            this.Risultato_esito.Size = new System.Drawing.Size(91, 13);
            this.Risultato_esito.TabIndex = 8;
            this.Risultato_esito.Text = "______________";
            // 
            // calcola
            // 
            this.calcola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcola.Location = new System.Drawing.Point(122, 66);
            this.calcola.Name = "calcola";
            this.calcola.Size = new System.Drawing.Size(75, 23);
            this.calcola.TabIndex = 9;
            this.calcola.Text = "Calcola";
            this.calcola.UseVisualStyleBackColor = true;
            this.calcola.Click += new System.EventHandler(this.calcola_Click);
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(11, 39);
            this.lbl_b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(16, 13);
            this.lbl_b.TabIndex = 2;
            this.lbl_b.Text = "b:";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(11, 66);
            this.lbl_c.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(16, 13);
            this.lbl_c.TabIndex = 3;
            this.lbl_c.Text = "c:";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(239, 100);
            this.x1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(21, 13);
            this.x1.TabIndex = 11;
            this.x1.Text = "x2:";
            this.x1.Click += new System.EventHandler(this.label1_Click);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(239, 73);
            this.x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(21, 13);
            this.x.TabIndex = 10;
            this.x.Text = "x1:";
            this.x.Click += new System.EventHandler(this.label2_Click);
            // 
            // result_x1
            // 
            this.result_x1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.result_x1.AutoSize = true;
            this.result_x1.Location = new System.Drawing.Point(266, 73);
            this.result_x1.Name = "result_x1";
            this.result_x1.Size = new System.Drawing.Size(61, 13);
            this.result_x1.TabIndex = 12;
            this.result_x1.Text = "_________";
            this.result_x1.Click += new System.EventHandler(this.result_x1_Click);
            // 
            // result_x2
            // 
            this.result_x2.AutoSize = true;
            this.result_x2.Location = new System.Drawing.Point(266, 100);
            this.result_x2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_x2.Name = "result_x2";
            this.result_x2.Size = new System.Drawing.Size(61, 13);
            this.result_x2.TabIndex = 13;
            this.result_x2.Text = "_________";
            // 
            // Es_Folgio_1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 188);
            this.Controls.Add(this.result_x2);
            this.Controls.Add(this.result_x1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x);
            this.Controls.Add(this.calcola);
            this.Controls.Add(this.Risultato_esito);
            this.Controls.Add(this.Esito);
            this.Controls.Add(this.txb_c);
            this.Controls.Add(this.txb_b);
            this.Controls.Add(this.txb_a);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.calc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Es_Folgio_1_2";
            this.Text = "Es_Folgio_1_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txb_a;
        private System.Windows.Forms.TextBox txb_b;
        private System.Windows.Forms.TextBox txb_c;
        private System.Windows.Forms.Label Esito;
        private System.Windows.Forms.Label Risultato_esito;
        private System.Windows.Forms.Button calcola;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label result_x1;
        private System.Windows.Forms.Label result_x2;
    }
}

