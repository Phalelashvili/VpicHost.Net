using VpicHost.Database;
using VpicHost.Models.Groups.Mechanical;

namespace VpicHost.Transformer.Mechanical;

public class MechanicalTransformer
{
    public MechanicalGroup Transform(DecodeDbResult[] result)
    {
        return new MechanicalGroup
        {
            Battery = TransformBattery(result),
            Brake = TransformBrake(result),
            Drivetrain = TransformDrivetrain(result),
            Transmission = TransformTransmission(result)
        };
    }

    private BatteryGroup TransformBattery(DecodeDbResult[] result)
    {
        return new BatteryTransformer().Transform(result); 
    }

    private BrakeGroup TransformBrake(DecodeDbResult[] result)
    {
        return new BrakeTransformer().Transform(result);
    }

    private TransmissionGroup TransformTransmission(DecodeDbResult[] result)
    {
        return new TransmissionTransformer().Transform(result);
    }

    private DrivetrainGroup TransformDrivetrain(DecodeDbResult[] result)
    {
        return new DrivetrainTransformer().Transform(result);
    }
}