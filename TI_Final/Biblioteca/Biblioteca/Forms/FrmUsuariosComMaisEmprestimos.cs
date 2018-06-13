using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FrmUsuariosComMaisEmprestimos : Form
    {
        private Operacao[] vetOperacoes;
        private Usuario[] vetUsuarios;

        public FrmUsuariosComMaisEmprestimos(Operacao[] vetOperacoes, Usuario[] vetUsuarios)
        {
            InitializeComponent();
            this.vetOperacoes = vetOperacoes;
            this.vetUsuarios = vetUsuarios;
        }

        private void FrmUsuariosComMaisEmprestimos_Load(object sender, System.EventArgs e)
        {
            var usuariosOrdenados = OrdenaUsuario.OrdernarPorQuantidade(vetUsuarios);

            foreach (var usuario in usuariosOrdenados)
            {
                var listItem = new ListViewItem(usuario.Codigo.ToString());
                listItem.SubItems.Add(usuario.Nome);
                listItem.SubItems.Add(usuario.QuantidadeEmprestimo.ToString());

                lstUsuarios.Items.Add(listItem);
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
