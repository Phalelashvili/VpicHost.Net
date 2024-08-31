using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Mechanical;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Mechanical;

public class BatteryTransformer
{
    public BatteryGroup Transform(DecodeDbResult[] result)
    {
        return new BatteryGroup
        {
            BatteryInfo = TransformBatteryInfo(result),
            BatteryType = TransformBatteryType(result),
            BatteryCells = TransformBatteryCells(result),
            BatteryA = TransformBatteryA(result),
            BatteryV = TransformBatteryV(result),
            BatteryKWh = TransformBatteryKWh(result),
            EvDriveUnit = TransformEvDriveUnit(result),
            BatteryATo = TransformBatteryATo(result),
            BatteryVTo = TransformBatteryVTo(result),
            BatteryKWhTo = BatteryKWhTo(result),
            BatteryModules = TransformBatteryModules(result),
            BatteryPacks = TransformBatteryPacks(result)
        };
    }
    

    private BatteryInfoElement? TransformBatteryInfo(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryInfoElement.Code, out var value) ? new BatteryInfoElement(value) : null;
    }

    private BatteryTypeElement? TransformBatteryType(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryTypeElement.Code, out var value) ? new BatteryTypeElement(value) : null;
    }

    private BatteryCellsElement? TransformBatteryCells(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryCellsElement.Code, out var value) ? new BatteryCellsElement(value) : null;
    }

    private BatteryAElement? TransformBatteryA(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryAElement.Code, out var value) ? new BatteryAElement(value) : null;
    }

    private BatteryVElement? TransformBatteryV(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryVElement.Code, out var value) ? new BatteryVElement(value) : null;
    }

    private BatteryKWhElement? TransformBatteryKWh(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryKWhElement.Code, out var value) ? new BatteryKWhElement(value) : null;
    }

    private EvDriveUnitElement? TransformEvDriveUnit(DecodeDbResult[] result)
    {
        return result.TryGetValue(EvDriveUnitElement.Code, out var value) ? new EvDriveUnitElement(value) : null;
    }

    private BatteryAToElement? TransformBatteryATo(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryAToElement.Code, out var value) ? new BatteryAToElement(value) : null;
    }

    private BatteryVToElement? TransformBatteryVTo(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryVToElement.Code, out var value) ? new BatteryVToElement(value) : null;
    }

    private BatteryKWhToElement? BatteryKWhTo(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryKWhToElement.Code, out var value) ? new BatteryKWhToElement(value) : null;
    }

    private BatteryModulesElement? TransformBatteryModules(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryModulesElement.Code, out var value) ? new BatteryModulesElement(value) : null;
    }

    private BatteryPacksElement? TransformBatteryPacks(DecodeDbResult[] result)
    {
        return result.TryGetValue(BatteryPacksElement.Code, out var value) ? new BatteryPacksElement(value) : null;
    }
}