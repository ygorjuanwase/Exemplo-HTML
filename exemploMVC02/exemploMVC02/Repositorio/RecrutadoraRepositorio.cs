using exemploMVC02.DataBase;
using exemploMVC02.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace exemploMVC02.Repositorio
{
    public class RecrutadoraRepositorio
    {
        public List<Recrutadora> obterTodos()
        {
            List<Recrutadora> recrutadoras = new List<Recrutadora>();
            SqlCommand comando = new BancoDados().obterconexao();
            comando.CommandText = "SELECT id, nome, cpf, tempo_empresa, salario FROM recrutadoras";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            foreach (DataRow linha in tabela.Rows)
            {
                Recrutadora recrutadora = new Recrutadora()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                    CPF = linha[2].ToString(),
                    TempoEmpresa = Convert.ToByte(linha[3].ToString()),
                    Salario = Convert.ToDecimal(linha[4].ToString())
                };
                recrutadoras.Add(recrutadora);
            }
            return recrutadoras;
        }
        public int Cadastrar(Recrutadora recrutadora)
        {
            SqlCommand comando = new BancoDados().obterconexao();
            comando.CommandText = @"INSERT INTO recrutadoras(nome, salario, cpf,tempo_empresa)
            OUTPUT INSERTES.ID VALUES
            (@NOME< @SALARIO< @CPF< @TEMPO_EMPRESA)";
            comando.Parameters.AddWithValue("@NOME", recrutadora.Nome);
            comando.Parameters.AddWithValue("@SALARIO", recrutadora.Salario);
            comando.Parameters.AddWithValue("@CPF", recrutadora.CPF);
            comando.Parameters.AddWithValue("@TEMPO_EMPRESA", recrutadora.TempoEmpresa);
            int id = Convert.ToInt32(comando.ExecuteScalar().ToString());

            return  id;
        }

        public bool Alterar(Recrutadora recrutadora)
        {
            return false;
        }

        public bool Excuir(int id)
        {
            return false;
        }
        public Recrutadora ObterPeloId(int id)
        {
            Recrutadora recrutadora = null;
            return recrutadora;
        }
    }
}