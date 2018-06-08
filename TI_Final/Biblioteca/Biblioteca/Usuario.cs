using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Usuario : Dados
    {
        private int codigo;
        private string nome;

        public Usuario(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }



        public Boolean Equals(Dados other)
        {
            Usuario aux = (Usuario)(other);
            if (this.codigo == aux.Codigo) return true;
            else return false;
        }

        public int CompareTo(Dados other)
        {
            Usuario aux = (Usuario)(other);
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
