using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : Dados
    {
        public Livro(int codigo, string nome, int tipo, float preco_por_pagina)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Tipo = tipo;
            this.Preco_por_pagina = preco_por_pagina;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public float Preco_por_pagina { get; set; }

        public int QuantidadeEmprestimo { get; set; }

        public Boolean Equals(Dados other)
        {
            Livro aux = (Livro)(other);
            if (this.Codigo == aux.Codigo) return true;
            else return false;
        }

        public int CompareTo(Dados other)
        {
            Livro aux = (Livro)(other);
            if (this.Codigo.Equals(aux.Codigo))
            {
                return 0;
            }
            else if (this.Codigo > aux.Codigo)
            {
                return 1;
            }
            else if (this.Codigo < aux.Codigo)
            {
                return -1;
            }
            return 3;
        }
    }
}
