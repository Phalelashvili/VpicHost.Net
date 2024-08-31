namespace VpicHost.Models.Groups.General;

public class GeneralGroup
{
    public DestinationMarketElement? DestinationMarket { get; init; }
    public MakeElement? Make { get; init; }
    public ManufacturerElement? Manufacturer { get; init; }
    public ModelElement? Model { get; init; }
    public ModelYearElement? ModelYear { get; init; }
    public PlantCityElement? PlantCity { get; init; }
    public SeriesElement? Series { get; init; }
    public TrimElement? Trim { get; init; }
    public VehicleTypeElement? VehicleType { get; init; }
    public PlantCountryElement? PlantCountry { get; init; }
    public PlantCompanyNameElement? PlantCompanyName { get; init; }
    public PlantStateElement? PlantState { get; init; }
    public Trim2Element? Trim2 { get; init; }
    public Series2Element? Series2 { get; init; }
    public NoteElement? Note { get; init; }
    public BasePriceElement? BasePrice { get; init; }
    public CashForClunkersElement? CashForClunkers { get; init; }
    public NonLandUseElement? NonLandUse { get; init; }
}