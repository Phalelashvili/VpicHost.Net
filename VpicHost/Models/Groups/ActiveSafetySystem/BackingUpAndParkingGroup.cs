namespace VpicHost.Models.Groups.ActiveSafetySystem;

public class BackingUpAndParkingGroup
{
    public RearVisibilitySystemElement? RearVisibilitySystem { get; init; }
    public ParkAssistElement? ParkAssist { get; init; }
    public RearCrossTrafficAlertElement? RearCrossTrafficAlert { get; init; }
    public RearAutomaticEmergencyBrakingElement? RearAutomaticEmergencyBraking { get; init; }
}