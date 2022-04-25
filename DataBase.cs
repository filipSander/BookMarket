using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookMarket
{
    class DataBase // основной класс для работы с удаленной базой данных
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=bookmarket;");
        public bool ValidConection()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch { return false; } 
        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // only select op.
        public DataTable RequestTable(MySqlCommand command)
        {
            DataTable table = new DataTable();
            if (ValidConection())
            {
                OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                CloseConnection();
            }
            else
                new ErrorForm("Ошибка соединения с бд.", 0).Show();
                
            return table;
        }

        // only grud operation
        public bool Request(MySqlCommand command)
        {
            if (ValidConection())
            {
                OpenConnection();
                if (command.ExecuteNonQuery() > 0)
                    return true;
                CloseConnection();
            }
            else
                new ErrorForm("Ошибка соединения с бд.", 0).Show();
            return false;
        }

        public int GetID(string _table, string _column)
        {
            MySqlCommand command = new MySqlCommand($"SELECT MAX(`{ _column }`) From `{ _table}`", GetConnection());;
            DataTable table = RequestTable(command);
            int _id = 0;
            if (!table.Rows[0].IsNull(0))
                _id = table.Rows[0].Field<int>($"MAX(`{_column}`)") + 1;
            return _id;
        }

        public bool СheckTableOwned(string _table, string _parametr, int _parametrValue)
        {
            MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) as `COUNT` FROM `{_table}` where `{_parametr}` = @id", GetConnection());
            command.Parameters.Add("id", MySqlDbType.Int32).Value = _parametrValue;
            DataTable table = RequestTable(command);
            if (table.Rows[0].Field<Int64>("COUNT") > 0)
                return true;
            return false;
        }
    }
}