namespace VpicHost.Database;

public class DecodeDbResult
{
    public string GroupName { get; init; }
    public string Variable { get; init; }
    public string Value { get; init; }
    public int PatternId { get; init; }
    public int VinSchemaId { get; init; }
    public string Keys { get; init; }
    public int ElementId { get; init; }
    public string AttributeId { get; init; }
    public DateTime CreatedOn { get; init; }
    public int WmiId { get; init; }
    public string Code { get; init; }
    public string DataType { get; init; }
    public string Decode { get; init; }
    public string Source { get; init; }
    public bool ToBeQCd { get; init; }
}