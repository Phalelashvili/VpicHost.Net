namespace VpicHost.Models.Groups.Mechanical;

public class DrivetrainGroup
{
    public DriveTypeElement? DriveType { get; init; }
    public AxlesElement? Axles { get; init; }
    public AxleConfigurationElement? AxleConfiguration { get; init; }
}