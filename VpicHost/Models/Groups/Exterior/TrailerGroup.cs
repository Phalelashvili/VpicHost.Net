namespace VpicHost.Models.Groups.Exterior;

public class TrailerGroup
{
    public TrailerTypeElement? TrailerType { get; init; }
    public TrailerBodyTypeElement? TrailerBodyType { get; init; }
    public TrailerLengthElement? TrailerLength { get; init; }
    public OtherTrailerInfoElement? OtherTrailerInfo { get; init; }
}