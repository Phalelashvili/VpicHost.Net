namespace VpicHost.Models.Groups.ActiveSafetySystem;

public class LightingTechnologiesGroup
{
    public DaytimeRunningLightElement? DaytimeRunningLight { get; init; }
    public LowerBeamHeadlampLightSourceElement? LowerBeamHeadlampLightSource { get; init; }
    public SemiautomaticHeadlampBeamSwitchingElement? SemiautomaticHeadlampBeamSwitching { get; init; }
    public AdaptiveDrivingBeamElement? AdaptiveDrivingBeam { get; init; }
}