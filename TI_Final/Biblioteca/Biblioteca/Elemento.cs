using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Elemento
    {
        public Dados d;
        public Elemento prox;
        
        /// <summary>
        /// Construtor do Objeto Elemento, esta classe serve para acessar os dados internos do objeto
        /// </summary>
        /// <param name="dado">Dados do objeto</param>
        public Elemento(Dados dado)
        {
            this.d = dado;
            this.prox = null;
        }
    }
}
