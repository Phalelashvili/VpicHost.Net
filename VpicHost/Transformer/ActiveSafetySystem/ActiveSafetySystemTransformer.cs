using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.ActiveSafetySystem;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.ActiveSafetySystem;

public class ActiveSafetySystemTransformer
{
    public ActiveSafetySystemGroup Transform(DecodeDbResult[] result)
    {
        return new ActiveSafetySystemGroup
        {
            DriverAssist = TransformDriverAssist(result),
            AdaptiveHeadlights = TransformAdaptiveHeadlights(result),
            Abs = TransformAbs(result),
            Esc = TransformEsc(result),
            TractionControl = TransformTractionControl(result),
            Tpms = TransformTpms(result),
            ActiveSafetySysNote = TransformActiveSafetySysNote(result),
            AutoReverseSystem = TransformAutoReverseSystem(result),
            AutomaticPedestrianAlertingSound = TransformAutomaticPedestrianAlertingSound(result),
            Edr = TransformEdr(result),
            KeylessIgnition = TransformKeylessIgnition(result),
            SaeAutomationLevel = TransformSaeAutomationLevel(result),
            SaeAutomationLevelTo = TransformSaeAutomationLevelTo(result),
            
            Notification911 = new Notification911Transformer().Transform(result),
            BackingUpAndParking = new BackingUpAndParkingTransformer().Transform(result),
            ForwardCollisionPrevention = new ForwardCollisionPreventionTransformer().Transform(result),
            LaneandSideAssist = new LaneAndSideAssistTransformer().Transform(result),
            LightingTechnologies = new LightingTechnologiesTransformer().Transform(result),
            MaintainingSafeDistance = new MaintainingSafeDistanceTransformer().Transform(result)
        };
    }
    

    private DriverAssistElement? TransformDriverAssist(DecodeDbResult[] result)
    {
        return result.TryGetValue(DriverAssistElement.Code, out var value) ? new DriverAssistElement(value) : null;
    }

    private AdaptiveHeadlightsElement? TransformAdaptiveHeadlights(DecodeDbResult[] result)
    {
        return result.TryGetValue(AdaptiveHeadlightsElement.Code, out var value) ? new AdaptiveHeadlightsElement(value) : null;
    }

    private AbsElement? TransformAbs(DecodeDbResult[] result)
    {
        return result.TryGetValue(AbsElement.Code, out var value) ? new AbsElement(value) : null;
    }

    private EscElement? TransformEsc(DecodeDbResult[] result)
    {
        return result.TryGetValue(EscElement.Code, out var value) ? new EscElement(value) : null;
    }

    private TractionControlElement? TransformTractionControl(DecodeDbResult[] result)
    {
        return result.TryGetValue(TractionControlElement.Code, out var value) ? new TractionControlElement(value) : null;
    }

    private TpmsElement? TransformTpms(DecodeDbResult[] result)
    {
        return result.TryGetValue(TpmsElement.Code, out var value) ? new TpmsElement(value) : null;
    }

    private ActiveSafetySysNoteElement? TransformActiveSafetySysNote(DecodeDbResult[] result)
    {
        return result.TryGetValue(ActiveSafetySysNoteElement.Code, out var value) ? new ActiveSafetySysNoteElement(value) : null;
    }

    private AutoReverseSystemElement? TransformAutoReverseSystem(DecodeDbResult[] result)
    {
        return result.TryGetValue(AutoReverseSystemElement.Code, out var value) ? new AutoReverseSystemElement(value) : null;
    }

    private AutomaticPedestrianAlertingSoundElement? TransformAutomaticPedestrianAlertingSound(DecodeDbResult[] result)
    {
        return result.TryGetValue(AutomaticPedestrianAlertingSoundElement.Code, out var value) ? new AutomaticPedestrianAlertingSoundElement(value) : null;
    }

    private EdrElement? TransformEdr(DecodeDbResult[] result)
    {
        return result.TryGetValue(EdrElement.Code, out var value) ? new EdrElement(value) : null;
    }

    private KeylessIgnitionElement? TransformKeylessIgnition(DecodeDbResult[] result)
    {
        return result.TryGetValue(KeylessIgnitionElement.Code, out var value) ? new KeylessIgnitionElement(value) : null;
    }

    private SaeAutomationLevelElement? TransformSaeAutomationLevel(DecodeDbResult[] result)
    {
        return result.TryGetValue(SaeAutomationLevelElement.Code, out var value) ? new SaeAutomationLevelElement(value) : null;
    }

    private SaeAutomationLevelToElement? TransformSaeAutomationLevelTo(DecodeDbResult[] result)
    {
        return result.TryGetValue(SaeAutomationLevelToElement.Code, out var value) ? new SaeAutomationLevelToElement(value) : null;
    }
}