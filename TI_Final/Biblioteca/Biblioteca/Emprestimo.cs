using System;

namespace Biblioteca
{
    public class Emprestimo
    {
        public Livro Livro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Emprestimo(Livro livro, Usuario usuario, DateTime data)
        {
            this.Livro = livro;
            this.Usuario = usuario;
            this.Data = data; 
        }
    }
}
