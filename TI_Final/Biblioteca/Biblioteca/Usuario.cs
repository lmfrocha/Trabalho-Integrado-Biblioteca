using System;

namespace Biblioteca
{
    public class Usuario : Dados
    {
    	/// <summary>
    	/// Construtor padrão do Usuário
    	/// </summary>
    	/// <param name="codigo">Código do Usuário</param>
    	/// <param name="nome">Nome do usuário</param>
        public Usuario(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
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
        /// Get and Set Quantidade de Empréstimos
        /// </summary>
        public int QuantidadeEmprestimo { get; set; }

        /// <summary>
        /// Método para comparar um usuário externo com o interno
        /// </summary>
        /// <param name="other">Outro objeto do tipo usuário</param>
        /// <returns>True para verdadeiro ou False para falso</returns>
        public Boolean Equals(Dados other)
        {
            Usuario aux = (Usuario)(other);
            if (this.Codigo == aux.Codigo) return true;
            else return false;
        }

        /// <summary>
        /// Método para comparar se o usuário é diferente
        /// </summary>
        /// <param name="other">Outro objeto do tipo usuário</param>
        /// <returns>0 quando é igual, 1 quando é maior, -1 quando é menor</returns>
        public int CompareTo(Dados other)
        {
            Usuario aux = (Usuario)(other);
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
