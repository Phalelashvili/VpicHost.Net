using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Exterior;

public class BusTransformer
{
    public BusGroup Transform(DecodeDbResult[] result)
    {
        return new BusGroup
        {
            BusLength = TransformBusLength(result),
            BusFloorConfigType = TransformBusFloorConfigType(result),
            BusType = TransformBusType(result),
            OtherBusInfo = TransformOtherBusInfo(result)
        };
    }
    

    private BusLengthElement? TransformBusLength(DecodeDbResult[] result)
    {
        return result.TryGetValue(BusLengthElement.Code, out var value) ? new BusLengthElement(value) : null;
    }

    private BusFloorConfigTypeElement? TransformBusFloorConfigType(DecodeDbResult[] result)
    {
        return result.TryGetValue(BusFloorConfigTypeElement.Code, out var value) ? new BusFloorConfigTypeElement(value) : null;
    }

    private BusTypeElement? TransformBusType(DecodeDbResult[] result)
    {
        return result.TryGetValue(BusTypeElement.Code, out var value) ? new BusTypeElement(value) : null;
    }

    private OtherBusInfoElement? TransformOtherBusInfo(DecodeDbResult[] result)
    {
        return result.TryGetValue(OtherBusInfoElement.Code, out var value) ? new OtherBusInfoElement(value) : null;
    }
}