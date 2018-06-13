using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Nodo
    {
        // ATRIBUTOS DA CLASSE Nodo
        private Nodo nodo_raiz = null;
        private Nodo direita = null;
        private Nodo esquerda = null;
        private int valor_do_no = 0;

        internal Nodo Nodo_raiz
        {
            get
            {
                return nodo_raiz;
            }

            set
            {
                nodo_raiz = value;
            }
        }

        internal Nodo Direita
        {
            get
            {
                return direita;
            }

            set
            {
                direita = value;
            }
        }

        internal Nodo Esquerda
        {
            get
            {
                return esquerda;
            }

            set
            {
                esquerda = value;
            }
        }

        public int Valor_do_no
        {
            get
            {
                return valor_do_no;
            }

            set
            {
                valor_do_no = value;
            }
        }

        //gets_sets dos atributos da classe Nodo
        //internal Nodo Nodo_raiz { get => nodo_raiz; set => nodo_raiz = value; }
        //internal Nodo Direita { get => direita; set => direita = value; }
        //internal Nodo Esquerda { get => esquerda; set => esquerda = value; }
        //public int Valor_do_no { get => valor_do_no; set => valor_do_no = value; } // será usado na hora de inserir, irei usar esse cara para comparar se meu no novo é maior ou menor que esse cara.
    }
}
