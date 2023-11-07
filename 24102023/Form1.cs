using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _24102023
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public double prezzo;
        }
        public prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }
        public string percorso = "Salva.dat";
        public int riga = 64;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nome.Text))
            {
                MessageBox.Show("Inserire un nome");
            }
            else if (string.IsNullOrEmpty(Prezzo.Text))
            {
                MessageBox.Show("Inserire un prezzo");
            }
            else
            {
                p[dim].nome = Nome.Text;
                p[dim].prezzo = float.Parse(Prezzo.Text);
                aggiungi(p[dim].nome, p[dim].prezzo, percorso);
                dim++;
                Nome.Clear();
                Prezzo.Clear();
            }
        }
            private void aggiungi(string nome, double prezzo, string percorso)
            {
                var apertura = new FileStream(percorso, FileMode.Append, FileAccess.Write, FileShare.Read);
                StreamWriter salva = new StreamWriter(apertura);
                salva.WriteLine($"{nome};{prezzo};1;0;".PadRight(riga - 4) + "##");
                salva.Close();
            }
        private void resetta(string percorso)
        {
            File.WriteAllText(percorso, string.Empty);
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            resetta(percorso);
            MessageBox.Show("Resettato");
        }
        private int Indice(string nome)
        {
            int riga = 0;
            using (StreamReader salva = File.OpenText("Salva.dat"))
            {
                string lettore;
                while ((lettore = salva.ReadLine()) != null)
                {
                    string[] dati = lettore.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        salva.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }
        public void Modifica(string nome, double prezzo, string percorso, int lunghezza)
        {
            int indice = Indice(Ricerca.Text);
            string riga;
            var salva = new FileStream(percorso, FileMode.Open, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(salva);
            salva.Seek(lunghezza * indice, SeekOrigin.Begin);
            riga = $"{nome};{prezzo};1;0;".PadRight(lunghezza - 4) + "##";
            byte[] bytes = Encoding.UTF8.GetBytes(riga);
            writer.Write(bytes);
            writer.Close();
            salva.Close();
        }
        public void CancellazioneF(string percorso, int lunghezza)
        {
            int indice = Indice(Ricerca.Text);
            var salva = new FileStream(percorso, FileMode.Open, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(salva);
            salva.Seek(lunghezza * indice, SeekOrigin.Begin);
            writer.Close();
            salva.Close();
        }
        private void CancellaF_Click(object sender, EventArgs e)
        {
            CancellazioneF(percorso, riga);
            MessageBox.Show("Eliminato");
            Ricerca.Clear();
        }

        private void Modif_Click(object sender, EventArgs e)
        {
            Modifica(NuovoNome.Text, double.Parse(NuovoPrezzo.Text), percorso, riga);
            Ricerca.Clear();
            NuovoNome.Clear();
            NuovoPrezzo.Clear();
        }
    }
}
