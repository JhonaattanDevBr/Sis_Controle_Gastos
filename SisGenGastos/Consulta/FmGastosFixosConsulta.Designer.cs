namespace SisGenGastos
{
    partial class FmGastosFixosConsulta
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
            this.LblNomeDaTabela = new System.Windows.Forms.Label();
            this.DgvTabelaDeGastos = new System.Windows.Forms.DataGridView();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnCadastrarNovoGastoFixo = new System.Windows.Forms.Button();
            this.BtnAtualizarStatus = new System.Windows.Forms.Button();
            this.BtnExcluirRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabelaDeGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomeDaTabela
            // 
            this.LblNomeDaTabela.AutoSize = true;
            this.LblNomeDaTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblNomeDaTabela.Location = new System.Drawing.Point(7, 15);
            this.LblNomeDaTabela.Name = "LblNomeDaTabela";
            this.LblNomeDaTabela.Size = new System.Drawing.Size(186, 25);
            this.LblNomeDaTabela.TabIndex = 0;
            this.LblNomeDaTabela.Text = "Meu Gastos Fixos";
            // 
            // DgvTabelaDeGastos
            // 
            this.DgvTabelaDeGastos.AllowUserToAddRows = false;
            this.DgvTabelaDeGastos.AllowUserToDeleteRows = false;
            this.DgvTabelaDeGastos.BackgroundColor = System.Drawing.Color.Pink;
            this.DgvTabelaDeGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabelaDeGastos.Location = new System.Drawing.Point(12, 43);
            this.DgvTabelaDeGastos.Name = "DgvTabelaDeGastos";
            this.DgvTabelaDeGastos.ReadOnly = true;
            this.DgvTabelaDeGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTabelaDeGastos.Size = new System.Drawing.Size(860, 375);
            this.DgvTabelaDeGastos.TabIndex = 1;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Pink;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnVoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnVoltar.Location = new System.Drawing.Point(12, 439);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(100, 30);
            this.BtnVoltar.TabIndex = 2;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnCadastrarNovoGastoFixo
            // 
            this.BtnCadastrarNovoGastoFixo.BackColor = System.Drawing.Color.Pink;
            this.BtnCadastrarNovoGastoFixo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrarNovoGastoFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCadastrarNovoGastoFixo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCadastrarNovoGastoFixo.Location = new System.Drawing.Point(118, 439);
            this.BtnCadastrarNovoGastoFixo.Name = "BtnCadastrarNovoGastoFixo";
            this.BtnCadastrarNovoGastoFixo.Size = new System.Drawing.Size(180, 30);
            this.BtnCadastrarNovoGastoFixo.TabIndex = 3;
            this.BtnCadastrarNovoGastoFixo.Text = "Novo Gasto Fixo";
            this.BtnCadastrarNovoGastoFixo.UseVisualStyleBackColor = false;
            this.BtnCadastrarNovoGastoFixo.Click += new System.EventHandler(this.BtnCadastrarNovoGastoFixo_Click);
            // 
            // BtnAtualizarStatus
            // 
            this.BtnAtualizarStatus.BackColor = System.Drawing.Color.Pink;
            this.BtnAtualizarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtualizarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnAtualizarStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAtualizarStatus.Location = new System.Drawing.Point(304, 439);
            this.BtnAtualizarStatus.Name = "BtnAtualizarStatus";
            this.BtnAtualizarStatus.Size = new System.Drawing.Size(190, 30);
            this.BtnAtualizarStatus.TabIndex = 4;
            this.BtnAtualizarStatus.Text = "Atualizar Status";
            this.BtnAtualizarStatus.UseVisualStyleBackColor = false;
            this.BtnAtualizarStatus.Click += new System.EventHandler(this.BtnAtualizarStatus_Click);
            // 
            // BtnExcluirRegistro
            // 
            this.BtnExcluirRegistro.BackColor = System.Drawing.Color.Pink;
            this.BtnExcluirRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluirRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnExcluirRegistro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExcluirRegistro.Location = new System.Drawing.Point(500, 439);
            this.BtnExcluirRegistro.Name = "BtnExcluirRegistro";
            this.BtnExcluirRegistro.Size = new System.Drawing.Size(100, 30);
            this.BtnExcluirRegistro.TabIndex = 5;
            this.BtnExcluirRegistro.Text = "Excluir Registro";
            this.BtnExcluirRegistro.UseVisualStyleBackColor = false;
            this.BtnExcluirRegistro.Click += new System.EventHandler(this.BtnExcluirRegistro_Click);
            // 
            // FmGastosFixosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.BtnExcluirRegistro);
            this.Controls.Add(this.BtnAtualizarStatus);
            this.Controls.Add(this.BtnCadastrarNovoGastoFixo);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.DgvTabelaDeGastos);
            this.Controls.Add(this.LblNomeDaTabela);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 520);
            this.Name = "FmGastosFixosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERENCIADOR DE GASTOS - GASTOS FIXOS";
            this.Load += new System.EventHandler(this.FmGastosFixosConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabelaDeGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeDaTabela;
        private System.Windows.Forms.DataGridView DgvTabelaDeGastos;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnCadastrarNovoGastoFixo;
        private System.Windows.Forms.Button BtnAtualizarStatus;
        private System.Windows.Forms.Button BtnExcluirRegistro;
    }
}