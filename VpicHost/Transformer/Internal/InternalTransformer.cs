using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Internal;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Internal;

public class InternalTransformer
{
    public InternalGroup Transform(DecodeDbResult[] result)
    {
        return new InternalGroup
        {
            NcsaBodyType = TransformNcsaBodyType(result),
            NcsaMake = TransformNcsaMake(result),
            NcsaModel = TransformNcsaModel(result),
            NcsaNote = TransformNcsaNote(result),
            NcsaMappingException = TransformNcsaMappingException(result),
            NcsaMapExcApprovedOn = TransformNcsaMapExcApprovedOn(result),
            NcsaMapExcApprovedBy = TransformNcsaMapExcApprovedBy(result)
        };
    }
    

    private NcsaBodyTypeElement? TransformNcsaBodyType(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcsaBodyTypeElement.Code, out var value) ? new NcsaBodyTypeElement(value) : null;
    }

    private NcsaMakeElement? TransformNcsaMake(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcsaMakeElement.Code, out var value) ? new NcsaMakeElement(value) : null;
    }

    private NcsaModelElement? TransformNcsaModel(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcsaModelElement.Code, out var value) ? new NcsaModelElement(value) : null;
    }

    private NcsaNoteElement? TransformNcsaNote(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcsaNoteElement.Code, out var value) ? new NcsaNoteElement(value) : null;
    }

    private NcsaMappingExceptionElement? TransformNcsaMappingException(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcsaMappingExceptionElement.Code, out var value) ? new NcsaMappingExceptionElement(value) : null;
    }

    private NcsaMapExcApprovedOnElement? TransformNcsaMapExcApprovedOn(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcsaMapExcApprovedOnElement.Code, out var value) ? new NcsaMapExcApprovedOnElement(value) : null;
    }

    private NcsaMapExcApprovedByElement? TransformNcsaMapExcApprovedBy(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcsaMapExcApprovedByElement.Code, out var value) ? new NcsaMapExcApprovedByElement(value) : null;
    }
}