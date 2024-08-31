using VpicHost.Database;

namespace VpicHost.Transformer.Extensions;

public static class DecodeDbResultExtensions
{
    public static string? GetValue(this DecodeDbResult[] decodeDbResult, string key)
    {
        return decodeDbResult.FirstOrDefault(x => x.Code == key)?.Value;
    }

    public static bool TryGetValue(this DecodeDbResult[] decodeDbResult, string key, out string value)
    {
        value = decodeDbResult.GetValue(key);
        return value is not null;
    }
}