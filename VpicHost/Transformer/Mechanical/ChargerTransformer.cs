using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.Mechanical;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.Mechanical;

public class ChargerTransformer
{
    public ChargerGroup Transform(DecodeDbResult[] result)
    {
        return new ChargerGroup
        {
            ChargerLevel = TransformChargerLevel(result),
            ChargerPowerKw = TransformChargerPowerKw(result)
        };
    }
    

    private ChargerLevelElement? TransformChargerLevel(DecodeDbResult[] result)
    {
        return result.TryGetValue(ChargerLevelElement.Code, out var value) ? new ChargerLevelElement(value) : null;
    }

    private ChargerPowerKwElement? TransformChargerPowerKw(DecodeDbResult[] result)
    {
        return result.TryGetValue(ChargerPowerKwElement.Code, out var value) ? new ChargerPowerKwElement(value) : null;
    }
}