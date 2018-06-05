using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Elemento
    {
        public Dados d;
        public Elemento prox;
        public Elemento(Dados dado)
        {
            this.d = dado;
            this.prox = null;
        }
    }
}
