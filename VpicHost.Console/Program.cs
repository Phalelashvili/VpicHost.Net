using System.Text.Json;
using System.Text.Json.Serialization;
using VpicHost;
using VpicHost.Database;

const string connectionString = "data source=localhost;initial catalog=VPICList_lite1;trusted_connection=true";

var connectionFactory = new SqlConnectionFactory(connectionString);
var db = new VpicDatabase(connectionFactory);
var client = new VpicClient(db);

while (true)
{
    Console.Write("Enter VIN: ");
    var vin = Console.ReadLine();
    
    var result = await client.VinDecodeAsync(vin);
    
    var json = JsonSerializer.Serialize(result, new JsonSerializerOptions()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        WriteIndented = true
    });
    Console.WriteLine(json);
}