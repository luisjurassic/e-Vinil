using e_Vinil.Interface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace e_Vinil.DAL
{
    class DBConnection : IConnect, IDisposable
    {

        public void Execute(SqlCommand command)
        {
            using (DBConnection conn = new DBConnection())
            {
                conn.AttachCommand(command);
                command.ExecuteNonQuery();
            }
        }
        public int ExecuteOnIdentity(SqlCommand command)
        {
            using (DBConnection conn = new DBConnection())
            {
                conn.AttachCommand(command);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public DataTable Search(SqlCommand command)
        {
            using (DBConnection conn = new DBConnection())
            {
                conn.AttachCommand(command);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        SqlConnection _connection;
        public DBConnection()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\dbo_eVinil.mdf;Integrated Security=True");
        }
        public void AttachCommand(SqlCommand command)
        {
            command.Connection = _connection;
            this.Abrir();
        }
        public void Abrir()
        {
            if (_connection.State != ConnectionState.Open)
	        {
		         _connection.Open();
	        }
        }
        public void Fechar()
        {
            if (_connection.State == ConnectionState.Open)
	        {
		         _connection.Close();
	        }
        }
        public void Dispose()
        {
            this.Fechar();
        }
    }
}