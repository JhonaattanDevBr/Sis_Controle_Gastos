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
    public partial class CadastroDeCartoesDeCredito : Form
    {
        public CadastroDeCartoesDeCredito()
        {
            InitializeComponent();
        }

        private void TxtNomeDoCartaoDeCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtDiaDeVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8) // Estou tentando implementar uma logica para verificar se o valor é maior que 31 e maior que 0, mas ainda não funcionoo.
            {
                e.Handled = true;
                
            }
            else
            {
                char asciiNum = e.KeyChar;
                int num = Convert.ToInt16(asciiNum);

                if (!(num >= 0 && num <= 31))
                {
                    TxtDiaDeVencimento.Clear();
                }
            }
        }
    }
}
