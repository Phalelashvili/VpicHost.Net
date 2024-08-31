using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Exterior;

public class TruckTransformer
{
    public TruckGroup Transform(DecodeDbResult[] result)
    {
        return new TruckGroup
        {
            BedType = TransformBedType(result),
            BodyCabType = TransformBodyCabType(result)
        };
    }
    

    private BedTypeElement? TransformBedType(DecodeDbResult[] result)
    {
        return result.TryGetValue(BedTypeElement.Code, out var value) ? new BedTypeElement(value) : null;
    }

    private BodyCabTypeElement? TransformBodyCabType(DecodeDbResult[] result)
    {
        return result.TryGetValue(BodyCabTypeElement.Code, out var value) ? new BodyCabTypeElement(value) : null;
    }
}