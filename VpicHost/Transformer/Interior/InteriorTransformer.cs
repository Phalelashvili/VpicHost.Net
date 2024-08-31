using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Interior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Interior;

public class InteriorTransformer
{
    public InteriorGroup Transform(DecodeDbResult[] result)
    {
        return new InteriorGroup
        {
            EntertainmentSystem = TransformEntertainmentSystem(result),
            SteeringLocation = TransformSteeringLocation(result),
            SeatGroup = TransformSeatGroup(result)
        };
    }


    private EntertainmentSystemElement? TransformEntertainmentSystem(DecodeDbResult[] result)
    {
        return result.TryGetValue(EntertainmentSystemElement.Code, out var value) ? new EntertainmentSystemElement(value) : null;
    }

    private SteeringLocationElement? TransformSteeringLocation(DecodeDbResult[] result)
    {
        return result.TryGetValue(SteeringLocationElement.Code, out var value) ? new SteeringLocationElement(value) : null;
    }

    private SeatGroup TransformSeatGroup(DecodeDbResult[] result)
    {
        return new SeatTransformer().Transform(result);
    }
}