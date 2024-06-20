namespace GerenciamentoDeLivros
{
    partial class PaginaExcluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaExcluir));
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.btnDeletarExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(159, 189);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(349, 20);
            this.txtExcluir.TabIndex = 5;
            // 
            // btnDeletarExcluir
            // 
            this.btnDeletarExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarExcluir.Location = new System.Drawing.Point(283, 268);
            this.btnDeletarExcluir.Name = "btnDeletarExcluir";
            this.btnDeletarExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnDeletarExcluir.TabIndex = 4;
            this.btnDeletarExcluir.Text = "EXCLUIR";
            this.btnDeletarExcluir.UseVisualStyleBackColor = true;
            this.btnDeletarExcluir.Click += new System.EventHandler(this.btnDeletarExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe o código ISBN";
            // 
            // PaginaExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 401);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnDeletarExcluir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciador de Livros - Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Button btnDeletarExcluir;
        private System.Windows.Forms.Label label1;
    }
}