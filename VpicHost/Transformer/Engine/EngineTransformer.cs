using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Engine;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Engine;

public class EngineTransformer
{
    public EngineGroup Transform(DecodeDbResult[] result)
    {
        return new EngineGroup
        {
            EngineCylinders = TransformEngineCylinders(result),
            DisplacementCc = TransformDisplacementCc(result),
            DisplacementCi = TransformDisplacementCi(result),
            DisplacementL = TransformDisplacementL(result),
            EngineCycles = TransformEngineCycles(result),
            EngineModel = TransformEngineModel(result),
            EngineKw = TransformEngineKw(result),
            FuelTypePrimary = TransformFuelTypePrimary(result),
            ValveTrainDesign = TransformValveTrainDesign(result),
            EngineConfiguration = TransformEngineConfiguration(result),
            FuelTypeSecondary = TransformFuelTypeSecondary(result),
            FuelInjectionType = TransformFuelInjectionType(result),
            EngineHp = TransformEngineHp(result),
            CoolingType = TransformCoolingType(result),
            EngineHpTo = TransformEngineHpTo(result),
            ElectrificationLevel = TransformElectrificationLevel(result),
            OtherEngineInfo = TransformOtherEngineInfo(result),
            Turbo = TransformTurbo(result),
            TopSpeedMph = TransformTopSpeedMph(result),
            EngineManufacturer = TransformEngineManufacturer(result)
        };
    }
    

    private EngineCylindersElement? TransformEngineCylinders(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineCylindersElement.Code, out var value) ? new EngineCylindersElement(value) : null;
    }

    private DisplacementCcElement? TransformDisplacementCc(DecodeDbResult[] result)
    {
        return result.TryGetValue(DisplacementCcElement.Code, out var value) ? new DisplacementCcElement(value) : null;
    }

    private DisplacementCiElement? TransformDisplacementCi(DecodeDbResult[] result)
    {
        return result.TryGetValue(DisplacementCiElement.Code, out var value) ? new DisplacementCiElement(value) : null;
    }

    private DisplacementLElement? TransformDisplacementL(DecodeDbResult[] result)
    {
        return result.TryGetValue(DisplacementLElement.Code, out var value) ? new DisplacementLElement(value) : null;
    }

    private EngineCyclesElement? TransformEngineCycles(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineCyclesElement.Code, out var value) ? new EngineCyclesElement(value) : null;
    }

    private EngineModelElement? TransformEngineModel(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineModelElement.Code, out var value) ? new EngineModelElement(value) : null;
    }

    private EngineKwElement? TransformEngineKw(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineKwElement.Code, out var value) ? new EngineKwElement(value) : null;
    }

    private FuelTypePrimaryElement? TransformFuelTypePrimary(DecodeDbResult[] result)
    {
        return result.TryGetValue(FuelTypePrimaryElement.Code, out var value) ? new FuelTypePrimaryElement(value) : null;
    }

    private ValveTrainDesignElement? TransformValveTrainDesign(DecodeDbResult[] result)
    {
        return result.TryGetValue(ValveTrainDesignElement.Code, out var value) ? new ValveTrainDesignElement(value) : null;
    }

    private EngineConfigurationElement? TransformEngineConfiguration(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineConfigurationElement.Code, out var value) ? new EngineConfigurationElement(value) : null;
    }

    private FuelTypeSecondaryElement? TransformFuelTypeSecondary(DecodeDbResult[] result)
    {
        return result.TryGetValue(FuelTypeSecondaryElement.Code, out var value) ? new FuelTypeSecondaryElement(value) : null;
    }

    private FuelInjectionTypeElement? TransformFuelInjectionType(DecodeDbResult[] result)
    {
        return result.TryGetValue(FuelInjectionTypeElement.Code, out var value) ? new FuelInjectionTypeElement(value) : null;
    }

    private EngineHpElement? TransformEngineHp(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineHpElement.Code, out var value) ? new EngineHpElement(value) : null;
    }

    private CoolingTypeElement? TransformCoolingType(DecodeDbResult[] result)
    {
        return result.TryGetValue(CoolingTypeElement.Code, out var value) ? new CoolingTypeElement(value) : null;
    }

    private EngineHpToElement? TransformEngineHpTo(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineHpToElement.Code, out var value) ? new EngineHpToElement(value) : null;
    }

    private ElectrificationLevelElement? TransformElectrificationLevel(DecodeDbResult[] result)
    {
        return result.TryGetValue(ElectrificationLevelElement.Code, out var value) ? new ElectrificationLevelElement(value) : null;
    }

    private OtherEngineInfoElement? TransformOtherEngineInfo(DecodeDbResult[] result)
    {
        return result.TryGetValue(OtherEngineInfoElement.Code, out var value) ? new OtherEngineInfoElement(value) : null;
    }

    private TurboElement? TransformTurbo(DecodeDbResult[] result)
    {
        return result.TryGetValue(TurboElement.Code, out var value) ? new TurboElement(value) : null;
    }

    private TopSpeedMphElement? TransformTopSpeedMph(DecodeDbResult[] result)
    {
        return result.TryGetValue(TopSpeedMphElement.Code, out var value) ? new TopSpeedMphElement(value) : null;
    }

    private EngineManufacturerElement? TransformEngineManufacturer(DecodeDbResult[] result)
    {
        return result.TryGetValue(EngineManufacturerElement.Code, out var value) ? new EngineManufacturerElement(value) : null;
    }
}