using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisGenGastosControl;

namespace SisGenGastosModel
{
    public class CategoriasMdl
    {
        public bool CadastrarNovaCategoria(CategoriasCtl ctlCat) // Cadastra e uma nova categoria.
        {
            BasesDeDados dtBase = new BasesDeDados();
            SqlConnection conexao = new SqlConnection(dtBase.chaveConexaoDesktop);
            string insert = "INSERT INTO Categoria (Nome) VALUES (@nomeCat)";
            try
            {
                conexao.Open();
                SqlCommand comandosSql = new SqlCommand(insert, conexao);
                var paramNome = comandosSql.CreateParameter();
                paramNome.ParameterName = "@nomeCat";
                paramNome.DbType = DbType.String;
                paramNome.Value = ctlCat.NomeDaCategoria;
                comandosSql.Parameters.Add(paramNome);

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
    }
}
