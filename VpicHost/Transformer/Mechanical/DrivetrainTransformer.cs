using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Mechanical;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Mechanical;

public class DrivetrainTransformer
{
    public DrivetrainGroup Transform(DecodeDbResult[] result)
    {
        return new DrivetrainGroup
        {
            DriveType = TransformDriveType(result),
            Axles = TransformAxles(result),
            AxleConfiguration = TransformAxleConfiguration(result)
        };
    }
    

    private DriveTypeElement? TransformDriveType(DecodeDbResult[] result)
    {
        return result.TryGetValue(DriveTypeElement.Code, out var value) ? new DriveTypeElement(value) : null;
    }

    private AxlesElement? TransformAxles(DecodeDbResult[] result)
    {
        return result.TryGetValue(AxlesElement.Code, out var value) ? new AxlesElement(value) : null;
    }

    private AxleConfigurationElement? TransformAxleConfiguration(DecodeDbResult[] result)
    {
        return result.TryGetValue(AxleConfigurationElement.Code, out var value) ? new AxleConfigurationElement(value) : null;
    }
}