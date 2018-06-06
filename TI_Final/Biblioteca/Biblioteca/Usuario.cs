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


        private static Usuario BinarySearch(int codigoL, Usuario[] vetor, int ini, int fim)
        {
            if (ini > fim) return null;
            int meio = (ini + fim) / 2;
            if (vetor[meio].Codigo == codigoL) return vetor[meio];
            else if (codigoL > vetor[meio].Codigo) return BinarySearch(codigoL, vetor, (meio + 1), fim);
            else return BinarySearch(codigoL, vetor, ini, (meio - 1));
        }

        public bool Pesquisa(int CodigoLivro, Usuario[] vetorDeUsuario)
        {
            int inicio = 0; int fim = vetorDeUsuario.Length;

            if (BinarySearch(CodigoLivro, vetorDeUsuario, inicio, fim) != null)
            {
                return true;
            }
            else return false;

        }



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
