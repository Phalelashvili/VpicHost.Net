using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.PassiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.PassiveSafetySystem;

public class PassiveSafetySystemTransformer
{
    public PassiveSafetySystemGroup Transform(DecodeDbResult[] result)
    {
        return new PassiveSafetySystemGroup
        {
            Pretensioner = TransformPretensioner(result),
            SeatBeltsAll = TransformSeatBeltsAll(result),
            OtherRestraintSystemInfo = TransformOtherRestraintSystemInfo(result)
        };
    }
    

    private PretensionerElement? TransformPretensioner(DecodeDbResult[] result)
    {
        return result.TryGetValue(PretensionerElement.Code, out var value) ? new PretensionerElement(value) : null;
    }

    private SeatBeltsAllElement? TransformSeatBeltsAll(DecodeDbResult[] result)
    {
        return result.TryGetValue(SeatBeltsAllElement.Code, out var value) ? new SeatBeltsAllElement(value) : null;
    }

    private OtherRestraintSystemInfoElement? TransformOtherRestraintSystemInfo(DecodeDbResult[] result)
    {
        return result.TryGetValue(OtherRestraintSystemInfoElement.Code, out var value) ? new OtherRestraintSystemInfoElement(value) : null;
    }
}