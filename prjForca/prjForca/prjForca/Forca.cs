using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjForca
{
    class Forca
    {
        private string[] palavras;
        private string[] dicas;

        private int pos;

        public Forca(string[] palavras, string[] dicas, int pos)
        {
            this.palavras = palavras;
            this.dicas = dicas;
            this.pos = pos;
        }

        public void SortearPalavra()
        {
            Random sorteio = new Random(); // sorteio
            this.pos = sorteio.Next(0,palavras.Count());
        }

        public string devolvePalavra()
        {
            return palavras[pos];
        }

        public string  devolveDica()
        {
            return dicas[pos];
        }
    }
}
