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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            string percorso = "Salva.Txt";
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
                aggiungi(Nome.Text, double.Parse(Prezzo.Text), percorso);
            }
        }
        private void aggiungi(string nome, double prezzo, string percorso)
        {
            int righe = 64;
            StreamWriter salva = new StreamWriter("Salva.Txt");
            var Stream = new FileStream(percorso, FileMode.Append, FileAccess.Write, FileShare.Read);
            salva.Write($"{nome};{prezzo};1;0;".PadRight(righe - 4) + "##");
            MessageBox.Show("Aggiunto");
            Nome.Clear();
            Prezzo.Clear();
            salva.Close();
        }
        public string prodString(prodotto p)
        {
            return p.nome + ": " + p.prezzo.ToString() + "€";
        }
        public void visualizza(prodotto[] pp)
        {
            ElencoProdotti.Items.Clear();
            for (int i = 0; i < dim; i++)

            {
                ElencoProdotti.Items.Add(prodString(pp[i]));


            }
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
                    visualizza(p);
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
                        visualizza(p);
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
        private void Leggi_Click(object sender, EventArgs e)
        {
            if (File.Exists("Salva.Txt"))
            {
                ElencoProdotti.Items.Clear();
                string lettura;
                StreamReader leggi = new StreamReader("Salva.Txt");
                lettura = leggi.ReadLine();
                while (lettura != null)
                {
                    ElencoProdotti.Items.Add(lettura);
                    lettura = leggi.ReadLine();
                    dim++;
                }
                leggi.Close();
                MessageBox.Show("File letto correttamente");
            }
            else
            {
                MessageBox.Show("Il file non esiste");
            }
        }
        private void Cancella_Click(object sender, EventArgs e)
        {
            Ricerc = Ricerca.Text;
            if (string.IsNullOrEmpty(Ricerca.Text))
            {
                MessageBox.Show("Inserire il prodotto da eliminare");
            }
            if (dim > 0)
            {
                for (int i = 0; i < dim; i++)
                {
                    if (p[i].nome == Ricerc)
                    {
                        for (int j = i; j < dim; j++)
                        {
                            p[j] = p[j + 1];
                        }
                        dim--;
                        visualizza(p);
                        MessageBox.Show("Elemento eliminato");
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("La lista è vuota");
            }
            MessageBox.Show($"Il prodotto {Ricerc} non è presente nella lista");
        }
    }
}
