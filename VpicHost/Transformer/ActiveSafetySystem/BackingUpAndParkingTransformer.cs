using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.ActiveSafetySystem;

public class BackingUpAndParkingTransformer
{
    public BackingUpAndParkingGroup Transform(DecodeDbResult[] result)
    {
        return new BackingUpAndParkingGroup
        {
            RearVisibilitySystem = TransformRearVisibilitySystem(result),
            ParkAssist = TransformParkAssist(result),
            RearCrossTrafficAlert = TransformRearCrossTrafficAlert(result),
            RearAutomaticEmergencyBraking = TransformRearAutomaticEmergencyBraking(result)
        };
    }
    

    private RearVisibilitySystemElement? TransformRearVisibilitySystem(DecodeDbResult[] result)
    {
        return result.TryGetValue(RearVisibilitySystemElement.Code, out var value) ? new RearVisibilitySystemElement(value) : null;
    }

    private ParkAssistElement? TransformParkAssist(DecodeDbResult[] result)
    {
        return result.TryGetValue(ParkAssistElement.Code, out var value) ? new ParkAssistElement(value) : null;
    }

    private RearCrossTrafficAlertElement? TransformRearCrossTrafficAlert(DecodeDbResult[] result)
    {
        return result.TryGetValue(RearCrossTrafficAlertElement.Code, out var value) ? new RearCrossTrafficAlertElement(value) : null;
    }

    private RearAutomaticEmergencyBrakingElement? TransformRearAutomaticEmergencyBraking(DecodeDbResult[] result)
    {
        return result.TryGetValue(RearAutomaticEmergencyBrakingElement.Code, out var value) ? new RearAutomaticEmergencyBrakingElement(value) : null;
    }
}