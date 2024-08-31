using System.Data.SqlClient;

namespace VpicHost.Database;

public class SqlConnectionFactory(string connectionString)
{
    public SqlConnection CreateConnection()
    {
        return new SqlConnection(connectionString);
    }
}