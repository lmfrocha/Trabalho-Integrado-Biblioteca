using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Arvore
    {
        //atributos da classe Arvore
        private Nodo raiz = null; // raiz da arvore
        private int quantidade = 0; // quantidade de nos internos
        private string folhas = ""; //atributo que será usado no metodo de leitura;


        // Metodo para devolver a quantidade de nos internos. OBS: Não são folha;
        public int quantidade_nos_internos()
        {
            return quantidade;
        }
        //verifica se um determinado nodo é folha
        public bool no_e_externo(Nodo no)
        {
            return (no.Direita == null) && (no.Esquerda == null);
        }
        //Cria um novo nodo "raiz"
        public Nodo novo_nodo(Nodo raiz)
        {
            Nodo no = new Nodo();
            no.Nodo_raiz = raiz;
            return no;
        }
        // Metodo não gerenrico, para inserir um dado na arvore;
        public void insere(int dado)
        {
            Nodo no_auxiliar;
            if (quantidade == 0)
            {
                // Com a arvore vazia, devemos criar o primeiro nodo, que sera a raiz;
                no_auxiliar = new Nodo();
                raiz = no_auxiliar;
            }
            else
            {
                // Localiza o local onde deverá ser inserido o novo nó;
                no_auxiliar = raiz;
                while (no_e_externo(no_auxiliar) == false)
                {
                    if (dado > no_auxiliar.Valor_do_no)
                    {
                        no_auxiliar = no_auxiliar.Direita;
                    }
                    else
                    {
                        no_auxiliar = no_auxiliar.Esquerda;
                    }
                }

                no_auxiliar.Direita = novo_nodo(no_auxiliar);
                no_auxiliar.Esquerda = novo_nodo(no_auxiliar);
                quantidade++;


            }
        }


        ////private void Ler(Nodo no)
        //{
        //    if(no_e_externo(no))
        //    {
        //        return;
        //    }
        //    // Recursividade
        //    Ler(no.Esquerda);
        //    folhas = folhas + " - " + Convert.ToInt32(no.Valor_do_no);
        //    Ler(no.Direita);
        //}





    }
}
