using SisGenGastosControl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

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

        public bool CadastrarNovoGastoFixo(GastosFixosCtl gastosFixosCtl) // Já esta gravando no banco de dados.
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
                paramIdcat.ParameterName = "@idCat";
                paramIdcat.DbType = DbType.Int32;
                paramIdcat.Value = gastosFixosCtl.Categoria;
                comandosSql.Parameters.Add(paramIdcat);

                var paramDataPagamento = comandosSql.CreateParameter();
                paramDataPagamento.ParameterName = "@dataPag";
                paramDataPagamento.DbType = DbType.String;
                paramDataPagamento.Value = gastosFixosCtl.DataDoPagamento;
                comandosSql.Parameters.Add(paramDataPagamento);

                var paramValor = comandosSql.CreateParameter();
                paramValor.ParameterName = "@valor";
                paramValor.DbType = DbType.String;
                paramValor.Value = gastosFixosCtl.Valor;
                comandosSql.Parameters.Add(paramValor);

                var paramIdFormPagamento = comandosSql.CreateParameter();
                paramIdFormPagamento.ParameterName = "@idFormPag";
                paramIdFormPagamento.DbType = DbType.Int32;
                paramIdFormPagamento.Value = gastosFixosCtl.FormaDePagamento;
                comandosSql.Parameters.Add(paramIdFormPagamento);

                var paramPago = comandosSql.CreateParameter();
                paramPago.ParameterName = "@pago";
                paramPago.DbType = DbType.String;
                paramPago.Value = gastosFixosCtl.Status;
                comandosSql.Parameters.Add(paramPago);

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

        public bool ExcluirRegistroGastoFixo(string idGastoFixo)
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string delete = "DELETE FROM Gastos_Fixos WHERE IdGastoFixo = @idRegistroGastoFixo";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(delete, conexao);
                var paramId = comandosSql.CreateParameter();
                paramId.ParameterName = "@idRegistroGastoFixo";
                paramId.DbType = DbType.String;
                paramId.Value = idGastoFixo;
                comandosSql.Parameters.Add(paramId);

                if(comandosSql.ExecuteNonQuery() > 0)
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

        public DataTable TabelaDeGastosFixos()
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "SELECT IdGastoFixo AS 'Cod. Gasto', Gastos_Fixos.Nome, Gastos_Fixos.IdCategoria AS 'Cod.Categoria', Categoria.Nome AS 'Categoria', DataDePagamento  'Data Pag.', " +
                            "Gastos_Fixos.IdFormaDePagamento AS 'Cod. Form. Pag.', Formas_De_Pagamento.Nome AS 'Forma de Pagamento', Valor, Pago " +
                            "FROM Gastos_Fixos " +
                            "JOIN Categoria ON Gastos_Fixos.IdCategoria = Categoria.IdCategoria " +
                            "JOIN Formas_De_Pagamento ON Gastos_Fixos.IdFormaDePagamento = Formas_De_Pagamento.IdFormaDePagamento ";

            /* === SELECT PRINCIPAL DA TABELA DE GASTOS FIXOS ===

            SELECT IdGastoFixo AS 'Cod. Gasto', 
	            Gastos_Fixos.Nome, 
	            Gastos_Fixos.IdCategoria AS 'Cod.Categoria', 
	            Categoria.Nome AS 'Categoria', 
	            DataDePagamento  'Data Pag.', 
	            Gastos_Fixos.IdFormaDePagamento AS 'Cod. Form. Pag.', 
	            Formas_De_Pagamento.Nome AS 'Forma de Pagamento', 
	            Valor,
	            Pago
            FROM Gastos_Fixos 
	            JOIN Categoria ON Gastos_Fixos.IdCategoria = Categoria.IdCategoria
                JOIN Formas_De_Pagamento ON Gastos_Fixos.IdFormaDePagamento = Formas_De_Pagamento.IdFormaDePagamento WHERE IdGastoFixo = @idGastoFixo
             
             */
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);

                DataTable tabelaDeGastosFixos = new DataTable();
                SqlDataReader leitor = comandosSql.ExecuteReader();

                tabelaDeGastosFixos.Columns.Add("Cod. Gasto", typeof(int));
                tabelaDeGastosFixos.Columns.Add("Nome", typeof(string));
                tabelaDeGastosFixos.Columns.Add("Cod. Categoria", typeof(int));
                tabelaDeGastosFixos.Columns.Add("Categoria", typeof(string));
                tabelaDeGastosFixos.Columns.Add("Data Pag.", typeof(string));
                tabelaDeGastosFixos.Columns.Add("Cod. Form. Pag.", typeof(int));
                tabelaDeGastosFixos.Columns.Add("Forma de Pagamento", typeof(string));
                tabelaDeGastosFixos.Columns.Add("Valor", typeof(string));
                tabelaDeGastosFixos.Columns.Add("Pago", typeof(string));

                while (leitor.Read())
                {
                    int codGasto = leitor.GetInt32(0);
                    string nomeGasto = leitor.GetString(1);
                    int codCategoria = leitor.GetInt32(2);
                    string categoria = leitor.GetString(3);
                    string dataPagamento = leitor.GetString(4);
                    int codFormaDePagamento = leitor.GetInt32(5);
                    string formaDePagamento = leitor.GetString(6);
                    string valor = leitor.GetString(7);
                    string pago = leitor.GetString(8);

                    tabelaDeGastosFixos.Rows.Add(codGasto, nomeGasto, codCategoria, categoria, dataPagamento, codFormaDePagamento, formaDePagamento, valor, pago);
                }
                conexao.Close();
                return tabelaDeGastosFixos;
            }
            catch (Exception)
            {
                throw; // Esta faltando eu pegar a exeção.
            }
            finally { conexao.Close(); }
        }

        public List<string> ColetarDadosDoRegistro(string idGastoFixo)
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string select = "SELECT IdGastoFixo AS 'Cod. Gasto', Gastos_Fixos.Nome, Gastos_Fixos.IdCategoria AS 'Cod.Categoria', Categoria.Nome AS 'Categoria', DataDePagamento  'Data Pag.', " +
                            "Gastos_Fixos.IdFormaDePagamento AS 'Cod. Form. Pag.', Formas_De_Pagamento.Nome AS 'Forma de Pagamento', Valor, Pago " +
                            "FROM Gastos_Fixos " +
                            "JOIN Categoria ON Gastos_Fixos.IdCategoria = Categoria.IdCategoria " +
                            "JOIN Formas_De_Pagamento ON Gastos_Fixos.IdFormaDePagamento = Formas_De_Pagamento.IdFormaDePagamento " +
                            "WHERE IdGastoFixo = @idGastoFixo";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(select, conexao);
                var paramIdGastoFixo = comandosSql.CreateParameter();
                paramIdGastoFixo.ParameterName = "@idGastoFixo";
                paramIdGastoFixo.DbType = DbType.Int16;
                paramIdGastoFixo.Value = idGastoFixo;
                comandosSql.Parameters.Add(paramIdGastoFixo);

                List<string> listaDadosRegistro = new List<string>();
                string[] coletorDeRegistros = new string[6];
                SqlDataReader leitor = comandosSql.ExecuteReader();

                while (leitor.Read())
                {
                    listaDadosRegistro.Add(leitor.GetString(1));
                    listaDadosRegistro.Add(leitor.GetString(3));
                    listaDadosRegistro.Add(leitor.GetString(4));
                    listaDadosRegistro.Add(leitor.GetString(6));
                    listaDadosRegistro.Add(leitor.GetString(7));
                    listaDadosRegistro.Add(leitor.GetString(8));
                    break;
                }
                return listaDadosRegistro;
            }
            catch (Exception)
            {
                throw; // Esta faltando eu pegar a exeção.
            }
            finally { conexao.Close(); }
        }

        public bool AtualizarRegistroGastoFixo(GastosFixosCtl gastosFixosCtl, string idGastoFixo)
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "UPDATE Gastos_Fixos SET " +
                            "Nome = @nomeGasto, IdCategoria = @idCategoria, DataDePagamento = @dataPagamento, " +
                            "Valor = @valor, IdFormaDePagamento = @idFormaPagamento, Pago = @status " +
                            "WHERE IdGastoFixo = @idGastoFixo";
            /*
             UPDATE Gastos_Fixos SET 
	            Nome = @nomeGasto, IdCategoria = @idCategoria, DataDePagamento = @dataPagamento, 
	            Valor = @valor, IdFormaDePagamento = @formaPagamento, Pago = @status 
	         WHERE IdGastoFixo = @idGastoFixo 
             */
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);

                var paramNome = comandosSql.CreateParameter();
                paramNome.ParameterName = "@nomeGasto";
                paramNome.DbType = DbType.String;
                paramNome.Value = gastosFixosCtl.NomeDoGasto;
                comandosSql.Parameters.Add(paramNome);

                var paramIdcat = comandosSql.CreateParameter();
                paramIdcat.ParameterName = "@idCategoria";
                paramIdcat.DbType = DbType.Int32;
                paramIdcat.Value = gastosFixosCtl.Categoria;
                comandosSql.Parameters.Add(paramIdcat);

                var paramDataPagamento = comandosSql.CreateParameter();
                paramDataPagamento.ParameterName = "@dataPagamento";
                paramDataPagamento.DbType = DbType.String;
                paramDataPagamento.Value = gastosFixosCtl.DataDoPagamento;
                comandosSql.Parameters.Add(paramDataPagamento);

                var paramValor = comandosSql.CreateParameter();
                paramValor.ParameterName = "@valor";
                paramValor.DbType = DbType.String;
                paramValor.Value = gastosFixosCtl.Valor;
                comandosSql.Parameters.Add(paramValor);

                var paramIdFormPagamento = comandosSql.CreateParameter();
                paramIdFormPagamento.ParameterName = "@idFormaPagamento";
                paramIdFormPagamento.DbType = DbType.Int32;
                paramIdFormPagamento.Value = gastosFixosCtl.FormaDePagamento;
                comandosSql.Parameters.Add(paramIdFormPagamento);

                var paramPago = comandosSql.CreateParameter();
                paramPago.ParameterName = "@status";
                paramPago.DbType = DbType.String;
                paramPago.Value = gastosFixosCtl.Status;
                comandosSql.Parameters.Add(paramPago);

                var paramIdGastoFixo = comandosSql.CreateParameter();
                paramIdGastoFixo.ParameterName = "@idGastoFixo";
                paramIdGastoFixo.DbType = DbType.Int32;
                paramIdGastoFixo.Value = idGastoFixo;
                comandosSql.Parameters.Add(paramIdGastoFixo);

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
