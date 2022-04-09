using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjForca
{
    public partial class Form1 : Form
    {

        Forca jogo;
        Label[] letras; 
        string letrasjaDigitadas = "";
        int erros = 0;

        string[] lista; 
        string[] dicas; 

        SoundPlayer som; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencherLista();
            jogo = new Forca(lista,dicas, 0); 
            jogo.SortearPalavra(); 
            string p = jogo.devolvePalavra(); 
            desenharPalavra(p);
            Temporizador.Enabled = true; 
            string caminho = Environment.CurrentDirectory + "\\fundosom.wav";            
            som = new SoundPlayer();
            som.SoundLocation = caminho;
            som.PlayLooping();
            lblDica.Text = "DICA DA PALAVRA: " + jogo.devolveDica();          
            }

        private void PreencherLista()
        {
            string caminho = Environment.CurrentDirectory + "\\lista.txt";
            StreamReader arquivo = new StreamReader(caminho);
            int qtd = File.ReadAllLines(caminho).Count();

            lista = new string[qtd];
            dicas = new string[qtd];

            for (int i = 0; i < qtd; i++)
            {
                string[] palavras = arquivo.ReadLine().Split(',');
                lista[i] = palavras[0];
                dicas[i] = palavras[1];
            }

            arquivo.Close();
        }

        private void desenharPalavra(string p)
        {
            letras = new Label[p.Length];
            int pv = 40, ph = 40;
            for (int i = 0; i < letras.Count(); i++)
            {
                letras[i] = new Label();
                letras[i].Text = "?";
                letras[i].BackColor = Color.White;
                letras[i].ForeColor = Color.Red;
                letras[i].AutoSize = false;
                letras[i].Width = 40;
                letras[i].Height = 40;
                letras[i].BorderStyle = BorderStyle.FixedSingle;
                letras[i].TextAlign = ContentAlignment.MiddleCenter;
                if (i % 10 == 0 && i != 0)
                {
                    pv = pv + 45;
                    ph = 40;
                }
                letras[i].Top = pv;
                letras[i].Left = ph;
                pnPalavraSecreta.Controls.Add(letras[i]);
                letras[i].Show(); 
                ph += 45;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            desenharLetras(txtLetra.Text);
            txtLetra.Clear();
            txtLetra.Focus();
        }

        private void desenharLetras(string letra)
        {

            string p = jogo.devolvePalavra();
            bool achou = false;

            if (!letrasjaDigitadas.Contains(letra) && !letra.Equals(""))
            {
                letrasjaDigitadas += letra;
                lblLetrasDigitadas.Text = letrasjaDigitadas;
            }
            else
            {
                if (!letra.Equals(""))
                {
                    MessageBox.Show("Letra já digitada.");
                }
                return;
            }
            

            for (int i = 0; i < p.Length; i++)
            {
                if (p.Substring(i,1).Equals(letra))
                {
                    letras[i].Text = letra;
                    achou = true;
                }
            }

            if (achou == false)
            {
                erros++;
                desenharBoneco();
            }

            if (erros == 6)
            {
                Temporizador.Enabled = false;
                MessageBox.Show("Voce perdeu. A palavra era: " + p);
                Temporizador.Enabled = true;
                NovoJogo(); 
            }

            TestarVitoria();
        }

        private void TestarVitoria()
        {
            string p = jogo.devolvePalavra();
            string tmp="";

            for (int i = 0; i < letras.Count(); i++)
            {
                tmp += letras[i].Text;
            }

            if (p.Equals(tmp))
            {
                Temporizador.Enabled = false;
                MessageBox.Show("Parabens você venceu!!!");
                Temporizador.Enabled = true;
                NovoJogo();
            }
        }

        private void NovoJogo()
        {
            pnPalavraSecreta.Controls.Clear();
            jogo.SortearPalavra();
            erros = 0;
            desenharPalavra(jogo.devolvePalavra());
            pbEnforcado.Image = null; 
            lblLetrasDigitadas.Text = "";
            letrasjaDigitadas = "";
            lbCronometro.Text = "60";
            lblDica.Text = "DICA DA PALAVRA: " + jogo.devolveDica();   
        }

        private void desenharBoneco()
        {
            try
            {
                string pasta = Environment.CurrentDirectory + "\\imagens\\";
                string arquivo = pasta + "forca" + erros.ToString() + ".png";
                pbEnforcado.Image = Image.FromFile(arquivo);
            }
            catch (Exception erro) {

                MessageBox.Show("arquivo de imagens não existe:" +
                    erro.Message);
                this.Dispose();
            }
            
        }

        private void txtLetra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnJogar_Click(sender, e);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            int segundo = Convert.ToInt16(lbCronometro.Text);
            segundo--;
            lbCronometro.Text = segundo.ToString();

            if (segundo == 0)
            {
                Temporizador.Enabled = false;
                MessageBox.Show("Tempo esgotado. A palavra era:" +
                    jogo.devolvePalavra());
                Temporizador.Enabled = true;
                NovoJogo();
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }
    }
}
