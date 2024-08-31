using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Exterior;

public class DimensionTransformer
{
    public DimensionGroup Transform(DecodeDbResult[] result)
    {
        return new DimensionGroup
        {
            Gvwr = TransformGvwr(result),
            BedLengthIn = TransformBedLengthIn(result),
            CurbWeightLb = TransformCurbWeightLb(result),
            WheelBaseShort = TransformWheelBaseShort(result),
            WheelBaseLong = TransformWheelBaseLong(result),
            Gcwr = TransformGcwr(result),
            GcwrTo = TransformGcwrTo(result),
            GvwrTo = TransformGvwrTo(result)
        };
    }
    

    private GvwrElement? TransformGvwr(DecodeDbResult[] result)
    {
        return result.TryGetValue(GvwrElement.Code, out var value) ? new GvwrElement(value) : null;
    }

    private BedLengthInElement? TransformBedLengthIn(DecodeDbResult[] result)
    {
        return result.TryGetValue(BedLengthInElement.Code, out var value) ? new BedLengthInElement(value) : null;
    }

    private CurbWeightLbElement? TransformCurbWeightLb(DecodeDbResult[] result)
    {
        return result.TryGetValue(CurbWeightLbElement.Code, out var value) ? new CurbWeightLbElement(value) : null;
    }

    private WheelBaseShortElement? TransformWheelBaseShort(DecodeDbResult[] result)
    {
        return result.TryGetValue(WheelBaseShortElement.Code, out var value) ? new WheelBaseShortElement(value) : null;
    }

    private WheelBaseLongElement? TransformWheelBaseLong(DecodeDbResult[] result)
    {
        return result.TryGetValue(WheelBaseLongElement.Code, out var value) ? new WheelBaseLongElement(value) : null;
    }

    private GcwrElement? TransformGcwr(DecodeDbResult[] result)
    {
        return result.TryGetValue(GcwrElement.Code, out var value) ? new GcwrElement(value) : null;
    }

    private GcwrToElement? TransformGcwrTo(DecodeDbResult[] result)
    {
        return result.TryGetValue(GcwrToElement.Code, out var value) ? new GcwrToElement(value) : null;
    }

    private GvwrToElement? TransformGvwrTo(DecodeDbResult[] result)
    {
        return result.TryGetValue(GvwrToElement.Code, out var value) ? new GvwrToElement(value) : null;
    }
}