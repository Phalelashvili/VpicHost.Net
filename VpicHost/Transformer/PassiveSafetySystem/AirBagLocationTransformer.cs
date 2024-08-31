using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.PassiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.PassiveSafetySystem;

public class AirBagLocationTransformer
{
    public AirBagLocationGroup Transform(DecodeDbResult[] result)
    {
        return new AirBagLocationGroup
        {
            AirBagLocCurtain = TransformAirBagLocCurtain(result),
            AirBagLocSeatCushion = TransformAirBagLocSeatCushion(result),
            AirBagLocFront = TransformAirBagLocFront(result),
            AirBagLocKnee = TransformAirBagLocKnee(result),
            AirBagLocSide = TransformAirBagLocSide(result)
        };
    }
    

    private AirBagLocCurtainElement? TransformAirBagLocCurtain(DecodeDbResult[] result)
    {
        return result.TryGetValue(AirBagLocCurtainElement.Code, out var value) ? new AirBagLocCurtainElement(value) : null;
    }

    private AirBagLocSeatCushionElement? TransformAirBagLocSeatCushion(DecodeDbResult[] result)
    {
        return result.TryGetValue(AirBagLocSeatCushionElement.Code, out var value) ? new AirBagLocSeatCushionElement(value) : null;
    }

    private AirBagLocFrontElement? TransformAirBagLocFront(DecodeDbResult[] result)
    {
        return result.TryGetValue(AirBagLocFrontElement.Code, out var value) ? new AirBagLocFrontElement(value) : null;
    }

    private AirBagLocKneeElement? TransformAirBagLocKnee(DecodeDbResult[] result)
    {
        return result.TryGetValue(AirBagLocKneeElement.Code, out var value) ? new AirBagLocKneeElement(value) : null;
    }

    private AirBagLocSideElement? TransformAirBagLocSide(DecodeDbResult[] result)
    {
        return result.TryGetValue(AirBagLocSideElement.Code, out var value) ? new AirBagLocSideElement(value) : null;
    }
}