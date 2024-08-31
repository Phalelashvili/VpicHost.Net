namespace VpicHost.Models.Groups.Mechanical;

public class MechanicalGroup
{
    public BatteryGroup? Battery { get; init; }
    public BrakeGroup? Brake { get; init; }
    public DrivetrainGroup? Drivetrain { get; init; }
    public TransmissionGroup? Transmission { get; init; }
}