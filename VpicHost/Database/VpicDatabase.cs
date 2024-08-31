using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace VpicHost.Database;

public class VpicDatabase(SqlConnectionFactory connectionFactory)
{
    private readonly SqlConnection connection = connectionFactory.CreateConnection();

    public async Task<IEnumerable<DecodeDbResult>> VinDecodeAsync(string v, int? year = null)
    {
        var procedureParams = new
        {
            V = v,
            Year = year
        };
        return await connection.QueryAsync<DecodeDbResult>("[dbo].[spVinDecode]",
            procedureParams,
            commandType: CommandType.StoredProcedure);
    }
}