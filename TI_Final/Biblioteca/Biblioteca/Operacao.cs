using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Operacao
    {
        private Livro livro;
        private Usuario usuario;
        private int tipo;
        private DateTime data;

        internal Livro Livro
        {
            get
            {
                return livro;
            }

            set
            {
                livro = value;
            }
        }

        internal Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public Operacao(ref Livro livro, ref Usuario usuario, int tipo, DateTime data)
        {
            this.Livro = livro;
            this.Usuario = usuario;
            this.Tipo = tipo;
            this.Data = data;
        }

        //public int Tipo { get => tipo; set => tipo = value; }
        //public DateTime Data { get => data; set => data = value; }
        //internal Livro Livro { get => livro; set => livro = value; }
        //internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
