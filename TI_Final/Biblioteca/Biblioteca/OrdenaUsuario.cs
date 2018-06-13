using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class OrdenaUsuario
    {
        public static Usuario[] QuickSort(Usuario[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSort(vetor, inicio, fim);
            return vetor;
        }

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
        public static Usuario[] QuickSortQuant(Usuario[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSortquant(vetor, inicio, fim);
            return vetor;
        }

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
        public  static Usuario[] OrdernarPorQuantidade(Usuario[] vetUsuarios)
        {
            
            Usuario[] vet = QuickSortQuant(vetUsuarios);
            return vet.ToArray();
        }
    }
}
