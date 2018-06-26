using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Operacao
    {
        private Livro livro;
        private Usuario usuario;
        private int tipo;
        private DateTime data;

        /// <summary>
        /// Get and Set Livro
        /// </summary>
        internal Livro Livro
        {
            get
            {
                return livro;
            }

            set
            {
                livro = value;
            }
        }

        /// <summary>
        /// Get and Set Usuário
        /// </summary>
        internal Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        /// <summary>
        /// Get and Set Tipo
        /// </summary>
        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        /// <summary>
        /// Get and Set Data
        /// </summary>
        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        /// <summary>
        /// Construtor padrão do Livro, utilizando Referencia aos objetos já existentes na memória do programa
        /// </summary>
        /// <param name="livro">Referencia de livro que veio do vetor de livros</param>
        /// <param name="usuario">Referencia de usuário que veio do vetor de usuário</param>
        /// <param name="tipo">tipo de livro que vem do vetor de emprestimos</param>
        /// <param name="data">data que vem para controlar se o usuario está regular ou suspenso</param>
        public Operacao(ref Livro livro, ref Usuario usuario, int tipo, DateTime data)
        {
            this.Livro = livro;
            this.Usuario = usuario;
            this.Tipo = tipo;
            this.Data = data;
        }
        
    }
}
