using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Mechanical;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Mechanical;

public class TransmissionTransformer
{
    public TransmissionGroup Transform(DecodeDbResult[] result)
    {
        return new TransmissionGroup
        {
            TransmissionStyle = TransformTransmissionStyle(result),
            TransmissionSpeeds = TransformTransmissionSpeeds(result)
        };
    }
    

    private TransmissionStyleElement? TransformTransmissionStyle(DecodeDbResult[] result)
    {
        return result.TryGetValue(TransmissionStyleElement.Code, out var value) ? new TransmissionStyleElement(value) : null;
    }

    private TransmissionSpeedsElement? TransformTransmissionSpeeds(DecodeDbResult[] result)
    {
        return result.TryGetValue(TransmissionSpeedsElement.Code, out var value) ? new TransmissionSpeedsElement(value) : null;
    }
}