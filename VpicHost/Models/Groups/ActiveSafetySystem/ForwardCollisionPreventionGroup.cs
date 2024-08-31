namespace VpicHost.Models.Groups.ActiveSafetySystem;

public class ForwardCollisionPreventionGroup
{
    public CibElement? Cib { get; init; }
    public ForwardCollisionWarningElement? ForwardCollisionWarning { get; init; }
    public DynamicBrakeSupportElement? DynamicBrakeSupport { get; init; }
    public PedestrianAutomaticEmergencyBrakingElement? PedestrianAutomaticEmergencyBraking { get; init; }
}