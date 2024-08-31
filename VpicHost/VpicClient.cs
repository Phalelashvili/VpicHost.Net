using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Transformer;

namespace VpicHost;

public class VpicClient(VpicDatabase db)
{
    public async Task<DecodedVin> VinDecodeAsync(string vin, int? year = null)
    {
        var result = await db.VinDecodeAsync(vin, year);
        var transformer = new DbResultTransformer();
        return transformer.Transform(result.ToArray());
    }
}