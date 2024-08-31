using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.ActiveSafetySystem;

public class MaintainingSafeDistanceTransformer
{
    public MaintainingSafeDistanceGroup Transform(DecodeDbResult[] result)
    {
        return new MaintainingSafeDistanceGroup
        {
            AdaptiveCruiseControl = TransformAdaptiveCruiseControl(result)
        };
    }
    

    private AdaptiveCruiseControlElement? TransformAdaptiveCruiseControl(DecodeDbResult[] result)
    {
        return result.TryGetValue(AdaptiveCruiseControlElement.Code, out var value) ? new AdaptiveCruiseControlElement(value) : null;
    }
}