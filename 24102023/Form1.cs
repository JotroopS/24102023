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
                MessageBox.Show("Aggiunto");
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
            var apertura = new FileStream(percorso, FileMode.Truncate, FileAccess.Write, FileShare.Read);
            StreamWriter salva = new StreamWriter(apertura);
            salva.WriteLine(string.Empty);
            salva.Close();
        }
        public string Ricerc;

        private void ModificaNome_Click(object sender, EventArgs e)
        {
            Ricerc = Ricerca.Text;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].nome == Ricerc)
                {
                    p[i].nome = NuovoNome.Text;
                    MessageBox.Show("Modificato");
                    Ricerca.Clear();
                    NuovoNome.Clear();
                    break;
                }
                else if (i == p.Length - 1)
                {
                    MessageBox.Show($"Il prodotto {Ricerc} non esiste");
                    break;
                }
                if (string.IsNullOrEmpty(NuovoNome.Text))
                {
                    MessageBox.Show("Inserire il nuovo nome da inserire");
                    break;
                }
            }
        }

        private void ModificaPrezzo_Click(object sender, EventArgs e)
        {
            Ricerc = Ricerca.Text;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].nome == Ricerc)
                {
                    p[i].prezzo = double.Parse(NuovoPrezzo.Text);
                    MessageBox.Show("Modificato");
                    Ricerca.Clear();
                    NuovoPrezzo.Clear();
                    break;
                }
                else if (i == p.Length - 1)
                {
                    MessageBox.Show($"Il prodotto {Ricerc} non esiste");
                    break;
                }
                if (string.IsNullOrEmpty(NuovoPrezzo.Text))
                {
                    MessageBox.Show("Inserire il nuovo prezzo da inserire");
                    break;
                }
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            resetta(percorso);
            MessageBox.Show("Resettato");
        }
        private int indice (string nome, double prezzo, string percorso)
        {
            Ricerc = Ricerca.Text;
            var apertura = new FileStream(percorso, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter salva = new StreamWriter(apertura);
            for (int i = 0; i.ToString() == null; i++)
            {
                
            }
            return -1;
        }

        private void CancellaF_Click(object sender, EventArgs e)
        {

        }
    }
}
