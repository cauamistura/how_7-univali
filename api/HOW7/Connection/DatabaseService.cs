using MySql.Data.MySqlClient;
using System.Data;

namespace HOW7.Connection
{
    public class DatabaseService
    {
        private readonly string _connectionString = "Server=localhost;Database=how7;User ID=root;Password=;";

        private IDbConnection Connection => new MySqlConnection(_connectionString);

        public IDataReader ExecuteReader(string sql, object? parameters = null)
        {
            var connection = Connection;
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = sql;
            if (parameters != null)
            {
                foreach (var param in parameters.GetType().GetProperties())
                {
                    var parameter = command.CreateParameter();
                    parameter.ParameterName = param.Name;
                    parameter.Value = param.GetValue(parameters, null) ?? DBNull.Value;
                    command.Parameters.Add(parameter);
                }
            }
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
