using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Models.Groups.Engine;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Models.Groups.General;
using VpicHost.Models.Groups.Interior;
using VpicHost.Models.Groups.Mechanical;
using VpicHost.Models.Groups.PassiveSafetySystem;

namespace VpicHost.Models;

public class DecodedVin
{
    public CountryElement? Country { get; init; }
    public NcicCodeElement? NcicCode { get; init; }
    public EquipmentTypeElement? EquipmentType { get; init; }
    public ManufacturerTypeElement? ManufacturerType { get; init; }
    public SuggestedVinElement? SuggestedVin { get; init; }
    public ErrorCodeElement? ErrorCode { get; init; }
    public PossibleValuesElement? PossibleValues { get; init; }
    public AdditionalErrorTextElement? AdditionalErrorText { get; init; }
    public ErrorTextElement? ErrorText { get; init; }
    public VehicleDescriptorElement? VehicleDescriptor { get; init; }
    
    public ActiveSafetySystemGroup? ActiveSafety { get; init; }
    public EngineGroup? Engine { get; init; }
    public ExteriorGroup? Exterior { get; init; }
    public GeneralGroup? General { get; init; }
    public InteriorGroup? Interior { get; init; }
    public MechanicalGroup? Mechanical { get; init; }
    public PassiveSafetySystemGroup? PassiveSafety { get; init; }
}