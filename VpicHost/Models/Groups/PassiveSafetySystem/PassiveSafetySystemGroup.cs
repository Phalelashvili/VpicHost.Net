namespace VpicHost.Models.Groups.PassiveSafetySystem;

public class PassiveSafetySystemGroup
{
    public PretensionerElement? Pretensioner { get; init; }
    public SeatBeltsAllElement? SeatBeltsAll { get; init; }
    public OtherRestraintSystemInfoElement? OtherRestraintSystemInfo { get; init; }
}