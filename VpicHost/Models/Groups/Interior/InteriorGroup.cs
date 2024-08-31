namespace VpicHost.Models.Groups.Interior;

public class InteriorGroup
{
    public EntertainmentSystemElement? EntertainmentSystem { get; init; }
    public SteeringLocationElement? SteeringLocation { get; init; }
    
    public SeatGroup? SeatGroup { get; init; }
}