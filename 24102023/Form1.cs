using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
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
        public int indice = 0;

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
                if (double.TryParse(Prezzo.Text, out p[dim].prezzo))
                {
                    aggiungi(p[dim].nome, p[dim].prezzo, percorso);
                    dim++;
                    indice++;
                    Nome.Clear();
                    Prezzo.Clear();
                }
                else
                {
                    MessageBox.Show("Devi inserire un numero");
                    Prezzo.Clear();
                }
            }
        }
        private void aggiungi(string nome, double prezzo, string percorso)
        {
            string[] salva = File.ReadAllLines(percorso);
            bool prodottouguale = false;
            for (int i = 0; i < salva.Length; i++)
            {
                string[] dati = salva[i].Split(';');
                if (dati[0] == nome && double.TryParse(dati[1], out double prezzouguale))
                {
                    if (prezzo == prezzouguale)
                    {
                        int nprodotti;
                        if (int.TryParse(dati[2], out nprodotti))
                        {
                            nprodotti++;
                            salva[i] = $"{nome};{prezzo};{nprodotti};0;".PadRight(riga - 4) + "##";
                            prodottouguale = true;
                            break;
                        }
                    }
                }
            }
            if (!prodottouguale)
            {
                var apertura = new FileStream(percorso, FileMode.Append, FileAccess.Write, FileShare.Read);
                StreamWriter scrivi = new StreamWriter(apertura);
                scrivi.WriteLine($"{nome};{prezzo};1;0;".PadRight(riga - 4) + "##");
                scrivi.Close();
            }
            else
            {
                File.WriteAllLines(percorso, salva);
            }
        }
        private void resetta(string percorso)
        {
            File.WriteAllText(percorso, string.Empty);
            Lista.Items.Clear();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler resettare il file?","Conferma", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                resetta(percorso);
                MessageBox.Show("File resettato");
            }
            else
            {
                MessageBox.Show("Il file non è stato resettato");
            }
            
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
            int indice = Indice(RicercaMod.Text);
            if (indice == -1)
            {
                MessageBox.Show("Il prodotto non esiste");
            }
            else if (indice >= 0)
            {
                string[] prodotto = ricercaprod(RicercaMod.Text);
                string riga;
                var salva = new FileStream(percorso, FileMode.Open, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(salva);
                salva.Seek(lunghezza * indice, SeekOrigin.Begin);
                riga = $"{nome};{prezzo};{prodotto[2]};0;".PadRight(lunghezza - 4) + "##";
                byte[] bytes = Encoding.UTF8.GetBytes(riga);
                writer.Write(bytes);
                writer.Close();
                salva.Close();
                MessageBox.Show("Prodotto modificato");
            }
        }
        public void CancellazioneF(string percorso)
        {
            int indice = Indice(Ricerca.Text);
            if (string.IsNullOrEmpty(Ricerca.Text))
            {
                MessageBox.Show("Inserire un prodotto");
                return;
            }
            else if (indice == -1)
            {
                MessageBox.Show("Il prodotto non esiste");
            }
            else if (indice >= 0)
            {
                List<string> righe = new List<string>();
                using (StreamReader salva = File.OpenText(percorso))
                {
                    string lettore;
                    while ((lettore = salva.ReadLine()) != null)
                    {
                        righe.Add(lettore);
                    }
                }
                righe.RemoveAt(indice);
                using (StreamWriter scrivi = new StreamWriter(percorso, false))
                {
                    foreach (string riga in righe)
                    {
                        scrivi.WriteLine(riga);
                    }
                }
                MessageBox.Show("Eliminato");
            }
        }
        private void CancellaF_Click(object sender, EventArgs e)
        {
            CancellazioneF(percorso);
            Ricerca.Clear();
        }
        private void Modif_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RicercaMod.Text))
            {
                MessageBox.Show("Inserire il prodotto da cercare");
            }
            else if (string.IsNullOrEmpty(NuovoNome.Text))
            {
                MessageBox.Show("Inserire il nuovo nome");
            }
            else if (string.IsNullOrEmpty(NuovoPrezzo.Text))
            {
                MessageBox.Show("Inserire il nuovo prezzo");
            }
            else
            {
                if (double.TryParse(NuovoPrezzo.Text, out double nuovoprezzo))
                {
                    Modifica(NuovoNome.Text, double.Parse(NuovoPrezzo.Text), percorso, riga);
                    RicercaMod.Clear();
                    NuovoNome.Clear();
                    NuovoPrezzo.Clear();
                }
                else
                {
                    MessageBox.Show("Devi inserire un numero");
                    NuovoPrezzo.Clear();
                }
            }
        }
        private void ApriFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("Salva.dat"))
            {
                string file = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Salva.dat");
                System.Diagnostics.Process.Start(file);
            }
            else
            {
                MessageBox.Show("Il file non è presente");
            }
        }
        public string[] ricercaprod(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("Salva.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        sr.Close();
                        return dati;
                    }
                    riga++;
                }
            }
            return null;
        }
        public void CancellaL(string percorso, string nome, int lunghezza)
        {
            int indice = Indice(Ricerca.Text);
            if (string.IsNullOrEmpty(Ricerca.Text))
            {
                MessageBox.Show("Inserire un prodotto");
                return;
            }
            else if (indice == -1)
            {  
                MessageBox.Show("Il prodotto non esiste");
            }
            else if (indice >= 0)
            {
                string[] prodotto = ricercaprod(Ricerca.Text);
                string line;
                var salva = new FileStream(percorso, FileMode.Open, FileAccess.Write);
                BinaryWriter scrivi = new BinaryWriter(salva);
                salva.Seek(lunghezza * indice, SeekOrigin.Begin);
                line = $"{prodotto[0]};{prodotto[1]};{prodotto[2]};1;".PadRight(lunghezza - 4) + "##";
                byte[] bytes = Encoding.UTF8.GetBytes(line);
                scrivi.Write(bytes, 0, bytes.Length);
                scrivi.Close();
                salva.Close();
                MessageBox.Show("Prodotto cancellato logicamente");
            }
        }
        private int Indicerec(string nome)
        {
            int riga = 0;
            using (StreamReader salva = File.OpenText("Salva.dat"))
            {
                string lettore;
                while ((lettore = salva.ReadLine()) != null)
                {
                    string[] dati = lettore.Split(';');
                    if (dati[3] == "1" && dati[0] == nome)
                    {
                        salva.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }
        public string[] ricercaprodrec(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("Salva.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "1" && dati[0] == nome)
                    {
                        sr.Close();
                        return dati;
                    }
                    riga++;
                }
            }
            return null;
        }
        public void Recuper(string percorso, string nome, int lunghezza)
        {
            int indice = Indicerec(RicercaRec.Text);
            if (string.IsNullOrEmpty(RicercaRec.Text))
            {
                MessageBox.Show("Inserire un prodotto");
            }
            else if (indice == -1)
            {
                MessageBox.Show("Il prodotto non è stato eliminato/è già stato recuperato");
            }
            else if (indice >= 0)
            {
                string[] prodotto = ricercaprodrec(RicercaRec.Text);
                string line;
                var salva = new FileStream(percorso, FileMode.Open, FileAccess.Write);
                BinaryWriter scrivi = new BinaryWriter(salva);
                salva.Seek(lunghezza * indice, SeekOrigin.Begin);
                line = $"{prodotto[0]};{prodotto[1]};{prodotto[2]};0;".PadRight(lunghezza - 4) + "##";
                byte[] bytes = Encoding.UTF8.GetBytes(line);
                scrivi.Write(bytes, 0, bytes.Length);
                scrivi.Close();
                salva.Close();
                MessageBox.Show("Prodotto recuperato");
            }
        }
        private void CancellazioneL_Click(object sender, EventArgs e)
        {
            CancellaL(percorso, Ricerca.Text, riga);
            Ricerca.Clear();
        }

        private void Recupera_Click(object sender, EventArgs e)
        {
            Recuper(percorso, RicercaRec.Text, riga);
            RicercaRec.Clear();
        }
        public void Visual(string percorso)
        {
            string lettura;
            StreamReader leggi = new StreamReader(percorso);
            lettura = leggi.ReadLine();
            Lista.Items.Clear();
            if (File.Exists(percorso))
            {
                while (lettura != null)
                {
                    string[] dati = lettura.Split(';');
                    if (dati[3] == "0")
                    {
                        Lista.Items.Add(lettura);
                        lettura = leggi.ReadLine();
                    }
                    else
                    {
                        lettura = leggi.ReadLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("Il file è vuoto o non esiste");
            }
            leggi.Close();
        }

        private void Visualizza_Click(object sender, EventArgs e)
        {
            Visual(percorso);
            MessageBox.Show("Tutti i prodotti sono stati visualizzati");
        }

        private void Elimina1_Click(object sender, EventArgs e)
        {
            string[] salva = File.ReadAllLines(percorso);
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
                 for (int i = 0; i < salva.Length; i++)
                 {
                     string[] dati = salva[i].Split(';');
                     if (dati[0] == Nome.Text && double.TryParse(dati[1], out double prezzouguale))
                     {
                         if (Prezzo.Text == prezzouguale.ToString())
                         {
                             if (int.TryParse(dati[2], out int nprodotti))
                             {
                                 if (nprodotti >= 2)
                                 {
                                     nprodotti--;
                                     salva[i] = $"{Nome.Text};{Prezzo.Text};{nprodotti};0;".PadRight(riga - 4) + "##";
                                    MessageBox.Show("Prodotto eliminato di 1 quantità");
                                     Nome.Clear();
                                     Prezzo.Clear();
                                     break;
                                 }
                                 else
                                 {
                                     MessageBox.Show("Il prodotto deve essere in una quantità maggiore di 1");
                                     Nome.Clear();
                                     Prezzo.Clear();
                                     break;
                                 }
                             }
                         }
                         else
                         {
                             MessageBox.Show("Il prodotto non esiste/ha quantità 1");
                             Nome.Clear();
                             Prezzo.Clear();
                         }
                     }
                     else if (dati[0] != Nome.Text)
                     {
                         MessageBox.Show("Il prodotto non esiste/ha quantità 1");
                         Nome.Clear();
                         Prezzo.Clear();
                     }
                 }
                 File.WriteAllLines(percorso, salva);
            }
        }
    }
}
