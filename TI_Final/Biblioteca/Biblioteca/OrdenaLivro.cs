using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class OrdenaLivro
    {
        public static Livro[] quickSort(Livro[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            quickSort(vetor, inicio, fim);
            return vetor;
        }
        private static void quickSort(Livro[] vetor, int inicio, int fim)
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

                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);

            }
        }
    }
}
