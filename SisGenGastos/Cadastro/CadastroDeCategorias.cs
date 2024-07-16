using SisGenGastosControl;
using SisGenGastosModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisGenGastos.Cadastro
{
    public partial class CadastroDeCategorias : Form
    {
        public CadastroDeCategorias()
        {
            InitializeComponent();
        }

        private void TxtNovaCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CategoriasCtl ctlCat = new CategoriasCtl();
            bool devoProseguir = ctlCat.AutenticarNome(TxtNovaCategoria.Text);
            if(devoProseguir)
            {
                CategoriasMdl mdlCat = new CategoriasMdl();
                bool foiCadastrado = mdlCat.CadastrarNovaCategoria(ctlCat);
                if(foiCadastrado)
                {
                    MessageBox.Show("Uma nova categoria foi cadastrada.", "OPERAÇÃO CONCLUÍDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNovaCategoria.Focus();
                    TxtNovaCategoria.SelectAll();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar uma nova categoria.", "FALHA NA OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNovaCategoria.Focus();
                    TxtNovaCategoria.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome corretamente.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNovaCategoria.Focus();
                TxtNovaCategoria.SelectAll();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
