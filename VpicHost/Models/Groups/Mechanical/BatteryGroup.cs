namespace VpicHost.Models.Groups.Mechanical;

public class BatteryGroup
{
    public BatteryInfoElement? BatteryInfo { get; init; }
    public BatteryTypeElement? BatteryType { get; init; }
    public BatteryCellsElement? BatteryCells { get; init; }
    public BatteryAElement? BatteryA { get; init; }
    public BatteryVElement? BatteryV { get; init; }
    public BatteryKWhElement? BatteryKWh { get; init; }
    public EvDriveUnitElement? EvDriveUnit { get; init; }
    public BatteryAToElement? BatteryATo { get; init; }
    public BatteryVToElement? BatteryVTo { get; init; }
    public BatteryKWhToElement? BatteryKWhTo { get; init; }
    public BatteryModulesElement? BatteryModules { get; init; }
    public BatteryPacksElement? BatteryPacks { get; init; }
}