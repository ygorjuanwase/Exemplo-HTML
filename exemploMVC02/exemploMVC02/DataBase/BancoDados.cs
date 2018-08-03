using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace exemploMVC02.DataBase
{
    public class BancoDados
    {
        private static string connectionString;

        static BancoDados()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public SqlCommand obterconexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            SqlCommand commmand = new SqlCommand();
            commmand.Connection = conexao;
            return commmand;
        } 
    }
}