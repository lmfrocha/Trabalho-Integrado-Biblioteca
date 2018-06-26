using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class PesquisaObjeto
    {
    	/// <summary>
    	/// Médoto recursivo para buscar o usuário
    	/// </summary>
    	/// <param name="codigoL">Código do Livro</param>
    	/// <param name="vetor">Vetor passado por parametro</param>
    	/// <param name="ini">Inicio do Vetor</param>
    	/// <param name="fim">Fim do Vetor</param>
    	/// <returns>Objeto Usuário ou null</returns>
        private static Usuario BinarySearch(int codigoL, Usuario[] vetor, int ini, int fim)
        {
            if (ini > fim) return null;
            int meio = (ini + fim) / 2;
            if (vetor[meio].Codigo == codigoL) return vetor[meio];
            else if (codigoL > vetor[meio].Codigo) return BinarySearch(codigoL, vetor, (meio + 1), fim);
            else return BinarySearch(codigoL, vetor, ini, (meio - 1));
        }
        /// <summary>
        /// Método de busca Binária do Usuário
        /// </summary>
        /// <param name="CodigoLivro">Código do Livro</param>
        /// <param name="vetorDeUsuario">Vetor de usuário passado por parametro</param>
        /// <returns>Objeto Usuário ou Null</returns>
        public static Usuario PesquisaUsuario(int CodigoLivro, Usuario[] vetorDeUsuario)
        {
            int inicio = 0; int fim = vetorDeUsuario.Length;

            Usuario aux = BinarySearch(CodigoLivro, vetorDeUsuario, inicio, fim);
            if (aux != null)
            {
                return aux;
            }
            else return null;
        }
        /// <summary>
        /// Método recursivo de pesquisa binária
        /// </summary>
        /// <param name="codigoL">Código do Livro</param>
        /// <param name="vetor">Vetor passado por parametro</param>
        /// <param name="ini">Inicio do Vetor</param>
    	/// <param name="fim">Fim do Vetor</param>
        /// <returns>Objeto Livro ou null</returns>
        private static Livro BinarySearch(int codigoL, Livro[] vetor, int ini, int fim)
        {
            if (ini > fim) return null;
            int meio = (ini + fim) / 2;
            if (vetor[meio].Codigo == codigoL) return vetor[meio];
            else if (codigoL > vetor[meio].Codigo) return BinarySearch(codigoL, vetor, (meio + 1), fim);
            else return BinarySearch(codigoL, vetor, ini, (meio - 1));
        }
        
        /// <summary>
        /// Método para pesquisar o Livro utilizando pesquisa Binária
        /// </summary>
        /// <param name="CodigoLivro">Código do Livro</param>
        /// <param name="vetorDeLivro">Vetor de Livro</param>
        /// <returns>Objeto Livro ou Null</returns>
        public static Livro PesquisaLivro(int CodigoLivro, Livro[] vetorDeLivro)
        {
            int inicio = 0; int fim = vetorDeLivro.Length;            

            Livro aux = BinarySearch(CodigoLivro, vetorDeLivro, inicio, fim);
            if (aux != null)
            {
                return aux;
            }
            else return null;
        }
    }
}
