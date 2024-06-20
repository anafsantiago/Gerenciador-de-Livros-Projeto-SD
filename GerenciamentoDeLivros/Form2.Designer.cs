namespace GerenciamentoDeLivros
{
    partial class PaginaAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaAdicionar));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncluirAdicionar = new System.Windows.Forms.Button();
            this.txtAdicionar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o código ISBN";
            // 
            // btnIncluirAdicionar
            // 
            this.btnIncluirAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirAdicionar.Location = new System.Drawing.Point(283, 247);
            this.btnIncluirAdicionar.Name = "btnIncluirAdicionar";
            this.btnIncluirAdicionar.Size = new System.Drawing.Size(100, 36);
            this.btnIncluirAdicionar.TabIndex = 1;
            this.btnIncluirAdicionar.Text = "ADICIONAR";
            this.btnIncluirAdicionar.UseVisualStyleBackColor = true;
            this.btnIncluirAdicionar.Click += new System.EventHandler(this.btnIncluirAdicionar_Click);
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Location = new System.Drawing.Point(159, 164);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(349, 20);
            this.txtAdicionar.TabIndex = 2;
            // 
            // PaginaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 390);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.btnIncluirAdicionar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciador de Livros - Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncluirAdicionar;
        private System.Windows.Forms.TextBox txtAdicionar;
    }
}