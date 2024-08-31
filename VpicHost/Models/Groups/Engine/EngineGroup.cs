namespace VpicHost.Models.Groups.Engine;

public class EngineGroup
{
    public EngineCylindersElement? EngineCylinders { get; init; }
    public DisplacementCcElement? DisplacementCc { get; init; }
    public DisplacementCiElement? DisplacementCi { get; init; }
    public DisplacementLElement? DisplacementL { get; init; }
    public EngineCyclesElement? EngineCycles { get; init; }
    public EngineModelElement? EngineModel { get; init; }
    public EngineKwElement? EngineKw { get; init; }
    public FuelTypePrimaryElement? FuelTypePrimary { get; init; }
    public ValveTrainDesignElement? ValveTrainDesign { get; init; }
    public EngineConfigurationElement? EngineConfiguration { get; init; }
    public FuelTypeSecondaryElement? FuelTypeSecondary { get; init; }
    public FuelInjectionTypeElement? FuelInjectionType { get; init; }
    public EngineHpElement? EngineHp { get; init; }
    public CoolingTypeElement? CoolingType { get; init; }
    public EngineHpToElement? EngineHpTo { get; init; }
    public ElectrificationLevelElement? ElectrificationLevel { get; init; }
    public OtherEngineInfoElement? OtherEngineInfo { get; init; }
    public TurboElement? Turbo { get; init; }
    public TopSpeedMphElement? TopSpeedMph { get; init; }
    public EngineManufacturerElement? EngineManufacturer { get; init; }
}