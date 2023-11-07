namespace _24102023
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ricerca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NuovoNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NuovoPrezzo = new System.Windows.Forms.TextBox();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.CancellaF = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(5, 28);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(159, 20);
            this.Nome.TabIndex = 1;
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(5, 70);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(159, 20);
            this.Prezzo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inserisci il prodotto da cercare";
            // 
            // Ricerca
            // 
            this.Ricerca.Location = new System.Drawing.Point(5, 112);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(215, 20);
            this.Ricerca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inserisci il nuovo nome";
            // 
            // NuovoNome
            // 
            this.NuovoNome.Location = new System.Drawing.Point(5, 154);
            this.NuovoNome.Name = "NuovoNome";
            this.NuovoNome.Size = new System.Drawing.Size(159, 20);
            this.NuovoNome.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Inserisci il nuovo prezzo";
            // 
            // NuovoPrezzo
            // 
            this.NuovoPrezzo.Location = new System.Drawing.Point(5, 196);
            this.NuovoPrezzo.Name = "NuovoPrezzo";
            this.NuovoPrezzo.Size = new System.Drawing.Size(170, 20);
            this.NuovoPrezzo.TabIndex = 9;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aggiungi.Location = new System.Drawing.Point(239, 28);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(122, 64);
            this.Aggiungi.TabIndex = 12;
            this.Aggiungi.Text = "Aggiungi";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(5, 222);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(126, 59);
            this.Reset.TabIndex = 24;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // CancellaF
            // 
            this.CancellaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancellaF.Location = new System.Drawing.Point(239, 220);
            this.CancellaF.Name = "CancellaF";
            this.CancellaF.Size = new System.Drawing.Size(122, 61);
            this.CancellaF.TabIndex = 25;
            this.CancellaF.Text = "Cancellazione fisica";
            this.CancellaF.UseVisualStyleBackColor = true;
            this.CancellaF.Click += new System.EventHandler(this.CancellaF_Click);
            // 
            // Modif
            // 
            this.Modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modif.Location = new System.Drawing.Point(239, 135);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(122, 63);
            this.Modif.TabIndex = 26;
            this.Modif.Text = "Modifica";
            this.Modif.UseVisualStyleBackColor = true;
            this.Modif.Click += new System.EventHandler(this.Modif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.CancellaF);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.NuovoPrezzo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NuovoNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ricerca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NuovoNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NuovoPrezzo;
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button CancellaF;
        private System.Windows.Forms.Button Modif;
    }
}

