using VpicHost.Database;
using VpicHost.Models;
using VpicHost.Models.Groups.General;
using VpicHost.Transformer.Extensions;

namespace VpicHost.Transformer.General;

public class GeneralTransformer
{
    public GeneralGroup Transform(DecodeDbResult[] result)
    {
        return new GeneralGroup
        {
            DestinationMarket = TransformDestinationMarket(result),
            Make = TransformMake(result),
            Manufacturer = TransformManufacturer(result),
            Model = TransformModel(result),
            ModelYear = TransformModelYear(result),
            PlantCity = TransformPlantCity(result),
            Series = TransformSeries(result),
            Trim = TransformTrim(result),
            VehicleType = TransformVehicleType(result),
            PlantCountry = TransformPlantCountry(result),
            PlantCompanyName = TransformPlantCompanyName(result),
            PlantState = TransformPlantState(result),
            Trim2 = TransformTrim2(result),
            Series2 = TransformSeries2(result),
            Note = TransformNote(result),
            BasePrice = TransformBasePrice(result),
            CashForClunkers = TransformCashForClunkers(result),
            NonLandUse = TransformNonLandUse(result)
        };
    }
    

    private DestinationMarketElement? TransformDestinationMarket(DecodeDbResult[] result)
    {
        return result.TryGetValue(DestinationMarketElement.Code, out var value) ? new DestinationMarketElement(value) : null;
    }

    private MakeElement? TransformMake(DecodeDbResult[] result)
    {
        return result.TryGetValue(MakeElement.Code, out var value) ? new MakeElement(value) : null;
    }

    private ManufacturerElement? TransformManufacturer(DecodeDbResult[] result)
    {
        return result.TryGetValue(ManufacturerElement.Code, out var value) ? new ManufacturerElement(value) : null;
    }

    private ModelElement? TransformModel(DecodeDbResult[] result)
    {
        return result.TryGetValue(ModelElement.Code, out var value) ? new ModelElement(value) : null;
    }

    private ModelYearElement? TransformModelYear(DecodeDbResult[] result)
    {
        return result.TryGetValue(ModelYearElement.Code, out var value) ? new ModelYearElement(value) : null;
    }

    private PlantCityElement? TransformPlantCity(DecodeDbResult[] result)
    {
        return result.TryGetValue(PlantCityElement.Code, out var value) ? new PlantCityElement(value) : null;
    }

    private SeriesElement? TransformSeries(DecodeDbResult[] result)
    {
        return result.TryGetValue(SeriesElement.Code, out var value) ? new SeriesElement(value) : null;
    }

    private TrimElement? TransformTrim(DecodeDbResult[] result)
    {
        return result.TryGetValue(TrimElement.Code, out var value) ? new TrimElement(value) : null;
    }

    private VehicleTypeElement? TransformVehicleType(DecodeDbResult[] result)
    {
        return result.TryGetValue(VehicleTypeElement.Code, out var value) ? new VehicleTypeElement(value) : null;
    }

    private PlantCountryElement? TransformPlantCountry(DecodeDbResult[] result)
    {
        return result.TryGetValue(PlantCountryElement.Code, out var value) ? new PlantCountryElement(value) : null;
    }

    private PlantCompanyNameElement? TransformPlantCompanyName(DecodeDbResult[] result)
    {
        return result.TryGetValue(PlantCompanyNameElement.Code, out var value) ? new PlantCompanyNameElement(value) : null;
    }

    private PlantStateElement? TransformPlantState(DecodeDbResult[] result)
    {
        return result.TryGetValue(PlantStateElement.Code, out var value) ? new PlantStateElement(value) : null;
    }

    private Trim2Element? TransformTrim2(DecodeDbResult[] result)
    {
        return result.TryGetValue(Trim2Element.Code, out var value) ? new Trim2Element(value) : null;
    }

    private Series2Element? TransformSeries2(DecodeDbResult[] result)
    {
        return result.TryGetValue(Series2Element.Code, out var value) ? new Series2Element(value) : null;
    }

    private NoteElement? TransformNote(DecodeDbResult[] result)
    {
        return result.TryGetValue(NoteElement.Code, out var value) ? new NoteElement(value) : null;
    }

    private BasePriceElement? TransformBasePrice(DecodeDbResult[] result)
    {
        return result.TryGetValue(BasePriceElement.Code, out var value) ? new BasePriceElement(value) : null;
    }

    private CashForClunkersElement? TransformCashForClunkers(DecodeDbResult[] result)
    {
        return result.TryGetValue(CashForClunkersElement.Code, out var value) ? new CashForClunkersElement(value) : null;
    }

    private NonLandUseElement? TransformNonLandUse(DecodeDbResult[] result)
    {
        return result.TryGetValue(NonLandUseElement.Code, out var value) ? new NonLandUseElement(value) : null;
    }
}