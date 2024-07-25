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
    public class GastosFixosMdl
    {
        public string ColetarIdCategoria(GastosFixosCtl gastosFixosCtl)
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "SELECT IdCategoria FROM Categoria WHERE Nome = @nomeCategoria";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);
                var paramNome = comandosSql.CreateParameter();
                paramNome.ParameterName = "@nomeCategoria";
                paramNome.DbType = DbType.String;
                paramNome.Value = gastosFixosCtl.Categoria;
                comandosSql.Parameters.Add(paramNome);

                SqlDataReader leitor = comandosSql.ExecuteReader();
                string idCategoria = null;
                while (leitor.Read())
                {
                    idCategoria = leitor.GetInt32(0).ToString();
                    break;
                }
                return idCategoria;
            }
            catch (Exception)
            {
                throw; // Esta faltando eu pegar a exeção.
            }
            finally { conexao.Close(); }
        }

        public string ColetarIdFormaDePagamento(GastosFixosCtl gastosFixosCtl)
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "SELECT IdFormaDePagamento FROM Formas_De_Pagamento WHERE Nome = @nomeFormaDePagamento";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);
                var paramNome = comandosSql.CreateParameter();
                paramNome.ParameterName = "@nomeFormaDePagamento";
                paramNome.DbType = DbType.String;
                paramNome.Value = gastosFixosCtl.FormaDePagamento;
                comandosSql.Parameters.Add(paramNome);

                SqlDataReader leitor = comandosSql.ExecuteReader();
                string idFormaDePagamento = null;
                while (leitor.Read())
                {
                    idFormaDePagamento = leitor.GetInt32(0).ToString();
                    break;
                }
                return idFormaDePagamento;
            }
            catch (Exception)
            {
                throw; // Esta faltando eu pegar a exeção.
            }
            finally { conexao.Close(); }
        }

        public bool CadastrarNovoGastoFixo(GastosFixosCtl gastosFixosCtl)
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "INSERT INTO Gastos_Fixos (Nome, IdCategoria, DataDePagamento, Valor, IdFormaDePagamento, Pago) " +
                            "VALUES (@nome, @idCat, @dataPag, @valor, @idFormPag, @pago)";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);
                var paramNome = comandosSql.CreateParameter();
                paramNome.ParameterName = "@nome";
                paramNome.DbType = DbType.String;
                paramNome.Value = gastosFixosCtl.NomeDoGasto;
                comandosSql.Parameters.Add(paramNome);

                var paramIdcat = comandosSql.CreateParameter();
                

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
