namespace VpicHost.Models.Groups.ActiveSafetySystem;

public class LaneAndSideAssistGroup
{
    public BlindSpotMonElement? BlindSpotMon { get; init; }
    public LaneDepartureWarningElement? LaneDepartureWarning { get; init; }
    public LaneKeepSystemElement? LaneKeepSystem { get; init; }
    public BlindSpotInterventionElement? BlindSpotIntervention { get; init; }
    public LaneCenteringAssistanceElement? LaneCenteringAssistance { get; init; }
}