using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Exterior;

public class WheeltireTransformer
{
    public WheeltireGroup Transform(DecodeDbResult[] result)
    {
        return new WheeltireGroup
        {
            Wheels = TransformWheels(result),
            WheelSizeFront = TransformWheelSizeFront(result),
            WheelSizeRear = TransformWheelSizeRear(result)
        };
    }
    

    private WheelsElement? TransformWheels(DecodeDbResult[] result)
    {
        return result.TryGetValue(WheelsElement.Code, out var value) ? new WheelsElement(value) : null;
    }

    private WheelSizeFrontElement? TransformWheelSizeFront(DecodeDbResult[] result)
    {
        return result.TryGetValue(WheelSizeFrontElement.Code, out var value) ? new WheelSizeFrontElement(value) : null;
    }

    private WheelSizeRearElement? TransformWheelSizeRear(DecodeDbResult[] result)
    {
        return result.TryGetValue(WheelSizeRearElement.Code, out var value) ? new WheelSizeRearElement(value) : null;
    }
}