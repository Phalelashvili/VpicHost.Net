namespace VpicHost.Models.Groups.PassiveSafetySystem;

public class AirBagLocationGroup
{
    public AirBagLocCurtainElement? AirBagLocCurtain { get; init; }
    public AirBagLocSeatCushionElement? AirBagLocSeatCushion { get; init; }
    public AirBagLocFrontElement? AirBagLocFront { get; init; }
    public AirBagLocKneeElement? AirBagLocKnee { get; init; }
    public AirBagLocSideElement? AirBagLocSide { get; init; }
}