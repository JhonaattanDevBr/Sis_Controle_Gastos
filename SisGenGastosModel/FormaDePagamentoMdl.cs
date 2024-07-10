using SisGenGastosControl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenGastosModel
{
    public class FormaDePagamentoMdl
    {
        public bool CadastrarNovaFormaDePagamento(FormaDePagamentoCtl fpgCtl) // Cadastra e uma nova Forma de Pagamento.
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "INSERT INTO Formas_De_Pagamento (Nome) VALUES (@nomeFormPag)";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);
                var paramNome = comandosSql.CreateParameter();
                paramNome.ParameterName = "@nomeFormPag";
                paramNome.DbType = DbType.String;
                paramNome.Value = fpgCtl.NomeDaFormaDePagamento;
                comandosSql.Parameters.Add(paramNome);

                if (comandosSql.ExecuteNonQuery() > 0)
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                throw; // Esta faltando eu pegar a exeção.
            }
            finally { conexao.Close(); }
        }
    }
}
