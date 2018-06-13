using System;

namespace Biblioteca
{
    public class Usuario : Dados
    {
        public Usuario(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEmprestimo { get; set; }

        public Boolean Equals(Dados other)
        {
            Usuario aux = (Usuario)(other);
            if (this.Codigo == aux.Codigo) return true;
            else return false;
        }

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
