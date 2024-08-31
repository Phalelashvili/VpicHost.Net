using VpicHost.Database;
using VpicHost.Models.Groups.Exterior;

namespace VpicHost.Transformer.Exterior;

public class ExteriorTransformer
{
    public ExteriorGroup Transform(DecodeDbResult[] result)
    {
        return new ExteriorGroup
        {
            Body = TransformBody(result),
            Bus = TransformBus(result),
            Dimension = TransformDimension(result),
            Motorcycle = TransformMotorcycle(result),
            Trailer = TransformTrailer(result),
            Truck = TransformTruck(result),
            Wheeltire = TransformWheeltire(result),
        };
    }

    private WheeltireGroup TransformWheeltire(DecodeDbResult[] result)
    {
        return new WheeltireTransformer().Transform(result);
    }

    private TruckGroup TransformTruck(DecodeDbResult[] result)
    {
        return new TruckTransformer().Transform(result);
    }

    private TrailerGroup TransformTrailer(DecodeDbResult[] result)
    {
        return new TrailerTransformer().Transform(result);
    }

    private MotorcycleGroup TransformMotorcycle(DecodeDbResult[] result)
    {
        return new MotorcycleTransformer().Transform(result);
    }

    private DimensionGroup TransformDimension(DecodeDbResult[] result)
    {
        return new DimensionTransformer().Transform(result);
    }

    private BusGroup TransformBus(DecodeDbResult[] result)
    {
        return new BusTransformer().Transform(result);
    }

    private BodyGroup TransformBody(DecodeDbResult[] result)
    {
        return new BodyTransformer().Transform(result);
    }
}