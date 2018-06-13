using System;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FrmSituacaoUsuario : Form
    {
        private Operacao[] vetOperacoes;

        public FrmSituacaoUsuario(Operacao[] vetOperacoes)
        {
            InitializeComponent();
            this.vetOperacoes = vetOperacoes;

            this.lblSituacao.Text = "";
        }

        private void BtnConsultar_Click(object sender, System.EventArgs e)
        {
            var codigoUsuario = int.Parse(txtCodigo.Text);


            var emprestimos = new Emprestimo[vetOperacoes.Length];
            var i = 0;

            Emprestimo emprestimo = null;

            foreach (var operacao in vetOperacoes)
            {
                if (operacao.Usuario.Codigo != codigoUsuario)
                    continue;

                this.txtNome.Text = operacao.Usuario.Nome;

                if (emprestimo == null)
                {
                    if (operacao.Tipo == 1)
                    {
                        emprestimo = new Emprestimo(operacao.Livro, operacao.Usuario, operacao.Data);
                    }
                }
                else
                {
                    if (operacao.Tipo == 2)
                    {
                        emprestimo.DataDevolucao = operacao.Data;
                        emprestimos[i++] = emprestimo;
                        emprestimo = null;
                    }
                    else
                    {
                        emprestimos[i++] = new Emprestimo(operacao.Livro, operacao.Usuario, operacao.Data);
                        emprestimo = new Emprestimo(operacao.Livro, operacao.Usuario, operacao.Data);
                    }
                }
            }

            var ultimoEmprestimo = emprestimos[i - 1];

            this.lblSituacao.Text = "Regular";

            if (ultimoEmprestimo != null)
            {
                if ((ultimoEmprestimo.DataDevolucao == DateTime.MinValue && DateTime.Now.Subtract(ultimoEmprestimo.Data).TotalDays > 7) ||
                    (ultimoEmprestimo.DataDevolucao != DateTime.MinValue && ultimoEmprestimo.DataDevolucao.Subtract(ultimoEmprestimo.Data).TotalDays > 7))
                {
                    this.lblSituacao.Text = "Suspenso";
                }
            }
        }
    }
}
