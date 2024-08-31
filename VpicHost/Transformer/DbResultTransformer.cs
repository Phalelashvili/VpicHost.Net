using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Models.Groups.Engine;
using VpicHost.Models.Groups.Exterior;
using VpicHost.Models.Groups.General;
using VpicHost.Models.Groups.Interior;
using VpicHost.Models.Groups.Mechanical;
using VpicHost.Models.Groups.PassiveSafetySystem;
using VpicHost.Transformer.ActiveSafetySystem;
using VpicHost.Transformer.Engine;
using VpicHost.Transformer.Extensions;
using VpicHost.Transformer.Exterior;
using VpicHost.Transformer.General;
using VpicHost.Transformer.Interior;
using VpicHost.Transformer.Mechanical;
using VpicHost.Transformer.PassiveSafetySystem;

namespace VpicHost.Transformer;

public class DbResultTransformer
{
    public DecodedVin Transform(DecodeDbResult[] result)
    {
        return new DecodedVin
        {
            Country = TransformCountry(result),
            NcicCode = TransformNcicCode(result),
            EquipmentType = TransformEquipmentType(result),
            ManufacturerType = TransformManufacturerType(result),
            SuggestedVin = TransformSuggestedVin(result),
            ErrorCode = TransformErrorCode(result),
            PossibleValues = TransformPossibleValues(result),
            AdditionalErrorText = TransformAdditionalErrorText(result),
            ErrorText = TransformErrorText(result),
            VehicleDescriptor = TransformVehicleDescriptor(result),

            ActiveSafety = TransformActiveSafety(result),
            Engine = TransformEngine(result),
            Exterior = TransformExterior(result),
            General = TransformGeneral(result),
            Interior = TransformInterior(result),
            Mechanical = TransformMechanical(result),
            PassiveSafety = TransformPassiveSafety(result)
        };
    }

    private CountryElement? TransformCountry(DecodeDbResult[] result)
    {
        return result.TryGetValue(CountryElement.Code, out var value) ? new CountryElement(value) : null;
    }

    private NcicCodeElement? TransformNcicCode(DecodeDbResult[] result)
    {
        return result.TryGetValue(NcicCodeElement.Code, out var value) ? new NcicCodeElement(value) : null;
    }

    private EquipmentTypeElement? TransformEquipmentType(DecodeDbResult[] result)
    {
        return result.TryGetValue(EquipmentTypeElement.Code, out var value) ? new EquipmentTypeElement(value) : null;
    }

    private ManufacturerTypeElement? TransformManufacturerType(DecodeDbResult[] result)
    {
        return result.TryGetValue(ManufacturerTypeElement.Code, out var value) ? new ManufacturerTypeElement(value) : null;
    }

    private SuggestedVinElement? TransformSuggestedVin(DecodeDbResult[] result)
    {
        return result.TryGetValue(SuggestedVinElement.Code, out var value) ? new SuggestedVinElement(value) : null;
    }

    private ErrorCodeElement? TransformErrorCode(DecodeDbResult[] result)
    {
        return result.TryGetValue(ErrorCodeElement.Code, out var value) ? new ErrorCodeElement(value) : null;
    }

    private PossibleValuesElement? TransformPossibleValues(DecodeDbResult[] result)
    {
        return result.TryGetValue(PossibleValuesElement.Code, out var value) ? new PossibleValuesElement(value) : null;
    }

    private AdditionalErrorTextElement? TransformAdditionalErrorText(DecodeDbResult[] result)
    {
        return result.TryGetValue(AdditionalErrorTextElement.Code, out var value) ? new AdditionalErrorTextElement(value) : null;
    }

    private ErrorTextElement? TransformErrorText(DecodeDbResult[] result)
    {
        return result.TryGetValue(ErrorTextElement.Code, out var value) ? new ErrorTextElement(value) : null;
    }

    private VehicleDescriptorElement? TransformVehicleDescriptor(DecodeDbResult[] result)
    {
        return result.TryGetValue(VehicleDescriptorElement.Code, out var value) ? new VehicleDescriptorElement(value) : null;
    }

    private ActiveSafetySystemGroup TransformActiveSafety(DecodeDbResult[] result)
    {
        return new ActiveSafetySystemTransformer().Transform(result);
    }

    private EngineGroup TransformEngine(DecodeDbResult[] result)
    {
        return new EngineTransformer().Transform(result);
    }

    private ExteriorGroup TransformExterior(DecodeDbResult[] result)
    {
        return new ExteriorTransformer().Transform(result);
    }

    private GeneralGroup TransformGeneral(DecodeDbResult[] result)
    {
        return new GeneralTransformer().Transform(result);
    }

    private InteriorGroup TransformInterior(DecodeDbResult[] result)
    {
        return new InteriorTransformer().Transform(result);
    }

    private MechanicalGroup TransformMechanical(DecodeDbResult[] result)
    {
        return new MechanicalTransformer().Transform(result);
    }

    private PassiveSafetySystemGroup? TransformPassiveSafety(DecodeDbResult[] result)
    {
        return new PassiveSafetySystemTransformer().Transform(result);
    }
}