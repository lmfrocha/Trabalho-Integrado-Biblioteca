using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Lista
    {
        public Elemento prim, ult;

        /// <summary>
        /// Construtor. Cria uma lista vazia com sentinela.
        /// </summary>
        public Lista()
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        /// <summary>
        /// Busca dados. Precisa receber um objeto com valor igual ao que se deseja buscar.
        /// O objeto precisa ter um método sobrescrito Equals para indicar se é igual a outro objeto da mesma classe
        /// </summary>
        /// <param name="v">O objeto com o valor a ser buscado</param>
        /// <returns>O objeto procurado ou null, caso não exista</returns>
        public Dados buscar(Dados v)
        {
            Elemento aux = this.prim.prox;
            while (aux != null)
            {
                if (aux.d.Equals(v))
                    return aux.d;
                else aux = aux.prox;
            }
            return null;
        }

        /// <summary>
        /// Insere no final da lista.
        /// </summary>
        /// <param name="novo">Objeto novo que se deseja inserir</param>
        public void addFim(Dados novo)
        {
            Elemento aux = new Elemento(novo);
            this.ult.prox = aux;
            this.ult = aux;
        }
    }
}
