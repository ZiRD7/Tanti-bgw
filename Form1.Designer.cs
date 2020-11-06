namespace Tanti_bgw
{
    partial class frmMain
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
            this.btnAvvio = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAvvio100 = new System.Windows.Forms.Button();
            this.btnStop100 = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.tb100 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAvvio
            // 
            this.btnAvvio.Location = new System.Drawing.Point(12, 12);
            this.btnAvvio.Name = "btnAvvio";
            this.btnAvvio.Size = new System.Drawing.Size(75, 23);
            this.btnAvvio.TabIndex = 0;
            this.btnAvvio.Text = "Avvio";
            this.btnAvvio.UseVisualStyleBackColor = true;
            this.btnAvvio.Click += new System.EventHandler(this.btnAvvio_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 62);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAvvio100
            // 
            this.btnAvvio100.Location = new System.Drawing.Point(238, 12);
            this.btnAvvio100.Name = "btnAvvio100";
            this.btnAvvio100.Size = new System.Drawing.Size(75, 23);
            this.btnAvvio100.TabIndex = 2;
            this.btnAvvio100.Text = "Avvio 100";
            this.btnAvvio100.UseVisualStyleBackColor = true;
            this.btnAvvio100.Click += new System.EventHandler(this.btnAvvio100_Click);
            // 
            // btnStop100
            // 
            this.btnStop100.Location = new System.Drawing.Point(238, 62);
            this.btnStop100.Name = "btnStop100";
            this.btnStop100.Size = new System.Drawing.Size(75, 23);
            this.btnStop100.TabIndex = 3;
            this.btnStop100.Text = "Stop 100";
            this.btnStop100.UseVisualStyleBackColor = true;
            this.btnStop100.Click += new System.EventHandler(this.btnStop100_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(93, 12);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(100, 365);
            this.tb.TabIndex = 4;
            // 
            // tb100
            // 
            this.tb100.Location = new System.Drawing.Point(330, 12);
            this.tb100.Multiline = true;
            this.tb100.Name = "tb100";
            this.tb100.ReadOnly = true;
            this.tb100.Size = new System.Drawing.Size(100, 365);
            this.tb100.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 404);
            this.Controls.Add(this.tb100);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btnStop100);
            this.Controls.Add(this.btnAvvio100);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAvvio);
            this.Name = "frmMain";
            this.Text = "Tanti backgroundWorker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvvio;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAvvio100;
        private System.Windows.Forms.Button btnStop100;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tb100;
    }
}

