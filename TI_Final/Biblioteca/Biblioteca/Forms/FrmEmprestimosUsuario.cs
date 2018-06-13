using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FrmEmprestimosUsuario : Form
    {
        private Operacao[] vetOperacoes;

        public FrmEmprestimosUsuario(Operacao[] vetOperacoes)
        {
            InitializeComponent();
            this.vetOperacoes = vetOperacoes;
        }

        private void BtnPesquisar_Click(object sender, System.EventArgs e)
        {
            var codigoUsuario = int.Parse(txtCodigo.Text);

            ListViewItem item = null;

            foreach (var operacao in vetOperacoes)
            {
                if (operacao.Usuario.Codigo != codigoUsuario)
                    continue;

                this.txtUsuario.Text = operacao.Usuario.Nome;

                if (item == null)
                {
                    if (operacao.Tipo == 1)
                    {
                        item = new ListViewItem(operacao.Livro.Nome);
                        item.SubItems.Add(operacao.Data.ToShortDateString());
                    }
                }
                else
                {
                    if (operacao.Tipo == 2)
                    {
                        item.SubItems.Add(operacao.Data.ToShortDateString());
                        lstEmprestimos.Items.Add(item);
                        item = null;
                    }
                    else
                    {
                        lstEmprestimos.Items.Add(item);
                        item = new ListViewItem(operacao.Livro.Nome);
                        item.SubItems.Add(operacao.Data.ToShortDateString());
                    }
                }
            }
        }
    }
}
