using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Leitor
    {
        private string nome_leitor;
        private int matricula_leitor;

        public string Nome_leitor { get => nome_leitor; set => nome_leitor = value; }
        public int Matricula_leitor { get => matricula_leitor; set => matricula_leitor = value; }

        private Leitor(string nome_leitor, string matricula_leitor)
        {
            this.nome_leitor = Nome_leitor;
            this.matricula_leitor= Matricula_leitor;
        }
    }
}
