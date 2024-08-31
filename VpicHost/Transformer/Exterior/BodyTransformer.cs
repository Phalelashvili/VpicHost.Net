using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Exterior;

public class BodyTransformer
{
    public BodyGroup Transform(DecodeDbResult[] result)
    {
        return new BodyGroup
        {
            BodyClass = TransformBodyClass(result),
            Doors = TransformDoors(result),
            Windows = TransformWindows(result),
            WheelBaseType = TransformWheelBaseType(result),
            TrackWidth = TransformTrackWidth(result)
        };
    }
    

    private BodyClassElement? TransformBodyClass(DecodeDbResult[] result)
    {
        return result.TryGetValue(BodyClassElement.Code, out var value) ? new BodyClassElement(value) : null;
    }

    private DoorsElement? TransformDoors(DecodeDbResult[] result)
    {
        return result.TryGetValue(DoorsElement.Code, out var value) ? new DoorsElement(value) : null;
    }

    private WindowsElement? TransformWindows(DecodeDbResult[] result)
    {
        return result.TryGetValue(WindowsElement.Code, out var value) ? new WindowsElement(value) : null;
    }

    private WheelBaseTypeElement? TransformWheelBaseType(DecodeDbResult[] result)
    {
        return result.TryGetValue(WheelBaseTypeElement.Code, out var value) ? new WheelBaseTypeElement(value) : null;
    }

    private TrackWidthElement? TransformTrackWidth(DecodeDbResult[] result)
    {
        return result.TryGetValue(TrackWidthElement.Code, out var value) ? new TrackWidthElement(value) : null;
    }
}