namespace VpicHost.Models.Groups.Exterior;

public class BodyGroup
{
    public BodyClassElement? BodyClass { get; init; }
    public DoorsElement? Doors { get; init; }
    public WindowsElement? Windows { get; init; }
    public WheelBaseTypeElement? WheelBaseType { get; init; }
    public TrackWidthElement? TrackWidth { get; init; }
}