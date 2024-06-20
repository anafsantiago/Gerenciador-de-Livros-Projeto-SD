namespace GerenciamentoDeLivros
{
    partial class PaginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicioPesquisar = new System.Windows.Forms.Button();
            this.bntInicioAdicionar = new System.Windows.Forms.Button();
            this.btnInicioExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma opção";
            // 
            // btnInicioPesquisar
            // 
            this.btnInicioPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioPesquisar.Location = new System.Drawing.Point(108, 347);
            this.btnInicioPesquisar.Name = "btnInicioPesquisar";
            this.btnInicioPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btnInicioPesquisar.TabIndex = 1;
            this.btnInicioPesquisar.Text = "PESQUISAR";
            this.btnInicioPesquisar.UseVisualStyleBackColor = true;
            this.btnInicioPesquisar.Click += new System.EventHandler(this.btnInicioPesquisar_Click);
            // 
            // bntInicioAdicionar
            // 
            this.bntInicioAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInicioAdicionar.Location = new System.Drawing.Point(295, 347);
            this.bntInicioAdicionar.Name = "bntInicioAdicionar";
            this.bntInicioAdicionar.Size = new System.Drawing.Size(100, 36);
            this.bntInicioAdicionar.TabIndex = 2;
            this.bntInicioAdicionar.Text = "ADICIONAR";
            this.bntInicioAdicionar.UseVisualStyleBackColor = true;
            this.bntInicioAdicionar.Click += new System.EventHandler(this.bntInicioAdicionar_Click);
            // 
            // btnInicioExcluir
            // 
            this.btnInicioExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioExcluir.Location = new System.Drawing.Point(482, 347);
            this.btnInicioExcluir.Name = "btnInicioExcluir";
            this.btnInicioExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnInicioExcluir.TabIndex = 3;
            this.btnInicioExcluir.Text = "EXCLUIR";
            this.btnInicioExcluir.UseVisualStyleBackColor = true;
            this.btnInicioExcluir.Click += new System.EventHandler(this.btnInicioExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciamentoDeLivros.Properties.Resources.education_books_library_icon_149685__2_;
            this.pictureBox1.InitialImage = global::GerenciamentoDeLivros.Properties.Resources.education_books_library_icon_149685;
            this.pictureBox1.Location = new System.Drawing.Point(281, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInicioExcluir);
            this.Controls.Add(this.bntInicioAdicionar);
            this.Controls.Add(this.btnInicioPesquisar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Livros - Início";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicioPesquisar;
        private System.Windows.Forms.Button bntInicioAdicionar;
        private System.Windows.Forms.Button btnInicioExcluir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

