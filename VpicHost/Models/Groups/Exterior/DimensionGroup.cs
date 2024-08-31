namespace VpicHost.Models.Groups.Exterior;

public class DimensionGroup
{
    public GvwrElement? Gvwr { get; init; }
    public BedLengthInElement? BedLengthIn { get; init; }
    public CurbWeightLbElement? CurbWeightLb { get; init; }
    public WheelBaseShortElement? WheelBaseShort { get; init; }
    public WheelBaseLongElement? WheelBaseLong { get; init; }
    public GcwrElement? Gcwr { get; init; }
    public GcwrToElement? GcwrTo { get; init; }
    public GvwrToElement? GvwrTo { get; init; }
}