using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class OrdenaUsuario
    {
    	/// <summary>
    	/// Médoto para Ordenar um vetor de objetos Usuários por código, do menor para o maior
    	/// </summary>
    	/// <param name="vetor">Vetor de objetos do tipo Usuário passado por parametro</param>
    	/// <returns></returns>
        public static Usuario[] QuickSort(Usuario[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSort(vetor, inicio, fim);
            return vetor;
        }

        /// <summary>
        /// Método Quicksort recursivo
        /// </summary>
        /// <param name="vetor">Vetor passado por parametro</param>
        /// <param name="inicio">Pivo inicial</param>
        /// <param name="fim">Pivo Final</param>
        private static void QuickSort(Usuario[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                Usuario pivo = vetor[inicio];
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
                        Usuario troca = vetor[i];
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
        /// Metodo para ordenar contando
        /// </summary>
        /// <param name="vetor"></param>
        /// <returns></returns>
        public static Usuario[] QuickSortQuant(Usuario[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSortquant(vetor, inicio, fim);
            return vetor;
        }

        /// <summary>
        /// Método quicksort modificado para ordenar contando
        /// </summary>
        /// <param name="vetor"></param>
        /// <param name="inicio"></param>
        /// <param name="fim"></param>
        private static void QuickSortquant(Usuario[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                Usuario pivo = vetor[inicio];
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
                        Usuario troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = pivo;

                QuickSortquant(vetor, inicio, f - 1);
                QuickSortquant(vetor, f + 1, fim);

            }
        }
        
        /// <summary>
        /// Método para ordenar por quantidade passando o vetor de usuários.
        /// </summary>
        /// <param name="vetUsuarios"></param>
        /// <returns></returns>
        public  static Usuario[] OrdernarPorQuantidade(Usuario[] vetUsuarios)
        {
            
            Usuario[] vet = QuickSortQuant(vetUsuarios);
            return vet.ToArray();
        }
    }
}
