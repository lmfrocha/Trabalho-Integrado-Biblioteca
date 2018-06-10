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

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        Livro[] vetLivros;
        Usuario[] vetUsuarios;
        Livro newLivro;
        Usuario newUsuario;
        Emprestimo newEmprestimo;
        Emprestimo [] vetEmprestimo;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.ShowDialog();
                Stopwatch tempo = new Stopwatch();
                tempo.Start();
                string filename = openFileDialog1.FileName;
                TextReader Leitor = new StreamReader(filename, true);//Inicializa o Leitor
                int tamanhoVet = 0;

                while (Leitor.Peek() != -1)
                {
                    //Enquanto o arquivo não acabar, o Peek não retorna -1 sendo adequando para o loop while...
                    tamanhoVet++;//Incrementa 1 na contagem
                    Leitor.ReadLine();//Avança uma linha no arquivo
                }
                Leitor.Close(); //Fecha o Leitor, dando acesso ao arquivo para outros programas....         

                string nomeArq = openFileDialog1.FileName;
                if (!File.Exists(nomeArq)) ;
                StreamReader arqDados = new StreamReader(nomeArq);
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
                tempo.Stop();
                MessageBox.Show("Arquivo Carregado !\n" + tempo.Elapsed.Seconds + " Segundos");
                arqDados.Close();
                OrdenaUsuario.quickSort(vetUsuarios);
                MessageBox.Show("Vetor ordenado");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, tente novamente");                
            }

            //if (PesquisaObjeto.PesquisaUsuario(5212, vetUsuarios))
            //{
            //    MessageBox.Show("Achou");
            //}
            //else MessageBox.Show("Erro, tente novamente");
        }

        private void btnCarregarLivros_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog2.ShowDialog();
                Stopwatch tempo = new Stopwatch();
                tempo.Start();
                string filename = openFileDialog2.FileName;
                TextReader Leitor = new StreamReader(filename, true);//Inicializa o Leitor
                int tamanhoVet = 0;

                while (Leitor.Peek() != -1)
                {
                    //Enquanto o arquivo não acabar, o Peek não retorna -1 sendo adequando para o loop while...
                    tamanhoVet++;//Incrementa 1 na contagem
                    Leitor.ReadLine();//Avança uma linha no arquivo
                }

                Leitor.Close(); //Fecha o Leitor, dando acesso ao arquivo para outros programas....         

                string nomeArq = openFileDialog2.FileName;
                if (!File.Exists(nomeArq)) ;
                StreamReader arqDados = new StreamReader(nomeArq);
                string linha;
                string[] dados;
                linha = arqDados.ReadLine();
                vetEmprestimo = new Emprestimo[tamanhoVet];
                int pos = 0;

                while (linha != null)
                {
                    dados = linha.Split(';');
                    //int codigo, string nome, int tipo, float preco_por_pagina
                    newLivro = new Livro(int.Parse(dados[0]), dados[1], int.Parse(dados[2]), float.Parse(dados[3]));
                    vetLivros[pos] = newLivro;
                    linha = arqDados.ReadLine();
                    pos += 1;
                }
                tempo.Stop();
                MessageBox.Show("Arquivo Carregado !\n" + tempo.Elapsed.Seconds + " Segundos");
                arqDados.Close();
                OrdenaLivro.quickSort(vetLivros);
                MessageBox.Show("Vetor ordenado");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, tente novamente");
            }

        }

        private void btnCarregarEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog3.ShowDialog();
                Stopwatch tempo = new Stopwatch();
                tempo.Start();
                string filename = openFileDialog3.FileName;
                TextReader Leitor = new StreamReader(filename, true);//Inicializa o Leitor
                int tamanhoVet = 0;

                while (Leitor.Peek() != -1)
                {
                    //Enquanto o arquivo não acabar, o Peek não retorna -1 sendo adequando para o loop while...
                    tamanhoVet++;//Incrementa 1 na contagem
                    Leitor.ReadLine();//Avança uma linha no arquivo
                }

                Leitor.Close(); //Fecha o Leitor, dando acesso ao arquivo para outros programas....         

                string nomeArq = openFileDialog3.FileName;
                if (!File.Exists(nomeArq)) ;
                StreamReader arqDados = new StreamReader(nomeArq);
                string linha;
                string[] dados;
                linha = arqDados.ReadLine();
                vetEmprestimo = new Emprestimo[tamanhoVet];
                int pos = 0;

                while (linha != null)
                {
                    dados = linha.Split(';');

                    newUsuario = PesquisaObjeto.PesquisaUsuario(int.Parse(dados[0]), vetUsuarios);
                    newLivro = PesquisaObjeto.PesquisaLivro(int.Parse(dados[1]), vetLivros);

                    //int codigo, string nome, int tipo, float preco_por_pagina
                    newEmprestimo = new Emprestimo(ref newLivro,ref newUsuario,int.Parse(dados[2]),DateTime.Parse(dados[3]));
                    vetEmprestimo[pos] = newEmprestimo;
                    linha = arqDados.ReadLine();
                    pos += 1;
                }
                tempo.Stop();
                //MessageBox.Show("Arquivo Carregado !\n" + tempo.Elapsed.Seconds + " Segundos");
                arqDados.Close();
                //OrdenaLivro.quickSort(vetLivros);
                //MessageBox.Show("Vetor ordenado");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, tente novamente");
            }

        }
    }
}
