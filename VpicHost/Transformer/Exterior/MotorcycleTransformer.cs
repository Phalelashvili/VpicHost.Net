using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Exterior;

public class MotorcycleTransformer
{
    public MotorcycleGroup Transform(DecodeDbResult[] result)
    {
        return new MotorcycleGroup
        {
            CustomMotorcycleType = TransformCustomMotorcycleType(result),
            MotorcycleSuspensionType = TransformMotorcycleSuspensionType(result),
            MotorcycleChassisType = TransformMotorcycleChassisType(result),
            OtherMotorcycleInfo = TransformOtherMotorcycleInfo(result)
        };
    }
    
    private CustomMotorcycleTypeElement? TransformCustomMotorcycleType(DecodeDbResult[] result)
    {
        return result.TryGetValue(CustomMotorcycleTypeElement.Code, out var value) ? new CustomMotorcycleTypeElement(value) : null;
    }

    private MotorcycleSuspensionTypeElement? TransformMotorcycleSuspensionType(DecodeDbResult[] result)
    {
        return result.TryGetValue(MotorcycleSuspensionTypeElement.Code, out var value) ? new MotorcycleSuspensionTypeElement(value) : null;
    }

    private MotorcycleChassisTypeElement? TransformMotorcycleChassisType(DecodeDbResult[] result)
    {
        return result.TryGetValue(MotorcycleChassisTypeElement.Code, out var value) ? new MotorcycleChassisTypeElement(value) : null;
    }

    private OtherMotorcycleInfoElement? TransformOtherMotorcycleInfo(DecodeDbResult[] result)
    {
        return result.TryGetValue(OtherMotorcycleInfoElement.Code, out var value) ? new OtherMotorcycleInfoElement(value) : null;
    }
}