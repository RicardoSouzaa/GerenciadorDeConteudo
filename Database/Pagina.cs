using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pagina
    {
        private string SqlConn()
        {
            return ConfigurationManager.AppSettings["sqlConn"];
        }

        public DataTable Lista()
        {
            using (SqlConnection connection = new SqlConnection(SqlConn()))
            {
                string queryString = "select * from paginas";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = command
                };

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void Salvar(int id, string nome, string conteudo, DateTime data)
        {
            using (SqlConnection connection = new SqlConnection(SqlConn()))
            {
                string queryString = "insert into paginas(nome, data, conteudo) values('" + nome + "','" + data.ToString("dd/MM/yyyy") + "','" + conteudo + "')";
                if (id != 0)
                {
                    queryString = "update paginas set nome='" + nome + "', data='" + data.ToString("dd /MM/yyyy") + "', conteudo='" + conteudo + "' where id=" + id;
                }

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}