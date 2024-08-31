namespace VpicHost.Models.Groups.ActiveSafetySystem;

public class ActiveSafetySystemGroup
{
    public DriverAssistElement? DriverAssist { get; init; }
    public AdaptiveHeadlightsElement? AdaptiveHeadlights { get; init; }
    public AbsElement? Abs { get; init; }
    public EscElement? Esc { get; init; }
    public TractionControlElement? TractionControl { get; init; }
    public TpmsElement? Tpms { get; init; }
    public ActiveSafetySysNoteElement? ActiveSafetySysNote { get; init; }
    public AutoReverseSystemElement? AutoReverseSystem { get; init; }
    public AutomaticPedestrianAlertingSoundElement? AutomaticPedestrianAlertingSound { get; init; }
    public EdrElement? Edr { get; init; }
    public KeylessIgnitionElement? KeylessIgnition { get; init; }
    public SaeAutomationLevelElement? SaeAutomationLevel { get; init; }
    public SaeAutomationLevelToElement? SaeAutomationLevelTo { get; init; }
    
    public Notification911Group? Notification911 { get; init; }
    public BackingUpAndParkingGroup? BackingUpAndParking { get; init; }
    public ForwardCollisionPreventionGroup? ForwardCollisionPrevention { get; init; }
    public LaneAndSideAssistGroup? LaneandSideAssist { get; init; }
    public LightingTechnologiesGroup? LightingTechnologies { get; init; }
    public MaintainingSafeDistanceGroup? MaintainingSafeDistance { get; init; }
}