namespace Biblioteca.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCarregaUsuario = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCarregarLivros = new System.Windows.Forms.Button();
            this.btnCarregarEmprestimo = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimosPorUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosMaisEmprestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaçãoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosComMaisEmpréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregaUsuario
            // 
            this.btnCarregaUsuario.Location = new System.Drawing.Point(342, 21);
            this.btnCarregaUsuario.Name = "btnCarregaUsuario";
            this.btnCarregaUsuario.Size = new System.Drawing.Size(82, 39);
            this.btnCarregaUsuario.TabIndex = 1;
            this.btnCarregaUsuario.Text = "Carregar Usuarios";
            this.btnCarregaUsuario.UseVisualStyleBackColor = true;
            this.btnCarregaUsuario.Click += new System.EventHandler(this.Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Tag = "Nome do Arquivo";
            // 
            // btnCarregarLivros
            // 
            this.btnCarregarLivros.Location = new System.Drawing.Point(342, 66);
            this.btnCarregarLivros.Name = "btnCarregarLivros";
            this.btnCarregarLivros.Size = new System.Drawing.Size(82, 39);
            this.btnCarregarLivros.TabIndex = 2;
            this.btnCarregarLivros.Text = "Carregar Livros";
            this.btnCarregarLivros.UseVisualStyleBackColor = true;
            this.btnCarregarLivros.Click += new System.EventHandler(this.BtnCarregarLivros_Click);
            // 
            // btnCarregarEmprestimo
            // 
            this.btnCarregarEmprestimo.Location = new System.Drawing.Point(342, 111);
            this.btnCarregarEmprestimo.Name = "btnCarregarEmprestimo";
            this.btnCarregarEmprestimo.Size = new System.Drawing.Size(82, 39);
            this.btnCarregarEmprestimo.TabIndex = 3;
            this.btnCarregarEmprestimo.Text = "Carregar Emprestimos";
            this.btnCarregarEmprestimo.UseVisualStyleBackColor = true;
            this.btnCarregarEmprestimo.Click += new System.EventHandler(this.BtnCarregarEmprestimo_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Tag = "Nome do Arquivo";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Tag = "Nome do Arquivo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empréstimosPorUsuárioToolStripMenuItem,
            this.livrosMaisEmprestadosToolStripMenuItem,
            this.situaçãoUsuárioToolStripMenuItem,
            this.usuáriosComMaisEmpréstimosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // empréstimosPorUsuárioToolStripMenuItem
            // 
            this.empréstimosPorUsuárioToolStripMenuItem.Name = "empréstimosPorUsuárioToolStripMenuItem";
            this.empréstimosPorUsuárioToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.empréstimosPorUsuárioToolStripMenuItem.Text = "Empréstimos por usuário";
            this.empréstimosPorUsuárioToolStripMenuItem.Click += new System.EventHandler(this.EmprestimosPorUsuarioToolStripMenuItem_Click);
            // 
            // livrosMaisEmprestadosToolStripMenuItem
            // 
            this.livrosMaisEmprestadosToolStripMenuItem.Name = "livrosMaisEmprestadosToolStripMenuItem";
            this.livrosMaisEmprestadosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.livrosMaisEmprestadosToolStripMenuItem.Text = "Livros mais emprestados";
            this.livrosMaisEmprestadosToolStripMenuItem.Click += new System.EventHandler(this.LivrosMaisEmprestadosToolStripMenuItem_Click);
            // 
            // situaçãoUsuárioToolStripMenuItem
            // 
            this.situaçãoUsuárioToolStripMenuItem.Name = "situaçãoUsuárioToolStripMenuItem";
            this.situaçãoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.situaçãoUsuárioToolStripMenuItem.Text = "Situação usuário";
            this.situaçãoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.SituacaoUsuarioToolStripMenuItem_Click);
            // 
            // usuáriosComMaisEmpréstimosToolStripMenuItem
            // 
            this.usuáriosComMaisEmpréstimosToolStripMenuItem.Name = "usuáriosComMaisEmpréstimosToolStripMenuItem";
            this.usuáriosComMaisEmpréstimosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.usuáriosComMaisEmpréstimosToolStripMenuItem.Text = "Usuários com mais empréstimos";
            this.usuáriosComMaisEmpréstimosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosComMaisEmprestimosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 179);
            this.Controls.Add(this.btnCarregarEmprestimo);
            this.Controls.Add(this.btnCarregarLivros);
            this.Controls.Add(this.btnCarregaUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AED - Biblioteca - Daniel - Leandro - Ludmila - Lucas - Victor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCarregaUsuario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCarregarLivros;
        private System.Windows.Forms.Button btnCarregarEmprestimo;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empréstimosPorUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosMaisEmprestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaçãoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosComMaisEmpréstimosToolStripMenuItem;
    }
}

