namespace VpicHost.Models.Groups.Exterior;

public class MotorcycleGroup
{
    public CustomMotorcycleTypeElement? CustomMotorcycleType { get; init; }
    public MotorcycleSuspensionTypeElement? MotorcycleSuspensionType { get; init; }
    public MotorcycleChassisTypeElement? MotorcycleChassisType { get; init; }
    public OtherMotorcycleInfoElement? OtherMotorcycleInfo { get; init; }
}