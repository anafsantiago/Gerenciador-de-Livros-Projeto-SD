namespace GerenciamentoDeLivros
{
    partial class PaginaPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPesquisa));
            this.txtPesquisarIsbn = new System.Windows.Forms.TextBox();
            this.txtPesquisarTitulo = new System.Windows.Forms.TextBox();
            this.txtPesquisarAutor = new System.Windows.Forms.TextBox();
            this.boxPesquisarResultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPesquisarIsbn
            // 
            this.txtPesquisarIsbn.Location = new System.Drawing.Point(249, 132);
            this.txtPesquisarIsbn.Name = "txtPesquisarIsbn";
            this.txtPesquisarIsbn.Size = new System.Drawing.Size(213, 20);
            this.txtPesquisarIsbn.TabIndex = 0;
            this.txtPesquisarIsbn.TextChanged += new System.EventHandler(this.txtPesquisarIsbn_TextChanged);
            // 
            // txtPesquisarTitulo
            // 
            this.txtPesquisarTitulo.Location = new System.Drawing.Point(249, 186);
            this.txtPesquisarTitulo.Name = "txtPesquisarTitulo";
            this.txtPesquisarTitulo.Size = new System.Drawing.Size(213, 20);
            this.txtPesquisarTitulo.TabIndex = 1;
            this.txtPesquisarTitulo.TextChanged += new System.EventHandler(this.txtPesquisarTitulo_TextChanged);
            // 
            // txtPesquisarAutor
            // 
            this.txtPesquisarAutor.Location = new System.Drawing.Point(249, 241);
            this.txtPesquisarAutor.Name = "txtPesquisarAutor";
            this.txtPesquisarAutor.Size = new System.Drawing.Size(213, 20);
            this.txtPesquisarAutor.TabIndex = 2;
            this.txtPesquisarAutor.TextChanged += new System.EventHandler(this.txtPesquisarAutor_TextChanged);
            // 
            // boxPesquisarResultado
            // 
            this.boxPesquisarResultado.Location = new System.Drawing.Point(122, 370);
            this.boxPesquisarResultado.Name = "boxPesquisarResultado";
            this.boxPesquisarResultado.Size = new System.Drawing.Size(414, 148);
            this.boxPesquisarResultado.TabIndex = 3;
            this.boxPesquisarResultado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor:";
            // 
            // btnBuscarPesquisar
            // 
            this.btnBuscarPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPesquisar.Location = new System.Drawing.Point(286, 303);
            this.btnBuscarPesquisar.Name = "btnBuscarPesquisar";
            this.btnBuscarPesquisar.Size = new System.Drawing.Size(87, 32);
            this.btnBuscarPesquisar.TabIndex = 7;
            this.btnBuscarPesquisar.Text = "PESQUISAR";
            this.btnBuscarPesquisar.UseVisualStyleBackColor = true;
            this.btnBuscarPesquisar.Click += new System.EventHandler(this.btnBuscarPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Informe um campo para pesquisa";
            // 
            // PaginaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 576);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPesquisarResultado);
            this.Controls.Add(this.txtPesquisarAutor);
            this.Controls.Add(this.txtPesquisarTitulo);
            this.Controls.Add(this.txtPesquisarIsbn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciador de Livros - Pesquisar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisarIsbn;
        private System.Windows.Forms.TextBox txtPesquisarTitulo;
        private System.Windows.Forms.TextBox txtPesquisarAutor;
        private System.Windows.Forms.RichTextBox boxPesquisarResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPesquisar;
        private System.Windows.Forms.Label label4;
    }
}