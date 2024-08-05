namespace SisGenGastos.Update
{
    partial class UpdateGastosFixos
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
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbStatusDoPagamento = new System.Windows.Forms.ComboBox();
            this.CmbFormaDePagamento = new System.Windows.Forms.ComboBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.DtpDataDoPagamento = new System.Windows.Forms.DateTimePicker();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.TxtNomeDoGasto = new System.Windows.Forms.TextBox();
            this.LblStatusPagamento = new System.Windows.Forms.Label();
            this.LblFormaDePagamento = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblDataDoPagamento = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Pink;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCadastrar.Location = new System.Drawing.Point(133, 410);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(110, 30);
            this.BtnCadastrar.TabIndex = 27;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Pink;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Location = new System.Drawing.Point(17, 410);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 30);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbStatusDoPagamento
            // 
            this.CmbStatusDoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatusDoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbStatusDoPagamento.FormattingEnabled = true;
            this.CmbStatusDoPagamento.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.CmbStatusDoPagamento.Location = new System.Drawing.Point(17, 357);
            this.CmbStatusDoPagamento.Name = "CmbStatusDoPagamento";
            this.CmbStatusDoPagamento.Size = new System.Drawing.Size(101, 33);
            this.CmbStatusDoPagamento.TabIndex = 25;
            // 
            // CmbFormaDePagamento
            // 
            this.CmbFormaDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormaDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbFormaDePagamento.FormattingEnabled = true;
            this.CmbFormaDePagamento.Location = new System.Drawing.Point(17, 230);
            this.CmbFormaDePagamento.Name = "CmbFormaDePagamento";
            this.CmbFormaDePagamento.Size = new System.Drawing.Size(330, 33);
            this.CmbFormaDePagamento.TabIndex = 24;
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtValor.Location = new System.Drawing.Point(17, 295);
            this.TxtValor.MaxLength = 20;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(216, 30);
            this.TxtValor.TabIndex = 23;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // DtpDataDoPagamento
            // 
            this.DtpDataDoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DtpDataDoPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataDoPagamento.Location = new System.Drawing.Point(17, 168);
            this.DtpDataDoPagamento.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.DtpDataDoPagamento.Name = "DtpDataDoPagamento";
            this.DtpDataDoPagamento.Size = new System.Drawing.Size(150, 30);
            this.DtpDataDoPagamento.TabIndex = 22;
            this.DtpDataDoPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpDataDoPagamento_KeyPress);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(17, 102);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(330, 33);
            this.CmbCategoria.TabIndex = 21;
            // 
            // TxtNomeDoGasto
            // 
            this.TxtNomeDoGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeDoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtNomeDoGasto.Location = new System.Drawing.Point(17, 40);
            this.TxtNomeDoGasto.MaxLength = 20;
            this.TxtNomeDoGasto.Name = "TxtNomeDoGasto";
            this.TxtNomeDoGasto.Size = new System.Drawing.Size(494, 30);
            this.TxtNomeDoGasto.TabIndex = 20;
            this.TxtNomeDoGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeDoGasto_KeyPress);
            // 
            // LblStatusPagamento
            // 
            this.LblStatusPagamento.AutoSize = true;
            this.LblStatusPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblStatusPagamento.Location = new System.Drawing.Point(12, 329);
            this.LblStatusPagamento.Name = "LblStatusPagamento";
            this.LblStatusPagamento.Size = new System.Drawing.Size(219, 25);
            this.LblStatusPagamento.TabIndex = 19;
            this.LblStatusPagamento.Text = "Status do Pagamento";
            // 
            // LblFormaDePagamento
            // 
            this.LblFormaDePagamento.AutoSize = true;
            this.LblFormaDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblFormaDePagamento.Location = new System.Drawing.Point(12, 202);
            this.LblFormaDePagamento.Name = "LblFormaDePagamento";
            this.LblFormaDePagamento.Size = new System.Drawing.Size(221, 25);
            this.LblFormaDePagamento.TabIndex = 18;
            this.LblFormaDePagamento.Text = "Forma De Pagamento";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblValor.Location = new System.Drawing.Point(12, 267);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(63, 25);
            this.LblValor.TabIndex = 17;
            this.LblValor.Text = "Valor";
            // 
            // LblDataDoPagamento
            // 
            this.LblDataDoPagamento.AutoSize = true;
            this.LblDataDoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblDataDoPagamento.Location = new System.Drawing.Point(12, 139);
            this.LblDataDoPagamento.Name = "LblDataDoPagamento";
            this.LblDataDoPagamento.Size = new System.Drawing.Size(205, 25);
            this.LblDataDoPagamento.TabIndex = 16;
            this.LblDataDoPagamento.Text = "Data Do Pagamento";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblCategoria.Location = new System.Drawing.Point(12, 74);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(106, 25);
            this.LblCategoria.TabIndex = 15;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblNome.Location = new System.Drawing.Point(12, 11);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(161, 25);
            this.LblNome.TabIndex = 14;
            this.LblNome.Text = "Nome do Gasto";
            // 
            // UpdateGastosFixos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(534, 451);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.CmbStatusDoPagamento);
            this.Controls.Add(this.CmbFormaDePagamento);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.DtpDataDoPagamento);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.TxtNomeDoGasto);
            this.Controls.Add(this.LblStatusPagamento);
            this.Controls.Add(this.LblFormaDePagamento);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblDataDoPagamento);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblNome);
            this.MaximizeBox = false;
            this.Name = "UpdateGastosFixos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATUALIZAR GASTO FIXO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CmbStatusDoPagamento;
        private System.Windows.Forms.ComboBox CmbFormaDePagamento;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.DateTimePicker DtpDataDoPagamento;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.TextBox TxtNomeDoGasto;
        private System.Windows.Forms.Label LblStatusPagamento;
        private System.Windows.Forms.Label LblFormaDePagamento;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblDataDoPagamento;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNome;
    }
}