using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : Dados
    {
    	/// <summary>
    	/// Construturor padrão do Livro
    	/// </summary>
    	/// <param name="codigo">Código do Livro</param>
    	/// <param name="nome">Nome do Livro</param>
    	/// <param name="tipo">Tipo do Livro</param>
    	/// <param name="preco_por_pagina"> Preço por pagina</param>
        public Livro(int codigo, string nome, int tipo, float preco_por_pagina)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Tipo = tipo;
            this.Preco_por_pagina = preco_por_pagina;
        }

        /// <summary>
        /// Get and Set Código
        /// </summary>
        public int Codigo { get; set; }
        
        /// <summary>
        /// Get and Set Nome
        /// </summary>
        public string Nome { get; set; }
        
        /// <summary>
        /// Get and Set Tipo
        /// </summary>
        public int Tipo { get; set; }
        
        /// <summary>
        /// Get and Set Preço por pagina
        /// </summary>
        public float Preco_por_pagina { get; set; }

        /// <summary>
        /// Get and Set Quantidade de Emprestimo
        /// </summary>
        public int QuantidadeEmprestimo { get; set; }

        /// <summary>
        /// Método para verificar se um objeto é igual ao outro
        /// </summary>
        /// <param name="other">Objeto Outro livro</param>
        /// <returns>True se verdadeiro, Falso se False</returns>
        public Boolean Equals(Dados other)
        {
            Livro aux = (Livro)(other);
            if (this.Codigo == aux.Codigo) return true;
            else return false;
        }
        
        /// <summary>
        /// Método para Comparar o O livro
        /// </summary>
        /// <param name="other">Objeto Outro livro</param>
        /// <returns>0 é igual, 1 maior, -1 menor</returns>
        public int CompareTo(Dados other)
        {
            Livro aux = (Livro)(other);
            if (this.Codigo.Equals(aux.Codigo))
            {
                return 0;
            }
            else if (this.Codigo > aux.Codigo)
            {
                return 1;
            }
            else if (this.Codigo < aux.Codigo)
            {
                return -1;
            }
            return 3;
        }
    }
}
