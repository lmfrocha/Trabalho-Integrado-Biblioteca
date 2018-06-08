using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro: Dados
    {
        private int codigo;
        private string nome;
        private int tipo;
        private float preco_por_pagina;

        public Livro(int codigo, string nome, int tipo, float preco_por_pagina)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Tipo = tipo;
            this.Preco_por_pagina = preco_por_pagina;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public float Preco_por_pagina { get => preco_por_pagina; set => preco_por_pagina = value; }

        
        public Boolean Equals(Dados other)
        {
            Livro aux = (Livro)(other);
            if (this.codigo == aux.Codigo) return true;
            else return false;
        }

        public int CompareTo(Dados other)
        {
            Livro aux = (Livro)(other);
            if (this.codigo.Equals(aux.codigo))
            {
                return 0;
            }
            else if (this.codigo > aux.codigo)
            {
                return 1;
            }
            else if (this.codigo < aux.codigo)
            {
                return -1;
            }
            return 3;
        }
    }
}
