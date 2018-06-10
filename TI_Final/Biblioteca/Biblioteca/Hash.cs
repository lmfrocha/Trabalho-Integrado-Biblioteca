//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Biblioteca
//{
//    class Hash
//    {
//        Emprestimo[] hash = new Emprestimo[400000];
//        int prim = 31;
//        //int posicao = 0;
//        public Hash()
//        {

//        }

//        internal void insereHash(Emprestimo chave, string posicao)
//        {
//            ListCliente lista = new ListCliente();
//            int aux = retornaPosicao(posicao);
//            if (hash[aux] == null)
//            {
//                lista.Adiciona(chave);
//                hash[aux] = lista;
//            }
//            else
//            {
//                hash[aux].Adiciona(chave);
//            }

//        }
//        int retornaPosicao(string cpf)
//        {
//            string a = cpf.Substring(8, 3);
//            string b = cpf.Substring(12, 2);
//            int aux = int.Parse(a + b);
//            return aux % prim;
//        }
//        internal Cliente buscaHash(string entrada)
//        {
//            int aux = retornaPosicao(entrada);
//            if (hash[aux] == null)
//            {
//                MessageBox.Show("cliente não encontrado!");
//                return null;
//            }
//            else
//            {
//                return hash[aux].BuscarCliente(entrada);
//            }
//        }
//    }
//}
