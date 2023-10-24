using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                p[dim].prezzo = double.Parse(Prezzo.Text);
                dim++;
                MessageBox.Show("Aggiunto");
                Nome.Clear();
                Prezzo.Clear();
                visualizza(p);
            }
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
            for (int i = 0; i < p.Length; ++i)
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
                else
                {
                    MessageBox.Show("Il prodotto non esiste");
                    break;
                }
            }
        }

        private void ModificaPrezzo_Click(object sender, EventArgs e)
        {
            Ricerc = Ricerca.Text;
            for (int i = 0; i < p.Length; ++i)
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
                else
                {
                    MessageBox.Show("Il prodotto non esiste");
                    break;
                }
            }
        }

        private void Cancella_Click(object sender, EventArgs e)
        {

        }

        private void Ordina_Click(object sender, EventArgs e)
        {
            if (dim > 1)
            {
                var prodottiOrdinati = p.Take(dim).OrderBy(item => item.nome).ToArray();
                Array.Copy(prodottiOrdinati, p, dim);
                visualizza(p);
            }
            else
            {
                MessageBox.Show("Inserire almeno due prodotti");
            }
        }

        private void Somma_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                double tot = 0;
                for (int i = 0; i < dim; i++)
                {
                    tot += p[i].prezzo;
                }
                MessageBox.Show("Il prezzo totale è " + tot + "€");
            }
            else
            {
                MessageBox.Show("La lista è vuota");
            }
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            StreamWriter salva = new StreamWriter("Salva.Txt");
            for (int i = 0; i < dim; i++)
            {
                salva.WriteLine(p[i].nome + ": " + p[i].prezzo + "€");
            }
            salva.Close();
            MessageBox.Show("File salvato");
        }

        private void Leggi_Click(object sender, EventArgs e)
        {
            if (File.Exists("Salva.Txt"))
            {
                ElencoProdotti.Items.Clear();
                string lettura;
                if (File.Exists("Salva.txt"))
                {
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
            }
            else
            {
                MessageBox.Show("Il file non esiste");
            }
        }

        private void Minimo_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                double minf = 100000000000000000, min, min1;
                string minnf = "";
                for (int i = 0; i < dim; i++)
                {
                    for (int j = i + 1; j < dim; j++)
                    {
                        min = p[i].prezzo;
                        string minn = p[i].nome;
                        min1 = p[j].prezzo;
                        string minn1 = p[j].nome;
                        if (min < min1)
                        {
                            if (minf > min)
                            {
                                minf = min;
                                minnf = minn;
                            }
                        }
                        else
                        {
                            if (minf > min1)
                            {
                                minf = min1;
                                minnf = minn1;
                            }
                        }
                    }
                }
                MessageBox.Show("Il prodotto con il prezzo minore è " + minnf + " con prezzo " + minf + "€");
            }
            else
            {
                MessageBox.Show("Non sono presenti prodotti");
            }
        }

        private void Massimo_Click(object sender, EventArgs e)
        {
            if (dim > 0)
            {
                double maxf = 0, max, max1;
                string maxnf = "";
                for (int i = 0; i < dim; i++)
                {
                    for (int j = i + 1; j < dim; j++)
                    {
                        max = p[i].prezzo;
                        string maxn = p[i].nome;
                        max1 = p[j].prezzo;
                        string maxn1 = p[j].nome;
                        if (max > max1)
                        {
                            if (maxf < max)
                            {
                                maxf = max;
                                maxnf = maxn;
                            }
                        }
                        else
                        {
                            if (maxf < max1)
                            {
                                maxf = max1;
                                maxnf = maxn1;
                            }
                        }
                    }
                }
                MessageBox.Show("Il prodotto con il prezzo maggiore è " + maxnf + " con prezzo " + maxf + "€");
            }
            else
            {
                MessageBox.Show("Non sono presenti prodotti");
            }
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Perce.Text))
            {
                MessageBox.Show("Inserire una percentuale");
            }
            else
            {
                double percentuale = Convert.ToDouble(Perce.Text);
                for (int i = 0; i < dim; i++)
                {
                    p[i].prezzo += p[i].prezzo * (percentuale / 100);
                }
                visualizza(p);
                return;
            }//
        }
    }
}
