using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Interior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Interior;

public class SeatTransformer
{
    public SeatGroup Transform(DecodeDbResult[] result)
    {
        return new SeatGroup
        {
            Seats = TransformSeats(result),
            SeatRows = TransformSeatRows(result)
        };
    }
    

    private SeatsElement? TransformSeats(DecodeDbResult[] result)
    {
        return result.TryGetValue(SeatsElement.Code, out var value) ? new SeatsElement(value) : null;
    }

    private SeatRowsElement? TransformSeatRows(DecodeDbResult[] result)
    {
        return result.TryGetValue(SeatRowsElement.Code, out var value) ? new SeatRowsElement(value) : null;
    }
}