using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.ActiveSafetySystem;

public class ForwardCollisionPreventionTransformer
{
    public ForwardCollisionPreventionGroup Transform(DecodeDbResult[] result)
    {
        return new ForwardCollisionPreventionGroup
        {
            Cib = TransformCib(result),
            ForwardCollisionWarning = TransformForwardCollisionWarning(result),
            DynamicBrakeSupport = TransformDynamicBrakeSupport(result),
            PedestrianAutomaticEmergencyBraking = TransformPedestrianAutomaticEmergencyBraking(result)
        };
    }
    

    private CibElement? TransformCib(DecodeDbResult[] result)
    {
        return result.TryGetValue(CibElement.Code, out var value) ? new CibElement(value) : null;
    }

    private ForwardCollisionWarningElement? TransformForwardCollisionWarning(DecodeDbResult[] result)
    {
        return result.TryGetValue(ForwardCollisionWarningElement.Code, out var value) ? new ForwardCollisionWarningElement(value) : null;
    }

    private DynamicBrakeSupportElement? TransformDynamicBrakeSupport(DecodeDbResult[] result)
    {
        return result.TryGetValue(DynamicBrakeSupportElement.Code, out var value) ? new DynamicBrakeSupportElement(value) : null;
    }

    private PedestrianAutomaticEmergencyBrakingElement? TransformPedestrianAutomaticEmergencyBraking(DecodeDbResult[] result)
    {
        return result.TryGetValue(PedestrianAutomaticEmergencyBrakingElement.Code, out var value) ? new PedestrianAutomaticEmergencyBrakingElement(value) : null;
    }
}