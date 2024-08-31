using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.ActiveSafetySystem;

public class Notification911Transformer
{
    public Notification911Group Transform(DecodeDbResult[] result)
    {
        return new Notification911Group
        {
            CanAacn = TransformCanAacn(result)
        };
    }

    private CanAacnElement? TransformCanAacn(DecodeDbResult[] result)
    {
        return result.TryGetValue(CanAacnElement.Code, out var value) ? new CanAacnElement(value) : null;
    }
}