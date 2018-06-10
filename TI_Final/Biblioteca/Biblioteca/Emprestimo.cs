using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Emprestimo
    {
        private Livro livro;
        private Usuario usuario;
        private int tipo;
        private DateTime data;

        public Emprestimo(ref Livro livro, ref Usuario usuario, int tipo, DateTime data)
        {
            this.Livro = livro;
            this.Usuario = usuario;
            this.Tipo = tipo;
            this.Data = data;
        }

        public int Tipo { get => tipo; set => tipo = value; }
        public DateTime Data { get => data; set => data = value; }
        internal Livro Livro { get => livro; set => livro = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
