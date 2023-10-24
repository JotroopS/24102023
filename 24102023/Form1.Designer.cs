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
            this.label6 = new System.Windows.Forms.Label();
            this.Perce = new System.Windows.Forms.TextBox();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.ModificaNome = new System.Windows.Forms.Button();
            this.ModificaPrezzo = new System.Windows.Forms.Button();
            this.Cancella = new System.Windows.Forms.Button();
            this.Ordina = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.Salva = new System.Windows.Forms.Button();
            this.Leggi = new System.Windows.Forms.Button();
            this.Minimo = new System.Windows.Forms.Button();
            this.Massimo = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.ElencoProdotti = new System.Windows.Forms.ListBox();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Inserisci la percentuale";
            // 
            // Perce
            // 
            this.Perce.Location = new System.Drawing.Point(5, 238);
            this.Perce.Name = "Perce";
            this.Perce.Size = new System.Drawing.Size(159, 20);
            this.Perce.TabIndex = 11;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aggiungi.Location = new System.Drawing.Point(221, 18);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(112, 64);
            this.Aggiungi.TabIndex = 12;
            this.Aggiungi.Text = "Aggiungi";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // ModificaNome
            // 
            this.ModificaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificaNome.Location = new System.Drawing.Point(221, 89);
            this.ModificaNome.Name = "ModificaNome";
            this.ModificaNome.Size = new System.Drawing.Size(112, 64);
            this.ModificaNome.TabIndex = 13;
            this.ModificaNome.Text = "Modifica il nome";
            this.ModificaNome.UseVisualStyleBackColor = true;
            this.ModificaNome.Click += new System.EventHandler(this.ModificaNome_Click);
            // 
            // ModificaPrezzo
            // 
            this.ModificaPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificaPrezzo.Location = new System.Drawing.Point(221, 155);
            this.ModificaPrezzo.Name = "ModificaPrezzo";
            this.ModificaPrezzo.Size = new System.Drawing.Size(112, 61);
            this.ModificaPrezzo.TabIndex = 14;
            this.ModificaPrezzo.Text = "Modifica il prezzo";
            this.ModificaPrezzo.UseVisualStyleBackColor = true;
            this.ModificaPrezzo.Click += new System.EventHandler(this.ModificaPrezzo_Click);
            // 
            // Cancella
            // 
            this.Cancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancella.Location = new System.Drawing.Point(221, 217);
            this.Cancella.Name = "Cancella";
            this.Cancella.Size = new System.Drawing.Size(112, 61);
            this.Cancella.TabIndex = 15;
            this.Cancella.Text = "Elimina";
            this.Cancella.UseVisualStyleBackColor = true;
            this.Cancella.Click += new System.EventHandler(this.Cancella_Click);
            // 
            // Ordina
            // 
            this.Ordina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordina.Location = new System.Drawing.Point(221, 284);
            this.Ordina.Name = "Ordina";
            this.Ordina.Size = new System.Drawing.Size(112, 61);
            this.Ordina.TabIndex = 16;
            this.Ordina.Text = "Ordina";
            this.Ordina.UseVisualStyleBackColor = true;
            this.Ordina.Click += new System.EventHandler(this.Ordina_Click);
            // 
            // Somma
            // 
            this.Somma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somma.Location = new System.Drawing.Point(221, 351);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(112, 61);
            this.Somma.TabIndex = 17;
            this.Somma.Text = "Somma totale";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // Salva
            // 
            this.Salva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salva.Location = new System.Drawing.Point(339, 18);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(112, 63);
            this.Salva.TabIndex = 18;
            this.Salva.Text = "Salva";
            this.Salva.UseVisualStyleBackColor = true;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // Leggi
            // 
            this.Leggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leggi.Location = new System.Drawing.Point(339, 89);
            this.Leggi.Name = "Leggi";
            this.Leggi.Size = new System.Drawing.Size(111, 64);
            this.Leggi.TabIndex = 19;
            this.Leggi.Text = "Leggi il file";
            this.Leggi.UseVisualStyleBackColor = true;
            this.Leggi.Click += new System.EventHandler(this.Leggi_Click);
            // 
            // Minimo
            // 
            this.Minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimo.Location = new System.Drawing.Point(339, 154);
            this.Minimo.Name = "Minimo";
            this.Minimo.Size = new System.Drawing.Size(111, 62);
            this.Minimo.TabIndex = 20;
            this.Minimo.Text = "Prezzo minimo";
            this.Minimo.UseVisualStyleBackColor = true;
            this.Minimo.Click += new System.EventHandler(this.Minimo_Click);
            // 
            // Massimo
            // 
            this.Massimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Massimo.Location = new System.Drawing.Point(339, 217);
            this.Massimo.Name = "Massimo";
            this.Massimo.Size = new System.Drawing.Size(111, 60);
            this.Massimo.TabIndex = 21;
            this.Massimo.Text = "Prezzo massimo";
            this.Massimo.UseVisualStyleBackColor = true;
            this.Massimo.Click += new System.EventHandler(this.Massimo_Click);
            // 
            // Percent
            // 
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(339, 284);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(111, 60);
            this.Percent.TabIndex = 22;
            this.Percent.Text = "Aggiungi/sottrai";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // ElencoProdotti
            // 
            this.ElencoProdotti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElencoProdotti.FormattingEnabled = true;
            this.ElencoProdotti.ItemHeight = 20;
            this.ElencoProdotti.Location = new System.Drawing.Point(456, 18);
            this.ElencoProdotti.Name = "ElencoProdotti";
            this.ElencoProdotti.Size = new System.Drawing.Size(332, 424);
            this.ElencoProdotti.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ElencoProdotti);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Massimo);
            this.Controls.Add(this.Minimo);
            this.Controls.Add(this.Leggi);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.Ordina);
            this.Controls.Add(this.Cancella);
            this.Controls.Add(this.ModificaPrezzo);
            this.Controls.Add(this.ModificaNome);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.Perce);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Perce;
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.Button ModificaNome;
        private System.Windows.Forms.Button ModificaPrezzo;
        private System.Windows.Forms.Button Cancella;
        private System.Windows.Forms.Button Ordina;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.Button Leggi;
        private System.Windows.Forms.Button Minimo;
        private System.Windows.Forms.Button Massimo;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.ListBox ElencoProdotti;
    }
}

