using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FrmLivrosMaisEmprestados : Form
    {
        private Operacao[] vetOperacoes;
        private Livro[] vetLivros;

        public FrmLivrosMaisEmprestados(Operacao[] vetOperacoes, Livro[] vetLivros)
        {
            InitializeComponent();
            this.vetOperacoes = vetOperacoes;
            this.vetLivros = vetLivros;
        }

        private void FrmLivrosMaisEmprestados_Load(object sender, System.EventArgs e)
        { 
            var livrosOrdenados = OrdenaLivro.OrderPorQuantidade(vetLivros);

            foreach (var livro in livrosOrdenados)
            {
                var listItem = new ListViewItem(livro.Nome);
                listItem.SubItems.Add(livro.QuantidadeEmprestimo.ToString());

                lstLivros.Items.Add(listItem);
            }
        }
    }
}
