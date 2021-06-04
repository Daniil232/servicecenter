using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using MySql.Data.MySqlClient;

namespace DatabaseProvider
{
    public class Pair<T, K>
    {
        public T First { get; set; }
        public K Second { get; set; }
    }

    public class Database
    {
        public MySqlConnection SqlConnection { get; set; } = null;
        private string server = "127.0.0.1";
        private string database = "servicecenter";
        private int port = 3307;
        private string username = "root";
        private string password = "qwerty";

        public Database()
        {
            SqlConnection = new MySqlConnection(string.Format("Server={0};Database={1};port={2};User Id={3};password={4};AllowUserVariables=True", server, database, port, username, password));
        }

        public DataTable Query(string query)
        {
            if (SqlConnection.State == ConnectionState.Open)
                SqlConnection.Close();

            SqlConnection.Open();
            var adapter = new MySqlDataAdapter(query, SqlConnection);
            var data = new DataTable();
            adapter.Fill(data);
            SqlConnection.Close();
            return data;
        }

        public DataTable Query(MySqlCommand command)
        {
            if (SqlConnection.State == ConnectionState.Open)
                SqlConnection.Close();

            SqlConnection.Open();
            command.Connection = SqlConnection;
            var data = new DataTable();
            data.Load(command.ExecuteReader());
            SqlConnection.Close();
            return data;
        }

        public bool ExistsUser(string username, string password)
        {
            var hash = GenerateHash.ComputeHash(Encoding.ASCII.GetBytes(username + password));
            SqlConnection.Open();
            var query = new MySqlCommand("SELECT * FROM user;", SqlConnection).ExecuteReader();

            while (query.Read())
            {
                if (query["hashCode"].ToString() == Encoding.ASCII.GetString(hash))
                {
                    SqlConnection.Close();
                    return true;
                }
            }

            SqlConnection.Close();
            return false;
        }

        public bool UserIsAdmin(string username, string password)
        {
            SqlConnection.Open();

            var hash = Encoding.ASCII.GetString(GenerateHash.ComputeHash(Encoding.ASCII.GetBytes(username + password)));
            DataTable table = new DataTable();
            table.Load(new MySqlCommand(string.Format("SELECT isAdmin FROM user WHERE hashCode = '{0}'", hash), SqlConnection).ExecuteReader());

            if (table.Rows.Count == 1 && table.Rows[0].Field<sbyte>("isAdmin") == 1)
            {
                SqlConnection.Close();
                return true;
            }

            SqlConnection.Close();
            return false;
        }

        public void Register(string username, string password, int isAdmin)
        {

            SqlConnection.Open();

            var hash = GetHash(username, password);
            var query = new MySqlCommand(string.Format("INSERT INTO user (hashCode, login, isAdmin) VALUES ('{0}', '{1}', '{2}');", hash, username, isAdmin), SqlConnection).ExecuteNonQuery();

            SqlConnection.Close();
           
        }

        public string GetHash(string username, string password)
        {
            return Encoding.ASCII.GetString(GenerateHash.ComputeHash(Encoding.ASCII.GetBytes(username + password)));
        }
    }
}
