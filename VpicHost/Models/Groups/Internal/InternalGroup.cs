namespace VpicHost.Models.Groups.Internal;

public class InternalGroup
{
    public NcsaBodyTypeElement? NcsaBodyType { get; init; }
    public NcsaMakeElement? NcsaMake { get; init; }
    public NcsaModelElement? NcsaModel { get; init; }
    public NcsaNoteElement? NcsaNote { get; init; }
    public NcsaMappingExceptionElement? NcsaMappingException { get; init; }
    public NcsaMapExcApprovedOnElement? NcsaMapExcApprovedOn { get; init; }
    public NcsaMapExcApprovedByElement? NcsaMapExcApprovedBy { get; init; }
}