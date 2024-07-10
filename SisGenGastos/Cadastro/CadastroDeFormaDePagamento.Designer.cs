namespace SisGenGastos.Cadastro
{
    partial class CadastroDeFormaDePagamento
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
            this.LblNomeDaFormaDePagamento = new System.Windows.Forms.Label();
            this.TxtNomeDaFormaDePagamento = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNomeDaFormaDePagamento
            // 
            this.LblNomeDaFormaDePagamento.AutoSize = true;
            this.LblNomeDaFormaDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblNomeDaFormaDePagamento.Location = new System.Drawing.Point(12, 13);
            this.LblNomeDaFormaDePagamento.Name = "LblNomeDaFormaDePagamento";
            this.LblNomeDaFormaDePagamento.Size = new System.Drawing.Size(310, 25);
            this.LblNomeDaFormaDePagamento.TabIndex = 0;
            this.LblNomeDaFormaDePagamento.Text = "Nome da Forma de Pagamento";
            // 
            // TxtNomeDaFormaDePagamento
            // 
            this.TxtNomeDaFormaDePagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeDaFormaDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.TxtNomeDaFormaDePagamento.Location = new System.Drawing.Point(17, 41);
            this.TxtNomeDaFormaDePagamento.Name = "TxtNomeDaFormaDePagamento";
            this.TxtNomeDaFormaDePagamento.Size = new System.Drawing.Size(335, 30);
            this.TxtNomeDaFormaDePagamento.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Pink;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Location = new System.Drawing.Point(17, 89);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Pink;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCadastrar.Location = new System.Drawing.Point(133, 89);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(110, 30);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            // 
            // CadastroDeFormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(364, 131);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtNomeDaFormaDePagamento);
            this.Controls.Add(this.LblNomeDaFormaDePagamento);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 170);
            this.Name = "CadastroDeFormaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMAS DE PAGAMENTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeDaFormaDePagamento;
        private System.Windows.Forms.TextBox TxtNomeDaFormaDePagamento;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}