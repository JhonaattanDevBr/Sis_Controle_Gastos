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
    public class CartaoDeCreditoMdl
    {
        public bool CadastrarNovoCartaoDeCredito(CartaoDeCreditoCtl carCredCtl) // Cadastra um novo cartão de credito.
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "INSERT INTO Cartoes_De_Credito (Nome, Vencimento) VALUES (@nomeCarCred, @dataVenc)";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);
                var paramNome = comandosSql.CreateParameter();
                paramNome.ParameterName = "@nomeCarCred";
                paramNome.DbType = DbType.String;
                paramNome.Value = carCredCtl.NomeDaCartaoDeCredito;
                comandosSql.Parameters.Add(paramNome);

                var paramDataVenc = comandosSql.CreateParameter();
                paramDataVenc.ParameterName = "@dataVenc";
                paramDataVenc.DbType = DbType.Int16;
                paramDataVenc.Value = carCredCtl.DataDeVencimento;
                comandosSql.Parameters.Add(paramDataVenc);

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
