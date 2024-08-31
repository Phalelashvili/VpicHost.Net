namespace VpicHost.Models.Groups.Exterior;

public class ExteriorGroup
{
    public BodyGroup? Body { get; init; } 
    public BusGroup? Bus { get; init; } 
    public DimensionGroup? Dimension { get; init; } 
    public MotorcycleGroup? Motorcycle { get; init; } 
    public TrailerGroup? Trailer { get; init; } 
    public TruckGroup? Truck { get; init; } 
    public WheeltireGroup? Wheeltire { get; init; } 
}