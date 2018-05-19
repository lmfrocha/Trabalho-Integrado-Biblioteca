using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class LivroVirtual : Livro
    {
        //Construtor
        public LivroVirtual(int codigo, string nome, int tipo, double precoP)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Tipo = tipo;
            this.PrecoP = precoP;
        }
    }
}
