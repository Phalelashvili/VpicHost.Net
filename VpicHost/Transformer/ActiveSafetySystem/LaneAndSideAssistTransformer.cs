using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.ActiveSafetySystem;

public class LaneAndSideAssistTransformer
{
    public LaneAndSideAssistGroup Transform(DecodeDbResult[] result)
    {
        return new LaneAndSideAssistGroup
        {
            BlindSpotMon = TransformBlindSpotMon(result),
            LaneDepartureWarning = TransformLaneDepartureWarning(result),
            LaneKeepSystem = TransformLaneKeepSystem(result),
            BlindSpotIntervention = TransformBlindSpotIntervention(result),
            LaneCenteringAssistance = TransformLaneCenteringAssistance(result)
        };
    }
    

    private BlindSpotMonElement? TransformBlindSpotMon(DecodeDbResult[] result)
    {
        return result.TryGetValue(BlindSpotMonElement.Code, out var value) ? new BlindSpotMonElement(value) : null;
    }

    private LaneDepartureWarningElement? TransformLaneDepartureWarning(DecodeDbResult[] result)
    {
        return result.TryGetValue(LaneDepartureWarningElement.Code, out var value) ? new LaneDepartureWarningElement(value) : null;
    }

    private LaneKeepSystemElement? TransformLaneKeepSystem(DecodeDbResult[] result)
    {
        return result.TryGetValue(LaneKeepSystemElement.Code, out var value) ? new LaneKeepSystemElement(value) : null;
    }

    private BlindSpotInterventionElement? TransformBlindSpotIntervention(DecodeDbResult[] result)
    {
        return result.TryGetValue(BlindSpotInterventionElement.Code, out var value) ? new BlindSpotInterventionElement(value) : null;
    }

    private LaneCenteringAssistanceElement? TransformLaneCenteringAssistance(DecodeDbResult[] result)
    {
        return result.TryGetValue(LaneCenteringAssistanceElement.Code, out var value) ? new LaneCenteringAssistanceElement(value) : null;
    }
}