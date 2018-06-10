namespace Biblioteca
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
            this.SuspendLayout();
            // 
            // btnCarregaUsuario
            // 
            this.btnCarregaUsuario.Location = new System.Drawing.Point(662, 185);
            this.btnCarregaUsuario.Name = "btnCarregaUsuario";
            this.btnCarregaUsuario.Size = new System.Drawing.Size(82, 39);
            this.btnCarregaUsuario.TabIndex = 1;
            this.btnCarregaUsuario.Text = "Carregar Usuarios";
            this.btnCarregaUsuario.UseVisualStyleBackColor = true;
            this.btnCarregaUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Tag = "Nome do Arquivo";
            // 
            // btnCarregarLivros
            // 
            this.btnCarregarLivros.Location = new System.Drawing.Point(662, 230);
            this.btnCarregarLivros.Name = "btnCarregarLivros";
            this.btnCarregarLivros.Size = new System.Drawing.Size(82, 39);
            this.btnCarregarLivros.TabIndex = 2;
            this.btnCarregarLivros.Text = "Carregar Livros";
            this.btnCarregarLivros.UseVisualStyleBackColor = true;
            this.btnCarregarLivros.Click += new System.EventHandler(this.btnCarregarLivros_Click);
            // 
            // btnCarregarEmprestimo
            // 
            this.btnCarregarEmprestimo.Location = new System.Drawing.Point(662, 275);
            this.btnCarregarEmprestimo.Name = "btnCarregarEmprestimo";
            this.btnCarregarEmprestimo.Size = new System.Drawing.Size(82, 39);
            this.btnCarregarEmprestimo.TabIndex = 3;
            this.btnCarregarEmprestimo.Text = "Carregar Emprestimos";
            this.btnCarregarEmprestimo.UseVisualStyleBackColor = true;
            this.btnCarregarEmprestimo.Click += new System.EventHandler(this.btnCarregarEmprestimo_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Tag = "Nome do Arquivo";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Tag = "Nome do Arquivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarregarEmprestimo);
            this.Controls.Add(this.btnCarregarLivros);
            this.Controls.Add(this.btnCarregaUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AED - Biblioteca - Daniel - Leandro - Lucas - Victor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCarregaUsuario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCarregarLivros;
        private System.Windows.Forms.Button btnCarregarEmprestimo;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}

