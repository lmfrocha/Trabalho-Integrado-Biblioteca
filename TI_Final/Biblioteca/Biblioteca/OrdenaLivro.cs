using System;
using System.Linq;

namespace Biblioteca
{
    static class OrdenaLivro
    {
        public static Livro[] QuickSort(Livro[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSort(vetor, inicio, fim);
            return vetor;
        }

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


        public static Livro[] OrderPorQuantidade(Livro[] vetor)
        {
            
            Livro[] vet = QuickSortquant(vetor);
            return vet.ToArray();
        }
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
        public static Livro[] QuickSortquant(Livro[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            QuickSortQuant(vetor, inicio, fim);
            return vetor;
        }
    }
}
