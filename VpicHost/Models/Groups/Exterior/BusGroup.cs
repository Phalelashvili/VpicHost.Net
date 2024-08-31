namespace VpicHost.Models.Groups.Exterior;

public class BusGroup
{
    public BusLengthElement? BusLength { get; init; }
    public BusFloorConfigTypeElement? BusFloorConfigType { get; init; }
    public BusTypeElement? BusType { get; init; }
    public OtherBusInfoElement? OtherBusInfo { get; init; }
}