using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Mechanical;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Mechanical;

public class BrakeTransformer
{
    public BrakeGroup Transform(DecodeDbResult[] result)
    {
        return new BrakeGroup
        {
            BrakeSystemType = TransformBrakeSystemType(result),
            BrakeSystemDesc = TransformBrakeSystemDesc(result)
        };
    }
    

    private BrakeSystemTypeElement? TransformBrakeSystemType(DecodeDbResult[] result)
    {
        return result.TryGetValue(BrakeSystemTypeElement.Code, out var value) ? new BrakeSystemTypeElement(value) : null;
    }

    private BrakeSystemDescElement? TransformBrakeSystemDesc(DecodeDbResult[] result)
    {
        return result.TryGetValue(BrakeSystemDescElement.Code, out var value) ? new BrakeSystemDescElement(value) : null;
    }
}