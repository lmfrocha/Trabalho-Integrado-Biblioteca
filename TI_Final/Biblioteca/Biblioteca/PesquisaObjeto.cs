using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class PesquisaObjeto
    {
        private static Usuario BinarySearch(int codigoL, Usuario[] vetor, int ini, int fim)
        {
            if (ini > fim) return null;
            int meio = (ini + fim) / 2;
            if (vetor[meio].Codigo == codigoL) return vetor[meio];
            else if (codigoL > vetor[meio].Codigo) return BinarySearch(codigoL, vetor, (meio + 1), fim);
            else return BinarySearch(codigoL, vetor, ini, (meio - 1));
        }

        public static bool PesquisaUsuario(int CodigoLivro, Usuario[] vetorDeUsuario)
        {
            int inicio = 0; int fim = vetorDeUsuario.Length;

            if (BinarySearch(CodigoLivro, vetorDeUsuario, inicio, fim) != null)
            {
                return true;
            }
            else return false;

        }

        private static Livro BinarySearch(int codigoL, Livro[] vetor, int ini, int fim)
        {
            if (ini > fim) return null;
            int meio = (ini + fim) / 2;
            if (vetor[meio].Codigo == codigoL) return vetor[meio];
            else if (codigoL > vetor[meio].Codigo) return BinarySearch(codigoL, vetor, (meio + 1), fim);
            else return BinarySearch(codigoL, vetor, ini, (meio - 1));
        }
        public static bool PesquisaLivro(int CodigoLivro, Livro[] vetorDeLivro)
        {
            int inicio = 0; int fim = vetorDeLivro.Length;

            if (BinarySearch(CodigoLivro, vetorDeLivro, inicio, fim) != null)
            {
                return true;
            }
            else return false;
        }


    }
}
