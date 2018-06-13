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
using System.Diagnostics;

namespace Biblioteca.Forms
{
    public partial class Form1 : Form
    {
        Livro[] vetLivros;
        Usuario[] vetUsuarios;
        Livro newLivro;
        Usuario newUsuario;
        Operacao newEmprestimo;
        Operacao[] vetOperacoes;

        public Form1()
        {
            InitializeComponent();

            this.CarregarUsuarios("../../arquivos/usuarios.txt");
            this.CarregarLivros("../../arquivos/livros.txt");
            this.CarregarOperacoes("../../arquivos/emprestimos.txt");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

                Stopwatch tempo = new Stopwatch();
                tempo.Start();

                this.CarregarUsuarios(openFileDialog1.FileName);

                tempo.Stop();

                MessageBox.Show("Arquivo Carregado !\n" + tempo.Elapsed.Seconds + " Segundos");
                MessageBox.Show("Vetor ordenado");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, tente novamente");
            }
        }

        private void CarregarUsuarios(string filename)
        {
            TextReader Leitor = new StreamReader(filename, true);//Inicializa o Leitor
            int tamanhoVet = 0;

            while (Leitor.Peek() != -1)
            {
                //Enquanto o arquivo não acabar, o Peek não retorna -1 sendo adequando para o loop while...
                tamanhoVet++;//Incrementa 1 na contagem
                Leitor.ReadLine();//Avança uma linha no arquivo
            }

            Leitor.Close(); //Fecha o Leitor, dando acesso ao arquivo para outros programas....         

            StreamReader arqDados = new StreamReader(filename);
            string linha;
            string[] dados;
            linha = arqDados.ReadLine();
            vetUsuarios = new Usuario[tamanhoVet];
            int pos = 0;
            while (linha != null)
            {
                dados = linha.Split(';');

                newUsuario = new Usuario(int.Parse(dados[0]), dados[1]);
                vetUsuarios[pos] = newUsuario;

                linha = arqDados.ReadLine();
                pos += 1;
            }

            arqDados.Close();

            OrdenaUsuario.QuickSort(vetUsuarios);
        }

        private void BtnCarregarLivros_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.ShowDialog();

                Stopwatch tempo = new Stopwatch();
                tempo.Start();

                this.CarregarLivros(openFileDialog2.FileName);

                tempo.Stop();

                MessageBox.Show("Arquivo Carregado !\n" + tempo.Elapsed.Seconds + " Segundos");
                MessageBox.Show("Vetor ordenado");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, tente novamente");
            }

        }

        private void CarregarLivros(string filename)
        {
            TextReader Leitor = new StreamReader(filename, true);//Inicializa o Leitor
            int tamanhoVet = 0;

            while (Leitor.Peek() != -1)
            {
                //Enquanto o arquivo não acabar, o Peek não retorna -1 sendo adequando para o loop while...
                tamanhoVet++;//Incrementa 1 na contagem
                Leitor.ReadLine();//Avança uma linha no arquivo
            }
            Leitor.Close(); //Fecha o Leitor, dando acesso ao arquivo para outros programas....         

            StreamReader arqDados = new StreamReader(filename);
            string linha;
            string[] dados;
            linha = arqDados.ReadLine();
            vetLivros = new Livro[tamanhoVet];
            int pos = 0;
            while (linha != null)
            {
                dados = linha.Split(';');
                newLivro = new Livro(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), float.Parse(dados[3]));
                vetLivros[pos] = newLivro;

                linha = arqDados.ReadLine();
                pos += 1;
            }
            arqDados.Close();
            OrdenaLivro.QuickSort(vetLivros);
        }

        private void BtnCarregarEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog3.ShowDialog();

                Stopwatch tempo = new Stopwatch();
                tempo.Start();

                this.CarregarOperacoes(openFileDialog3.FileName);

                tempo.Stop();

                MessageBox.Show("Arquivo Carregado !\n" + tempo.Elapsed.Seconds + " Segundos");
                //OrdenaLivro.quickSort(vetLivros);
                //MessageBox.Show("Vetor ordenado");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, tente novamente");
            }
        }

        private void CarregarOperacoes(string filename)
        {
            TextReader Leitor = new StreamReader(filename, true);//Inicializa o Leitor
            int tamanhoVet = 0;

            while (Leitor.Peek() != -1)
            {
                //Enquanto o arquivo não acabar, o Peek não retorna -1 sendo adequando para o loop while...
                tamanhoVet++;//Incrementa 1 na contagem
                Leitor.ReadLine();//Avança uma linha no arquivo
            }

            Leitor.Close(); //Fecha o Leitor, dando acesso ao arquivo para outros programas....         

            StreamReader arqDados = new StreamReader(filename);
            string linha;
            string[] dados;
            linha = arqDados.ReadLine();
            vetOperacoes = new Operacao[tamanhoVet];
            int pos = 0;

            while (linha != null)
            {
                dados = linha.Split(';');


                //Aqui o newUsuario pega o usuário sendo pesquisado por código lá no vetor dele passado por REF
                newUsuario = PesquisaObjeto.PesquisaUsuario(int.Parse(dados[0]), vetUsuarios);

                //Aqui o newLivro pega o Livro sendo pesquisado por código lá no vetor dele passado por REF
                newLivro = PesquisaObjeto.PesquisaLivro(int.Parse(dados[1]), vetLivros);

                //int codigo, string nome, int tipo, float preco_por_pagina
                //O emprestimo é criado utilizando a referencia do livro pesquisado.... então o que acontece...
                //não preciso criar um "novo" livro ou usuario... e sim referenciar onde eles estão na memoria
                newEmprestimo = new Operacao(ref newLivro, ref newUsuario, int.Parse(dados[2]), DateTime.Parse(dados[3]));

                if (newEmprestimo.Tipo == 1)
                {
                    newLivro.QuantidadeEmprestimo++;
                    newUsuario.QuantidadeEmprestimo++;
                }

                vetOperacoes[pos] = newEmprestimo;
                linha = arqDados.ReadLine();
                pos += 1;
            }
            arqDados.Close();
        }

        private void EmprestimosPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEmprestimosUsuario(vetOperacoes).ShowDialog();
        }

        private void LivrosMaisEmprestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLivrosMaisEmprestados(this.vetOperacoes, this.vetLivros).ShowDialog();
        }

        private void SituacaoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSituacaoUsuario(this.vetOperacoes).ShowDialog();
        }

        private void UsuariosComMaisEmprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUsuariosComMaisEmprestimos(this.vetOperacoes, this.vetUsuarios).ShowDialog();
        }
    }
}
