using SisGenGastosControl;
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
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                if(e.KeyChar == 8)
                {}
                else
                {
                    if(TxtDiaDeVencimento.Text.Length == 1) 
                    {
                        string digitoUm = TxtDiaDeVencimento.Text;
                        string digitoDois = e.KeyChar.ToString();
                        string numero = digitoUm + digitoDois;
                        int num = int.Parse(numero);
                        if (!(num > 0 && num <= 31))
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CartaoDeCreditoCtl carCredCtl = new CartaoDeCreditoCtl();
            bool[] devoProsseguir = new bool[2];
            devoProsseguir[0] = carCredCtl.AutenticarNome(TxtNomeDoCartaoDeCredito.Text);
            devoProsseguir[1] = carCredCtl.AutenticarDataVencimento(TxtDiaDeVencimento.Text);
            string[] msgErro = new string[2];
            msgErro[0] = "Preencha o nome corretamente";
            msgErro[1] = "Entre com uma data válida";

            for (int i = 0; i <  devoProsseguir.Length; i++)
            {
                if (!devoProsseguir[i])
                {
                    MessageBox.Show(msgErro[i], "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
    }
}
