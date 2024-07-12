namespace SisGenGastos.Cadastro
{
    partial class CadastroDeCartoesDeCredito
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
            this.LblNomeDoCartaoDeCredito = new System.Windows.Forms.Label();
            this.LblDiaDeVencimento = new System.Windows.Forms.Label();
            this.TxtNomeDoCartaoDeCredito = new System.Windows.Forms.TextBox();
            this.TxtDiaDeVencimento = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNomeDoCartaoDeCredito
            // 
            this.LblNomeDoCartaoDeCredito.AutoSize = true;
            this.LblNomeDoCartaoDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblNomeDoCartaoDeCredito.Location = new System.Drawing.Point(12, 13);
            this.LblNomeDoCartaoDeCredito.Name = "LblNomeDoCartaoDeCredito";
            this.LblNomeDoCartaoDeCredito.Size = new System.Drawing.Size(281, 25);
            this.LblNomeDoCartaoDeCredito.TabIndex = 0;
            this.LblNomeDoCartaoDeCredito.Text = "Nome Do Cartao De Credito";
            // 
            // LblDiaDeVencimento
            // 
            this.LblDiaDeVencimento.AutoSize = true;
            this.LblDiaDeVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblDiaDeVencimento.Location = new System.Drawing.Point(12, 80);
            this.LblDiaDeVencimento.Name = "LblDiaDeVencimento";
            this.LblDiaDeVencimento.Size = new System.Drawing.Size(197, 25);
            this.LblDiaDeVencimento.TabIndex = 1;
            this.LblDiaDeVencimento.Text = "Dia De Vencimento";
            // 
            // TxtNomeDoCartaoDeCredito
            // 
            this.TxtNomeDoCartaoDeCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeDoCartaoDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtNomeDoCartaoDeCredito.Location = new System.Drawing.Point(17, 41);
            this.TxtNomeDoCartaoDeCredito.MaxLength = 20;
            this.TxtNomeDoCartaoDeCredito.Name = "TxtNomeDoCartaoDeCredito";
            this.TxtNomeDoCartaoDeCredito.Size = new System.Drawing.Size(335, 30);
            this.TxtNomeDoCartaoDeCredito.TabIndex = 2;
            this.TxtNomeDoCartaoDeCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeDoCartaoDeCredito_KeyPress);
            // 
            // TxtDiaDeVencimento
            // 
            this.TxtDiaDeVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtDiaDeVencimento.Location = new System.Drawing.Point(17, 108);
            this.TxtDiaDeVencimento.MaxLength = 2;
            this.TxtDiaDeVencimento.Name = "TxtDiaDeVencimento";
            this.TxtDiaDeVencimento.Size = new System.Drawing.Size(50, 30);
            this.TxtDiaDeVencimento.TabIndex = 3;
            this.TxtDiaDeVencimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDiaDeVencimento_KeyPress);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Pink;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Location = new System.Drawing.Point(17, 154);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 30);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Pink;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCadastrar.Location = new System.Drawing.Point(133, 153);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(110, 30);
            this.BtnCadastrar.TabIndex = 5;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // CadastroDeCartoesDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(364, 201);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtDiaDeVencimento);
            this.Controls.Add(this.TxtNomeDoCartaoDeCredito);
            this.Controls.Add(this.LblDiaDeVencimento);
            this.Controls.Add(this.LblNomeDoCartaoDeCredito);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 240);
            this.Name = "CadastroDeCartoesDeCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARTÕES DE CRÉDITO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeDoCartaoDeCredito;
        private System.Windows.Forms.Label LblDiaDeVencimento;
        private System.Windows.Forms.TextBox TxtNomeDoCartaoDeCredito;
        private System.Windows.Forms.TextBox TxtDiaDeVencimento;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}