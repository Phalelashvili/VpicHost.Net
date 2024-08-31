using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Exterior;

public class TrailerTransformer
{
    public TrailerGroup Transform(DecodeDbResult[] result)
    {
        return new TrailerGroup
        {
            TrailerType = TransformTrailerType(result),
            TrailerBodyType = TransformTrailerBodyType(result),
            TrailerLength = TransformTrailerLength(result),
            OtherTrailerInfo = TransformOtherTrailerInfo(result)
        };
    }
    

    private TrailerTypeElement? TransformTrailerType(DecodeDbResult[] result)
    {
        return result.TryGetValue(TrailerTypeElement.Code, out var value) ? new TrailerTypeElement(value) : null;
    }

    private TrailerBodyTypeElement? TransformTrailerBodyType(DecodeDbResult[] result)
    {
        return result.TryGetValue(TrailerBodyTypeElement.Code, out var value) ? new TrailerBodyTypeElement(value) : null;
    }

    private TrailerLengthElement? TransformTrailerLength(DecodeDbResult[] result)
    {
        return result.TryGetValue(TrailerLengthElement.Code, out var value) ? new TrailerLengthElement(value) : null;
    }

    private OtherTrailerInfoElement? TransformOtherTrailerInfo(DecodeDbResult[] result)
    {
        return result.TryGetValue(OtherTrailerInfoElement.Code, out var value) ? new OtherTrailerInfoElement(value) : null;
    }
}