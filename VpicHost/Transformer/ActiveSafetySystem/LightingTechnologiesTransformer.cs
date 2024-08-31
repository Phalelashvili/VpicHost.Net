using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.ActiveSafetySystem;

public class LightingTechnologiesTransformer
{
    public LightingTechnologiesGroup Transform(DecodeDbResult[] result)
    {
        return new LightingTechnologiesGroup
        {
            DaytimeRunningLight = TransformDaytimeRunningLight(result),
            LowerBeamHeadlampLightSource = TransformLowerBeamHeadlampLightSource(result),
            SemiautomaticHeadlampBeamSwitching = TransformSemiautomaticHeadlampBeamSwitching(result),
            AdaptiveDrivingBeam = TransformAdaptiveDrivingBeam(result)
        };
    }
    

    private DaytimeRunningLightElement? TransformDaytimeRunningLight(DecodeDbResult[] result)
    {
        return result.TryGetValue(DaytimeRunningLightElement.Code, out var value) ? new DaytimeRunningLightElement(value) : null;
    }

    private LowerBeamHeadlampLightSourceElement? TransformLowerBeamHeadlampLightSource(DecodeDbResult[] result)
    {
        return result.TryGetValue(LowerBeamHeadlampLightSourceElement.Code, out var value) ? new LowerBeamHeadlampLightSourceElement(value) : null;
    }

    private SemiautomaticHeadlampBeamSwitchingElement? TransformSemiautomaticHeadlampBeamSwitching(DecodeDbResult[] result)
    {
        return result.TryGetValue(SemiautomaticHeadlampBeamSwitchingElement.Code, out var value) ? new SemiautomaticHeadlampBeamSwitchingElement(value) : null;
    }

    private AdaptiveDrivingBeamElement? TransformAdaptiveDrivingBeam(DecodeDbResult[] result)
    {
        return result.TryGetValue(AdaptiveDrivingBeamElement.Code, out var value) ? new AdaptiveDrivingBeamElement(value) : null;
    }
}