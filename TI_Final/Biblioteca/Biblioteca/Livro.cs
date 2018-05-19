using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    abstract class Livro
    {
        //Atributos dos Livros
        private int codigo;
        private string nome;
        private int tipo;
        private double precoP;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
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
        public double PrecoP
        {
            get
            {
                return precoP;
            }
            set
            {
                precoP = value;
            }
        }
    }
}
