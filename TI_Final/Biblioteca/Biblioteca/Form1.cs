using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Arvore livros;
            Arvore usuarios;
            Livro newLivro;
            Usuario newUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string nomeArq = openFileDialog1.FileName;
                //DateTime hora = DateTime.Now;
                if (!File.Exists(nomeArq));
                StreamReader arqDados = new StreamReader(nomeArq);

                string linha;
                string[] dados;
                linha = arqDados.ReadLine();
                //tempo = new Stopwatch();
                //tempo.Start();


                while (linha != null)
                {
                    dados = linha.Split(';');
                    Usuario novoCliente = new Usuario(int.Parse(dados[0]), dados[1]);
                    MinhaListaCliente.InserirCliente(novoCliente);

                    linha = arqDados.ReadLine();
                }
                //tempo.Stop();
                MessageBox.Show("Arquivo Carregado!" + "em: " + tempo.Elapsed.Seconds + " Segundos");
                arqDados.Close();

            }

            catch (FormatException ex)
            {
                MessageBox.Show("Arquivo corrompido");
            }

        }
    }
}
