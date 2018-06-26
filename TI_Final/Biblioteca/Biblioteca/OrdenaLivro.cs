using System;
using System.Linq;

namespace Biblioteca
{
    static class OrdenaLivro
    {
    	/// <summary>
    	/// Método público para ordenar o vetor de livros
    	/// </summary>
    	/// <param name="vetor">Vetor de Livros</param>
    	/// <returns>Vetor Ordenado</returns>
        public static Livro[] QuickSort(Livro[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSort(vetor, inicio, fim);
            return vetor;
        }

        /// <summary>
        /// Método interno da classe estática que faz a operação de ordenação
        /// Quick sort
        /// </summary>
        /// <param name="vetor">Vetor de Livros passado por parametro</param>
        /// <param name="inicio">Inicio do vetor</param>
        /// <param name="fim">Ultima posição do vetor</param>
        private static void QuickSort(Livro[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                Livro pivo = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f)
                {
                    if (vetor[i].Codigo < pivo.Codigo)
                        i++;

                    else if (pivo.Codigo < vetor[f].Codigo)
                        f--;

                    else
                    {
                        Livro troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = pivo;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }
        }

		/// <summary>
		/// Método que ordena por quantidade de livros
		/// </summary>
		/// <param name="vetor">Vetor passado por parametro</param>
		/// <returns>Vetor ordenado</returns>
        public static Livro[] OrderPorQuantidade(Livro[] vetor)
        {
            
            Livro[] vet = QuickSortquant(vetor);
            return vet.ToArray();
        }
        /// <summary>
        /// Método interno do quicksort
        /// </summary>
        /// <param name="vetor"></param>
        /// <param name="inicio"></param>
        /// <param name="fim"></param>
        private static void QuickSortQuant(Livro[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                Livro pivo = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f)
                {
                    if (vetor[i].QuantidadeEmprestimo < pivo.QuantidadeEmprestimo)
                        i++;

                    else if (pivo.QuantidadeEmprestimo < vetor[f].QuantidadeEmprestimo)
                        f--;

                    else
                    {
                        Livro troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = pivo;

                QuickSortQuant(vetor, inicio, f - 1);
                QuickSortQuant(vetor, f + 1, fim);
            }
        }
        
        /// <summary>
        /// Ordenar por quantidade os livros.
        /// </summary>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public static Livro[] QuickSortquant(Livro[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSortQuant(vetor, inicio, fim);
            return vetor;
        }
    }
}
