using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro
    {
        private string nome_livro;
        private string nome_autor;
        private string editora;
        private int edicao_livro;
        private DateTime ano;
        private int codigo_livro;

        public string Nome_livro { get => nome_livro; set => nome_livro = value; }
        public string Nome_autor { get => nome_autor; set => nome_autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public int Edicao_livro { get => edicao_livro; set => edicao_livro = value; }
        public DateTime Ano { get => ano; set => ano = value; }
        public int Codigo_livro { get => codigo_livro; set => codigo_livro = value; }

        private Livro(string nome_livro, string nome_autor, string editora, int edicao_livro, DateTime ano, int condigo_livro)
        {
            this.nome_livro = Nome_livro;
            this.nome_autor = Nome_autor;
            this.editora = Editora;
            this.edicao_livro = Edicao_livro;
            this.ano = Ano;
            this.codigo_livro = Codigo_livro;
        }
    }
}
