namespace VpicHost.Models;

public interface IElement
{
}

/// <summary>
/// Id: 1. Other Battery Info - This field stores any other battery information that does not belong to any of the other battery related fields.
/// </summary>
public readonly struct BatteryInfoElement(string value) : IElement
{
    public const string Code = "BatteryInfo";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 2. Battery Type - Battery type field stores the battery chemistry type for anode, cathode.
/// </summary>
public readonly struct BatteryTypeElement(string value) : IElement
{
    public const string Code = "BatteryType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 3. Bed Type - Bed type is the type of bed (the open back) used for pickup trucks. The common values are standard, short, long, extended.
/// </summary>
public readonly struct BedTypeElement(string value) : IElement
{
    public const string Code = "BedType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 4. Cab Type - Cab type applies to both pickup truck and other medium- and heavy-duty trucks. The cab or cabin of a truck is the inside space in a truck where the driver is seated. For pickup trucks, the cab type is categorized by the combination number of doors and number of rows for seating. For medium- and heavy-duty trucks (MDHD), the cab type is categorized by the relative location of engine and cab.For pickup trucks, there are four cab types.<ul><li>Regular: 2 door, 1 row of seats</li><li>Extra/Super/Quad/Double/King/Extended: 2 doors, 2 rows of seats</li><li>Crew/Super Crew/Crew Max: 4 doors, 2 rows of seats</li><li>Mega: 4 doors, 2 rows of seats (with a bigger cabin than crew cab type)</li></ul>For medium- and heavy-duty (MDHD) trucks, there are several categories as listed below.<ul><li>Cab Beside Engine</li><li>CAE: Cab Above Engine</li><li>CBE: Cab Behind Engine</li><li>COE: Cab Over Engine or Flat Nose: Driver sits on top of the front axle and engine</li><li>LCF: Low Cab Forward</li><li>Conventional: Driver sits behind the engine</li><li>Non-Tilt</li><li>Tilt</li></ul>
/// </summary>
public readonly struct BodyCabTypeElement(string value) : IElement
{
    public const string Code = "BodyCabType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 5. Body Class - Body Class presents the body type based on 49 CFR 565.12(b): "Body type means the general configuration or shape of a vehicle distinguished by such characteristics as the number of doors or windows, cargo-carrying features and the roofline (e.g., sedan, fastback, hatchback)." Definitions are not provided for individual body types in the regulation.
/// </summary>
public readonly struct BodyClassElement(string value) : IElement
{
    public const string Code = "BodyClass";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 8. Country Name - The country in which the manufacturer is located. This is taken from the WMI.
/// </summary>
public readonly struct CountryElement(string value) : IElement
{
    public const string Code = "Country";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 9. Engine Number of Cylinders - This is a numerical field to store the number of cylinders in an engine. Common values for passenger cars are 4 or 6.
/// </summary>
public readonly struct EngineCylindersElement(int value) : IElement
{
    public const string Code = "EngineCylinders";
    public int Value { get; init; } = value;

    public EngineCylindersElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 10. Destination Market - Destination Market is the market where the vehicle is intended to be sold.
/// </summary>
public readonly struct DestinationMarketElement(string value) : IElement
{
    public const string Code = "DestinationMarket";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 11. Displacement (CC) - Engine displacement (in cubic centimeters) is the volume swept by all the pistons inside the cylinders of a reciprocating engine in a single movement from top dead center to bottom dead center.
/// </summary>
public readonly struct DisplacementCcElement(decimal value) : IElement
{
    public const string Code = "DisplacementCC";
    public decimal Value { get; init; } = value;

    public DisplacementCcElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 12. Displacement (CI) - Engine displacement (in cubic inches) is the volume swept by all the pistons inside the cylinders of a reciprocating engine in a single movement from top dead center to bottom dead center.
/// </summary>
public readonly struct DisplacementCiElement(decimal value) : IElement
{
    public const string Code = "DisplacementCI";
    public decimal Value { get; init; } = value;

    public DisplacementCiElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 13. Displacement (L) - Engine displacement (in liters) is the volume swept by all the pistons inside the cylinders of a reciprocating engine in a single movement from top dead center to bottom dead center.
/// </summary>
public readonly struct DisplacementLElement(decimal value) : IElement
{
    public const string Code = "DisplacementL";
    public decimal Value { get; init; } = value;

    public DisplacementLElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 14. Doors - This is a numerical field to store the number of doors on a vehicle.
/// </summary>
public readonly struct DoorsElement(int value) : IElement
{
    public const string Code = "Doors";
    public int Value { get; init; } = value;

    public DoorsElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 15. Drive Type - Drive type stores information about vehicle drivetrain configuration. The most common drive types for passenger cars, crossover vehicles, and pickup trucks are front-wheel drive (FWD), rear-wheel drive (RWD), all-wheel drive (AWD), and 4-wheel drive (4WD).
/// </summary>
public readonly struct DriveTypeElement(string value) : IElement
{
    public const string Code = "DriveType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 16. Driver Assist - Advanced driver-assistance systems (ADAS) are systems developed to automate/adapt/enhance vehicle systems for safety and better driving. Safety features are designed to avoid collisions and accidents by offering technologies that alert the driver to potential problems, or to avoid collisions by implementing safeguards and taking over control of the vehicle.
/// </summary>
public readonly struct DriverAssistElement(string value) : IElement
{
    public const string Code = "DriverAssist";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 17. Engine Stroke Cycles - Engine stroke cycle is a numerical field for the number of strokes used by an internal combustion engine to complete a power cycle.
/// </summary>
public readonly struct EngineCyclesElement(int value) : IElement
{
    public const string Code = "EngineCycles";
    public int Value { get; init; } = value;

    public EngineCyclesElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 18. Engine Model - Engine model is a name that a manufacturer applies to a family of engine.
/// </summary>
public readonly struct EngineModelElement(string value) : IElement
{
    public const string Code = "EngineModel";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 21. Engine Power (kW) - This field stores engine power in kilowatts (kW).
/// </summary>
public readonly struct EngineKwElement(decimal value) : IElement
{
    public const string Code = "EngineKW";
    public decimal Value { get; init; } = value;

    public EngineKwElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 23. Entertainment System - This field defines the type of different entertainment systems in vehicles.
/// </summary>
public readonly struct EntertainmentSystemElement(string value) : IElement
{
    public const string Code = "EntertainmentSystem";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 24. Fuel Type - Primary - Fuel type defines the fuel used to power the vehicle. For vehicles that have two power sources, such as plug-in hybrid vehicle, both primary fuel type and secondary fuel type will be provided.
/// </summary>
public readonly struct FuelTypePrimaryElement(string value) : IElement
{
    public const string Code = "FuelTypePrimary";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 25. Gross Vehicle Weight Rating From - Gross vehicle weight rating (GVWR) is the maximum operating weight of a vehicle including the vehicle's chassis, body, engine, engine fluids, fuel, accessories, driver, passengers and cargo, but excluding that of the trailers. Per 49 CFR 565.15, Class 1 is further broken down to Class A-D; Class 2 is further broken down to Class E-H. This field captures the lower bound of GVWR range for the vehicle.
/// </summary>
public readonly struct GvwrElement(string value) : IElement
{
    public const string Code = "GVWR";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 26. Make - Per 49 CFR 565, Make is a name that a manufacturer applies to a group of vehicles or engines.
/// </summary>
public readonly struct MakeElement(string value) : IElement
{
    public const string Code = "Make";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 27. Manufacturer Name - Name of the vehicle manufacturer.
/// </summary>
public readonly struct ManufacturerElement(string value) : IElement
{
    public const string Code = "Manufacturer";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 28. Model - Per 49 CFR 565, Model means a name that a manufacturer applies to a family of vehicles of the same type, make, line, series and body type.
/// </summary>
public readonly struct ModelElement(string value) : IElement
{
    public const string Code = "Model";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 29. Model Year - If the model year (MY) is supplied when the VIN is decoded, such as from a crash report or a vehicle registration record, the MY value will be the supplied MY, even if the MY decoded from the VIN differs from the supplied MY. If the MY is not supplied when the VIN is decoded, the MY value will be decoded from the 10th character in the VIN.
/// </summary>
public readonly struct ModelYearElement(int value) : IElement
{
    public const string Code = "ModelYear";
    public int Value { get; init; } = value;

    public ModelYearElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 31. Plant City - This data element captures the city of the manufacturing plant where the manufacturer affixes the VIN.
/// </summary>
public readonly struct PlantCityElement(string value) : IElement
{
    public const string Code = "PlantCity";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 33. Number of Seats - This data element is a numeric field to store the number of seats in a vehicle.
/// </summary>
public readonly struct SeatsElement(int value) : IElement
{
    public const string Code = "Seats";
    public int Value { get; init; } = value;

    public SeatsElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 34. Series - Per 49 CFR 565, Series means a name that a manufacturer applies to a subdivision of a "line" denoting price, size or weight identification and that is used by the manufacturer for marketing purposes.
/// </summary>
public readonly struct SeriesElement(string value) : IElement
{
    public const string Code = "Series";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 36. Steering Location - This data element captures the location of steering column, either on left- (LHD) or right-hand side (RHD).
/// </summary>
public readonly struct SteeringLocationElement(string value) : IElement
{
    public const string Code = "SteeringLocation";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 37. Transmission Style - Transmission style provides information about the type of transmissions. The major types of transmissions are manual transmission, automatic transmission, continuously variable transmission (CVT), and dual-clutch transmission (DCT).
/// </summary>
public readonly struct TransmissionStyleElement(string value) : IElement
{
    public const string Code = "TransmissionStyle";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 38. Trim - Trim levels further identify a vehicle by a particular set of special features. Higher trim levels either will add to the features of the base (entry-level model), or replace them with something else.
/// </summary>
public readonly struct TrimElement(string value) : IElement
{
    public const string Code = "Trim";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 39. Vehicle Type - This field defines the type of the vehicle based on the World Manufacturer Identifier (WMI).
/// </summary>
public readonly struct VehicleTypeElement(string value) : IElement
{
    public const string Code = "VehicleType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 40. Windows - This field defines the number of windows on a vehicle.
/// </summary>
public readonly struct WindowsElement(int value) : IElement
{
    public const string Code = "Windows";
    public int Value { get; init; } = value;

    public WindowsElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 41. Axles - This numerical field defines the number of axles on a vehicle.
/// </summary>
public readonly struct AxlesElement(int value) : IElement
{
    public const string Code = "Axles";
    public int Value { get; init; } = value;

    public AxlesElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 42. Brake System Type - Brake system type is the type of brake systems used to stop and hold the vehicle or combination of motor vehicles.
/// </summary>
public readonly struct BrakeSystemTypeElement(string value) : IElement
{
    public const string Code = "BrakeSystemType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 45. NCIC Code - Description for NCIC Code
/// </summary>
public readonly struct NcicCodeElement(string value) : IElement
{
    public const string Code = "NCICCode";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 48. Number of Battery Cells per Module - This field stores the information about how battery cells are arranged for a vehicle.
/// </summary>
public readonly struct BatteryCellsElement(int value) : IElement
{
    public const string Code = "BatteryCells";
    public int Value { get; init; } = value;

    public BatteryCellsElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 49. Bed Length (inches) - Defines the length of the pickup truck bed in inches.
/// </summary>
public readonly struct BedLengthInElement(int value) : IElement
{
    public const string Code = "BedLengthIN";
    public int Value { get; init; } = value;

    public BedLengthInElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 52. Brake System Description - This field provides additional details about the brake system.
/// </summary>
public readonly struct BrakeSystemDescElement(string value) : IElement
{
    public const string Code = "BrakeSystemDesc";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 54. Curb Weight (pounds) - Curb weight (in pounds) is the total weight of a vehicle with standard equipment, all necessary operating consumables such as motor oil, transmission oil, coolant, air conditioning refrigerant, and a full tank of fuel, while not loaded with either passengers or cargo.
/// </summary>
public readonly struct CurbWeightLbElement(int value) : IElement
{
    public const string Code = "CurbWeightLB";
    public int Value { get; init; } = value;

    public CurbWeightLbElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 55. Curtain Air Bag Locations - This field captures the location of curtain air bags. Curtain air bags are side air bags that protect the head.
/// </summary>
public readonly struct AirBagLocCurtainElement(string value) : IElement
{
    public const string Code = "AirBagLocCurtain";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 56. Seat Cushion Air Bag Locations - This field captures the location of seat cushion air bags, used as a supplement to the seat belts to help prevent the front passenger from sliding forward in the event of a front impact collision.
/// </summary>
public readonly struct AirBagLocSeatCushionElement(string value) : IElement
{
    public const string Code = "AirBagLocSeatCushion";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 57. Battery Current (Amps) From - Battery Current (Amps) From field stores the lower value for battery current range in the unit of amperes (amps).
/// </summary>
public readonly struct BatteryAElement(int value) : IElement
{
    public const string Code = "BatteryA";
    public int Value { get; init; } = value;

    public BatteryAElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 58. Battery Voltage (Volts) From - Battery Voltage (Volts) From field stores the lower bound for battery voltage range in the unit of volts.
/// </summary>
public readonly struct BatteryVElement(int value) : IElement
{
    public const string Code = "BatteryV";
    public int Value { get; init; } = value;

    public BatteryVElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 59. Battery Energy (kWh) From - Battery Energy (kWh) From field stores the lower bound of battery energy range in the unit of kilowatt-hour (kWh).
/// </summary>
public readonly struct BatteryKWhElement(decimal value) : IElement
{
    public const string Code = "BatteryKWh";
    public decimal Value { get; init; } = value;

    public BatteryKWhElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 60. Wheel Base Type - This field describes the wheel base variations for some trucks and passenger cars, relative to other variants of the vehicle model. This field may have values such as short, standard, long, extra long, or super long.
/// </summary>
public readonly struct WheelBaseTypeElement(string value) : IElement
{
    public const string Code = "WheelBaseType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 61. Number of Seat Rows - This data element is a numeric field to capture the number of rows of seats in a vehicle.
/// </summary>
public readonly struct SeatRowsElement(int value) : IElement
{
    public const string Code = "SeatRows";
    public int Value { get; init; } = value;

    public SeatRowsElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 62. Valve Train Design - Valve train design defines engine camshaft design and control. Common values are single overhead cam (SOHC), dual overhead cam (DOHC), overhead valve (OHV), etc.
/// </summary>
public readonly struct ValveTrainDesignElement(string value) : IElement
{
    public const string Code = "ValveTrainDesign";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 63. Transmission Speeds - Transmission speed is a numerical field to capture the number of speeds for a transmission, such as 6 for a six-speed automatic or manual transmission.
/// </summary>
public readonly struct TransmissionSpeedsElement(int value) : IElement
{
    public const string Code = "TransmissionSpeeds";
    public int Value { get; init; } = value;

    public TransmissionSpeedsElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 64. Engine Configuration - Engine configuration defines how engine cylinders are arranged. Common values are V6 for V-shaped arrangement, I4 or L4 for in-line arrangement.
/// </summary>
public readonly struct EngineConfigurationElement(string value) : IElement
{
    public const string Code = "EngineConfiguration";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 65. Front Air Bag Locations - This field captures the location of frontal air bags. Frontal air bags are generally designed to deploy in "moderate to severe" frontal or near-frontal crashes.
/// </summary>
public readonly struct AirBagLocFrontElement(string value) : IElement
{
    public const string Code = "AirBagLocFront";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 66. Fuel Type - Secondary - Fuel type defines the fuel used to power the vehicle. For vehicles that have two power sources, such as plug-in hybrid vehicle, both primary fuel type and secondary fuel type will be provided.
/// </summary>
public readonly struct FuelTypeSecondaryElement(string value) : IElement
{
    public const string Code = "FuelTypeSecondary";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 67. Fuel Delivery / Fuel Injection Type - Fuel Delivery / Fuel Injection Type defines the mechanism through which fuel is delivered to the engine.
/// </summary>
public readonly struct FuelInjectionTypeElement(string value) : IElement
{
    public const string Code = "FuelInjectionType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 69. Knee Air Bag Locations - This field captures the location of knee air bags, which deploy from a car's lower dashboard, are meant to distribute impact forces on an occupant's legs in the case of a crash, thereby reducing leg injuries.
/// </summary>
public readonly struct AirBagLocKneeElement(string value) : IElement
{
    public const string Code = "AirBagLocKnee";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 71. Engine Brake (hp) From - Engine brake is the horsepower (hp) at the engine output shaft. Engine Brake (hp) From is the lower value of the range.
/// </summary>
public readonly struct EngineHpElement(decimal value) : IElement
{
    public const string Code = "EngineHP";
    public decimal Value { get; init; } = value;

    public EngineHpElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 72. EV Drive Unit - EV Drive Unit field stores electric vehicle (EV) motor configuration for single or dual motor.
/// </summary>
public readonly struct EvDriveUnitElement(string value) : IElement
{
    public const string Code = "EVDriveUnit";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 75. Plant Country - This data element captures the country of the manufacturing plant where the manufacturer affixes the VIN.
/// </summary>
public readonly struct PlantCountryElement(string value) : IElement
{
    public const string Code = "PlantCountry";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 76. Plant Company Name - This data element captures the name of the company that owns the manufacturing plant  where the manufacturer affixes the VIN.
/// </summary>
public readonly struct PlantCompanyNameElement(string value) : IElement
{
    public const string Code = "PlantCompanyName";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 77. Plant State - This data element captures the State or Province name within the Plant Country of the manufacturing plant where the manufacturer affixes the VIN.
/// </summary>
public readonly struct PlantStateElement(string value) : IElement
{
    public const string Code = "PlantState";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 78. Pretensioner - This yes/no field captures whether or not the vehicle has a pretensioner, a device designed to make seat belts even more effective by removing the slack from a seat belt as soon as a crash is detected or if the system senses excessive seat belt tension on the driver's or passenger's seat belt.
/// </summary>
public readonly struct PretensionerElement(string value) : IElement
{
    public const string Code = "Pretensioner";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 79. Seat Belt Type - This field describes the type of seat belt, such as manual or automatic. Automatic seat belts automatically close over riders in a vehicle. Automatic seat belts were mainly used in some older model GM, Nissan, and Honda vehicles and are rarely seen now.
/// </summary>
public readonly struct SeatBeltsAllElement(string value) : IElement
{
    public const string Code = "SeatBeltsAll";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 81. Adaptive Cruise Control (ACC) - ACC automatically adjusts the vehicle's speed to keep a pre-set distance from the vehicle in front of it.
/// </summary>
public readonly struct AdaptiveCruiseControlElement(string value) : IElement
{
    public const string Code = "AdaptiveCruiseControl";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 82. Adaptive Headlights - Adaptive headlights are an active safety feature designed to make driving at night or in low-light conditions safer by increasing visibility around curves and over hills.
/// </summary>
public readonly struct AdaptiveHeadlightsElement(string value) : IElement
{
    public const string Code = "AdaptiveHeadlights";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 86. Anti-lock Braking System (ABS) - Anti-lock Braking System (ABS) means a portion of a service brake system that automatically controls the degree of rotational wheel slip during braking by: (1) Sensing the rate of angular rotation of the wheels; (2) Transmitting signals regarding the rate of wheel angular rotation to one or more controlling devices that interpret those signals and generate responsive controlling output signals; and (3) Transmitting those controlling signals to one or more modulator devices that adjust brake actuating forces in response to those signals.
/// </summary>
public readonly struct AbsElement(string value) : IElement
{
    public const string Code = "ABS";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 87. Crash Imminent Braking (CIB) - A CIB system is an automatic emergency braking system designed to detect an impending forward crash with another vehicle. CIB systems automatically apply the brakes in a crash imminent situation to slow or stop the vehicle, avoiding the crash or reducing its severity, if the driver does not brake in response to a forward collision alert.
/// </summary>
public readonly struct CibElement(string value) : IElement
{
    public const string Code = "CIB";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 88. Blind Spot Warning (BSW) - BSW alerts drivers with an audio or visual warning if there are vehicles in adjacent lanes that the driver may not see when making a lane change.
/// </summary>
public readonly struct BlindSpotMonElement(string value) : IElement
{
    public const string Code = "BlindSpotMon";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 89. CAFE Body Type - No description available.
/// </summary>
public readonly struct CafeBodyTypeElement(string value) : IElement
{
    public const string Code = "CAFEBodyType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 90. CAFE Make - No description available.
/// </summary>
public readonly struct CafeMakeElement(string value) : IElement
{
    public const string Code = "CAFEMake";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 91. CAFE Model - No description available.
/// </summary>
public readonly struct CafeModelElement(string value) : IElement
{
    public const string Code = "CAFEModel";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 92. NCAP Body Type - No description available.
/// </summary>
public readonly struct NcapBodyTypeElement(string value) : IElement
{
    public const string Code = "NCAPBodyType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 93. NCAP Make - No description available.
/// </summary>
public readonly struct NcapMakeElement(string value) : IElement
{
    public const string Code = "NCAPMake";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 94. NCAP Model - No description available.
/// </summary>
public readonly struct NcapModelElement(string value) : IElement
{
    public const string Code = "NCAPModel";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 96. NCSA Body Type - An internal NHTSA field to capture the body type of the vehicle.
/// </summary>
public readonly struct NcsaBodyTypeElement(string value) : IElement
{
    public const string Code = "NCSABodyType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 97. NCSA Make - An internal NHTSA field to capture the Make of the vehicle.
/// </summary>
public readonly struct NcsaMakeElement(string value) : IElement
{
    public const string Code = "NCSAMake";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 98. NCSA Model - An internal NHTSA field to capture the Model of the vehicle.
/// </summary>
public readonly struct NcsaModelElement(string value) : IElement
{
    public const string Code = "NCSAModel";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 99. Electronic Stability Control (ESC) - ESC is a computerized technology that improves a vehicle's stability by detecting and reducing loss of traction (skidding). When ESC detects loss of steering control, it automatically applies the brakes to help steer the vehicle in the driver's intended direction. Braking is automatically applied to wheels individually, such as the outer front wheel to counter oversteer, or the inner rear wheel to counter understeer. Some ESC systems also reduce engine power until control is regained.
/// </summary>
public readonly struct EscElement(string value) : IElement
{
    public const string Code = "ESC";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 100. Traction Control - When the traction control computer detects a driven wheel or wheels spinning significantly faster than another, it invokes an electronic control unit to apply brake friction to wheels spinning due to loss of traction. This braking action on slipping wheels will cause power transfer to the wheels with traction due to the mechanical action within the differential.
/// </summary>
public readonly struct TractionControlElement(string value) : IElement
{
    public const string Code = "TractionControl";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 101. Forward Collision Warning (FCW) - An FCW system monitors a vehicle's speed, the speed of the vehicle in front of it, and the distance between the vehicles. If the vehicles get too close due to the speed of either vehicle, the FCW system will warn the driver of the rear vehicle of an impending crash so that the driver can apply the brakes or take evasive action, such as steering, to prevent a potential crash. FCW systems provide an audible, visual, or haptic warning, or any combination thereof, to alert the driver of an FCW-equipped vehicle of a potential collision.
/// </summary>
public readonly struct ForwardCollisionWarningElement(string value) : IElement
{
    public const string Code = "ForwardCollisionWarning";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 102. Lane Departure Warning (LDW) - An LDW system monitors lane markings and alerts the driver if their vehicle drifts out of their lane without a turn signal or any control input indicating the lane departure is intentional. An audio, visual or other alert warns the driver of the unintentional lane shift so the driver can steer the vehicle back into its lane.
/// </summary>
public readonly struct LaneDepartureWarningElement(string value) : IElement
{
    public const string Code = "LaneDepartureWarning";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 103. Lane Keeping Assistance (LKA) - An LKA system prevents a driver from unintentionally drifting out of the intended travel lane. LKA systems use information provided by Lane Departure Warning (LDW) system sensors to determine whether a vehicle is about to unintentionally move out of its lane of travel. If so, LKA activates and corrects the steering, brakes or accelerates one or more wheels, or does both, resulting in the vehicle returning to its intended lane of travel.
/// </summary>
public readonly struct LaneKeepSystemElement(string value) : IElement
{
    public const string Code = "LaneKeepSystem";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 104. Backup Camera - A backup camera, also known as a rearview video system, helps prevent back-over crashes and protects our most vulnerable people - children and senior citizens - by providing an image of the area behind the vehicle. A backup camera helps the driver see behind the vehicle while in reverse.
/// </summary>
public readonly struct RearVisibilitySystemElement(string value) : IElement
{
    public const string Code = "RearVisibilitySystem";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 105. Parking Assist - A parking assist system uses computer processors, back up cameras, surround-view cameras, and sensors to assist with steering and other functions during parking. Drivers may be required to accelerate, brake, or select gear position. Some systems are capable of parallel and perpendicular parking. Drivers must constantly supervise this support feature and maintain responsibility for parking.
/// </summary>
public readonly struct ParkAssistElement(string value) : IElement
{
    public const string Code = "ParkAssist";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 107. Side Air Bag Locations - This field captures the location of side air bags, typically designed for three areas of added protection: chest/torso, head, or both.
/// </summary>
public readonly struct AirBagLocSideElement(string value) : IElement
{
    public const string Code = "AirBagLocSide";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 109. Trim2 - This data element captures additional information about trim of the vehicle.
/// </summary>
public readonly struct Trim2Element(string value) : IElement
{
    public const string Code = "Trim2";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 110. Series2 - This data element captures additional information about series of the vehicle.
/// </summary>
public readonly struct Series2Element(string value) : IElement
{
    public const string Code = "Series2";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 111. Wheel Base (inches) From - Wheel base is the distance between the centers of the front and rear wheels measured in inches. This field captures the lower bound of the wheel base range.
/// </summary>
public readonly struct WheelBaseShortElement(decimal value) : IElement
{
    public const string Code = "WheelBaseShort";
    public decimal Value { get; init; } = value;

    public WheelBaseShortElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 112. Wheel Base (inches) To - Wheel base is the distance between the centers of the front and rear wheels measured in inches. This field captures the upper bound of the wheel base range.
/// </summary>
public readonly struct WheelBaseLongElement(decimal value) : IElement
{
    public const string Code = "WheelBaseLong";
    public decimal Value { get; init; } = value;

    public WheelBaseLongElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 114. Note - Note is used to store any additional information that does not correspond to any of the specified fields on the interface. This is a catch-all element for systems other than for engine, restraint system, brake and battery. Engine, restraint system, brake, and battery have their own note elements.
/// </summary>
public readonly struct NoteElement(string value) : IElement
{
    public const string Code = "Note";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 115. Number of Wheels - This field captures the number of wheels on a vehicle.
/// </summary>
public readonly struct WheelsElement(int value) : IElement
{
    public const string Code = "Wheels";
    public int Value { get; init; } = value;

    public WheelsElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 116. Trailer Type Connection - Trailer Type Connection describes the connector or tongue used for the trailers.
/// </summary>
public readonly struct TrailerTypeElement(string value) : IElement
{
    public const string Code = "TrailerType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 117. Trailer Body Type - Trailer Body Type describes the purpose of the trailer or how it is designed to be used.
/// </summary>
public readonly struct TrailerBodyTypeElement(string value) : IElement
{
    public const string Code = "TrailerBodyType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 118. Trailer Length (feet) - Trailer length is the length of the trailer in feet from the front of the connector to the end of the trailer.
/// </summary>
public readonly struct TrailerLengthElement(decimal value) : IElement
{
    public const string Code = "TrailerLength";
    public decimal Value { get; init; } = value;

    public TrailerLengthElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 119. Wheel Size Front (inches) - This field captures the diameter of the front wheel in inches.
/// </summary>
public readonly struct WheelSizeFrontElement(int value) : IElement
{
    public const string Code = "WheelSizeFront";
    public int Value { get; init; } = value;

    public WheelSizeFrontElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 120. Wheel Size Rear (inches) - This field captures the diameter of the rear wheel in inches.
/// </summary>
public readonly struct WheelSizeRearElement(int value) : IElement
{
    public const string Code = "WheelSizeRear";
    public int Value { get; init; } = value;

    public WheelSizeRearElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 121. Other Restraint System Info - Other Restraint Info field is used to code additional information about restraint system that cannot be coded in any other restraint fields.
/// </summary>
public readonly struct OtherRestraintSystemInfoElement(string value) : IElement
{
    public const string Code = "OtherRestraintSystemInfo";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 122. Cooling Type - Cooling type defines the cooling system used to control the engine temperature. It can be either air-cooled or water-cooled.
/// </summary>
public readonly struct CoolingTypeElement(string value) : IElement
{
    public const string Code = "CoolingType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 125. Engine Brake (hp) To - Engine brake is the horsepower (hp) at the engine output shaft. Engine Brake (hp) To is the upper value of the range.
/// </summary>
public readonly struct EngineHpToElement(decimal value) : IElement
{
    public const string Code = "EngineHP_to";
    public decimal Value { get; init; } = value;

    public EngineHpToElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 126. Electrification Level - Electrification level defines to what level the vehicle is powered by electric system. The common electric system configurations are mild hybrid, strong hybrid, plug-in hybrid, battery electric, and fuel cell vehicles.(1) Mild hybrid is the system such as 12-volt start-stop or 48-volt belt integrator starter generator (BISG) system that uses an electric motor to add assisting power to the internal combustion engine. The system has features such as stop-start, power assist, and mild level of generative braking features.(2) Strong hybrid systems, in vehicles such as the Toyota Prius, mainly consist of motors, conventional gasoline engine, and battery, but the source of electrical charge for the battery power is provided by the conventional engine and/or regenerative braking.(3) Plug-in hybrid systems, in vehicles such as the Toyota Rav4 Prime, mainly consist of motors, conventional gasoline engine and battery. Plug-in hybrid vehicles are like strong hybrids, but they have a larger battery pack and can be charged with an external source of electricity by electric vehicle supply equipment (EVSE).(4) Battery electric vehicles (BEV), such as the Tesla Model S or Nissan Leaf, have only a battery and electrical motor components and use electricity as the only power source.(5) Fuel cell electric vehicles (FCEV) use full electric drive platforms but consume electricity generated by onboard fuel cells and hydrogen fuel.
/// </summary>
public readonly struct ElectrificationLevelElement(string value) : IElement
{
    public const string Code = "ElectrificationLevel";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 127. Charger Level - There are three levels of battery chargers currently. Level 1 and 2 are AC chargers; Level 3 is a DC charger. Chargers at each level charge batteries with different voltage and current levels. Level 3 is the fastest charging.-Level 1<ul><li>AC charger.</li><li>In North America this typically means 16 amps at 120 volts delivering 1.9 kW of power.</li><li>In Europe it may be 13 or 16 amps at 240 volts delivering 3 kW of power.</li><li>The EV may incorporate a standard domestic power cord to connect the vehicle to a domestic socket outlet or a Level 1 charging station.</li></ul>-Level 2<ul><li>AC charger.</li><li>It delivers up to 20 kW of power from either single- or three-phase alternating current (AC) sources of 208-240 volts at up to 80 amps.</li></ul>-Level 3<ul><li>DC charging, or "fast charging."</li><li>To achieve very short charging times, Level 3 chargers supply very high currents of up to 400 amps at voltages up to 600 volts DC delivering a maximum power of 240 kW.</li></ul>
/// </summary>
public readonly struct ChargerLevelElement(string value) : IElement
{
    public const string Code = "ChargerLevel";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 128. Charger Power (kW) - Charger power stores the power of the charging circuit on board in kilowatts (kW).
/// </summary>
public readonly struct ChargerPowerKwElement(int value) : IElement
{
    public const string Code = "ChargerPowerKW";
    public int Value { get; init; } = value;

    public ChargerPowerKwElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 129. Other Engine Info - This is a catch-all field for storing additional engine information that does not fit in any of the other engine fields.
/// </summary>
public readonly struct OtherEngineInfoElement(string value) : IElement
{
    public const string Code = "OtherEngineInfo";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 132. Battery Current (Amps) To - Battery Current (Amps) To field stores the higher value for battery current range in the unit of amperes (amps).
/// </summary>
public readonly struct BatteryAToElement(int value) : IElement
{
    public const string Code = "BatteryA_to";
    public int Value { get; init; } = value;

    public BatteryAToElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 133. Battery Voltage (Volts) To - Battery Voltage (Volts) To field stores the upper bound for battery voltage range in the unit of volts.
/// </summary>
public readonly struct BatteryVToElement(int value) : IElement
{
    public const string Code = "BatteryV_to";
    public int Value { get; init; } = value;

    public BatteryVToElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 134. Battery Energy (kWh) To - Battery Energy (kWh) To field stores the upper bound of battery energy range in the unit of kilowatt-hour (kWh).
/// </summary>
public readonly struct BatteryKWhToElement(decimal value) : IElement
{
    public const string Code = "BatteryKWh_to";
    public decimal Value { get; init; } = value;

    public BatteryKWhToElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 135. Turbo - Turbo is a yes/no field to identify whether the engine is turbo-charged or not.
/// </summary>
public readonly struct TurboElement(string value) : IElement
{
    public const string Code = "Turbo";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 136. Base Price ($) - Base price of the vehicle is the cost of a new vehicle with only the standard  equipment and factory warranty. It is the cost without any optional packages.
/// </summary>
public readonly struct BasePriceElement(decimal value) : IElement
{
    public const string Code = "BasePrice";
    public decimal Value { get; init; } = value;

    public BasePriceElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 137. Number of Battery Modules per Pack - This field stores the information about how battery modules are arranged for a vehicle.
/// </summary>
public readonly struct BatteryModulesElement(int value) : IElement
{
    public const string Code = "BatteryModules";
    public int Value { get; init; } = value;

    public BatteryModulesElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 138. Number of Battery Packs per Vehicle - This field stores the information about how battery packs are arranged for a vehicle.
/// </summary>
public readonly struct BatteryPacksElement(int value) : IElement
{
    public const string Code = "BatteryPacks";
    public int Value { get; init; } = value;

    public BatteryPacksElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 139. Top Speed (MPH) - This data element captures the top speed of the vehicle in miles per hour (mph).
/// </summary>
public readonly struct TopSpeedMphElement(int value) : IElement
{
    public const string Code = "TopSpeedMPH";
    public int Value { get; init; } = value;

    public TopSpeedMphElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 140. EquipmentType - Equipment items that a company manufacturers.
/// </summary>
public readonly struct EquipmentTypeElement(string value) : IElement
{
    public const string Code = "EquipmentType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 141. Manufacturer Type - This field stores different types of vehicle manufacturers.
/// </summary>
public readonly struct ManufacturerTypeElement(string value) : IElement
{
    public const string Code = "ManufacturerType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 142. Suggested VIN - A suggested VIN is provided when there are errors in the VIN decode.
/// </summary>
public readonly struct SuggestedVinElement(string value) : IElement
{
    public const string Code = "SuggestedVIN";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 143. Error Code - Error Code is a numerical code that determines the nature of the error from VIN decode, and why it occurred.
/// </summary>
public readonly struct ErrorCodeElement(string value) : IElement
{
    public const string Code = "ErrorCode";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 144. Possible Values - A list of possible characters that can be used to replace the erratic characters in the VIN.
/// </summary>
public readonly struct PossibleValuesElement(string value) : IElement
{
    public const string Code = "PossibleValues";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 145. Axle Configuration - Axle configuration describes the placement of the axles in a vehicle. This field is mainly used for trucks.
/// </summary>
public readonly struct AxleConfigurationElement(string value) : IElement
{
    public const string Code = "AxleConfiguration";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 146. Engine Manufacturer - This data element captures the name of the engine manufacturer.
/// </summary>
public readonly struct EngineManufacturerElement(string value) : IElement
{
    public const string Code = "EngineManufacturer";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 147. Bus Length (feet) - This field captures the length of bus in feet.
/// </summary>
public readonly struct BusLengthElement(int value) : IElement
{
    public const string Code = "BusLength";
    public int Value { get; init; } = value;

    public BusLengthElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 148. Bus Floor Configuration Type - This field defines the relative height of the bus floor from the ground. Common values include normal, lift/raised, low floor, and sleeper coach. Low floor refers to a bus deck that is accessible from the sidewalk with only a single step with a small height difference, caused solely by the difference between the bus deck and sidewalk. This is distinct from high/raised floor, a bus deck design that requires climbing one or more steps to access the interior floor that is placed at a higher height. A sleeper coach is a type of specially adapted coach designed for the passengers to sleep in.
/// </summary>
public readonly struct BusFloorConfigTypeElement(string value) : IElement
{
    public const string Code = "BusFloorConfigType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 149. Bus Type - This field defines the type of bus. Common types include commuter coach, double deck coach, tourist coach, urban bus, transit bus, entertainer coach and motorhome.
/// </summary>
public readonly struct BusTypeElement(string value) : IElement
{
    public const string Code = "BusType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 150. Other Bus Info - Additional information about bus is captured in this field.
/// </summary>
public readonly struct OtherBusInfoElement(string value) : IElement
{
    public const string Code = "OtherBusInfo";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 151. Custom Motorcycle Type - Defines the type of customized motorcycle, including values such as bagger, chopper, cruise, touring. Custom motorcycle type is provided by the manufacturer but not defined.
/// </summary>
public readonly struct CustomMotorcycleTypeElement(string value) : IElement
{
    public const string Code = "CustomMotorcycleType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 152. Motorcycle Suspension Type - Defines the type of suspension in motorcycles, including values such as hardtail, softail, wing fork, etc. Motorcycle Suspension Type is provided by the manufacturer but not defined.
/// </summary>
public readonly struct MotorcycleSuspensionTypeElement(string value) : IElement
{
    public const string Code = "MotorcycleSuspensionType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 153. Motorcycle Chassis Type - Defines the type of motorcycle chassis, including values such as trike, reversed trike/autocycle, three-wheeler, etc.
/// </summary>
public readonly struct MotorcycleChassisTypeElement(string value) : IElement
{
    public const string Code = "MotorcycleChassisType";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 154. Other Motorcycle Info - Additional information about motorcycles is captured in this field.
/// </summary>
public readonly struct OtherMotorcycleInfoElement(string value) : IElement
{
    public const string Code = "OtherMotorcycleInfo";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 155. Other Trailer Info - Additional information about trailers is captured in this field.
/// </summary>
public readonly struct OtherTrailerInfoElement(string value) : IElement
{
    public const string Code = "OtherTrailerInfo";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 156. Additional Error Text - This field is to store the additional description of the error text.
/// </summary>
public readonly struct AdditionalErrorTextElement(string value) : IElement
{
    public const string Code = "AdditionalErrorText";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 158. Cash For Clunkers - Cash For Clunkers message is returned, if VIN was part of the program. Cash for Clunkers was a government program that provided financial incentives to car owners to trade in their old, less fuel-efficient vehicles for more fuel-efficient ones.
/// </summary>
public readonly struct CashForClunkersElement(string value) : IElement
{
    public const string Code = "CashForClunkers";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 159. Track Width (inches) - A vehicle's track, or track width, is the distance in inches between the center line of each of the two wheels on the same axle on any given vehicle.
/// </summary>
public readonly struct TrackWidthElement(decimal value) : IElement
{
    public const string Code = "TrackWidth";
    public decimal Value { get; init; } = value;

    public TrackWidthElement(string value) : this(decimal.Parse(value))
    {
    }
}

/// <summary>
/// Id: 168. Tire Pressure Monitoring System (TPMS) Type - A TPMS is an electronic system designed to monitor the air pressure inside the pneumatic tires on various types of vehicles. TPMS can be divided into two different types - direct and indirect. Direct TPMS employ pressure sensors on each wheel, either internal or external. The sensors physically measure the tire pressure in each tire and report it to the vehicle's instrument cluster or a corresponding monitor. Indirect TPMS does not use physical pressure sensors but measure air pressures by monitoring individual wheel rotational speeds and other signals available outside of the tire itself.
/// </summary>
public readonly struct TpmsElement(string value) : IElement
{
    public const string Code = "TPMS";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 169. Active Safety System Note - This field stores additional information about active safety systems in a vehicle.
/// </summary>
public readonly struct ActiveSafetySysNoteElement(string value) : IElement
{
    public const string Code = "ActiveSafetySysNote";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 170. Dynamic Brake Support (DBS) - A DBS system is an automatic emergency braking system designed to detect an impending forward crash with another vehicle. DBS systems automatically supplement the driver's braking in an effort to avoid a crash if the driver does not brake hard enough to avoid it.
/// </summary>
public readonly struct DynamicBrakeSupportElement(string value) : IElement
{
    public const string Code = "DynamicBrakeSupport";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 171. Pedestrian Automatic Emergency Braking (PAEB) - A PAEB system provides automatic braking for vehicles when pedestrians are in front of the vehicle and the driver has not acted to avoid a crash.
/// </summary>
public readonly struct PedestrianAutomaticEmergencyBrakingElement(string value) : IElement
{
    public const string Code = "PedestrianAutomaticEmergencyBraking";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 172. Auto-Reverse System for Windows and Sunroofs - An auto-reverse system enables power windows and sunroofs on motor vehicles to automatically reverse direction when such power windows and panels detect an obstruction. This feature can prevent children and others from being trapped, injured, or killed by the power windows and sunroofs. : IElement
/// </summary>
public readonly struct AutoReverseSystemElement(string value) : IElement
{
    public const string Code = "AutoReverseSystem";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 173. Automatic Pedestrian Alerting Sound (for Hybrid and EV only) - Electric vehicle warning sounds are a series of sounds designed to alert pedestrians to the presence of electric drive vehicles such as hybrid electric vehicles (HEVs), plug-in hybrid electric vehicles (PHEVs), and all-electric vehicles (EVs) travelling at low speeds. Vehicles operating in all-electric mode produce less noise than traditional combustion engine vehicles and can make it more difficult for pedestrians, the blind, cyclists, and others to be aware of their presence.
/// </summary>
public readonly struct AutomaticPedestrianAlertingSoundElement(string value) : IElement
{
    public const string Code = "AutomaticPedestrianAlertingSound";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 174. Automatic Crash Notification (ACN) / Advanced Automatic Crash Notification (AACN) - An ACN system notifies emergency responders that a crash has occurred and provides its location.
/// </summary>
public readonly struct CanAacnElement(string value) : IElement
{
    public const string Code = "CAN_AACN";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 175. Event Data Recorder (EDR) - An EDR is a device installed in motor vehicles to record technical vehicle and occupant information for a brief period before, during, and after a triggering event, typically a crash or near-crash event. Sometimes referred to as "black-box" data, these data or event records can be valuable when analyzing and reconstructing crashes. : IElement
/// </summary>
public readonly struct EdrElement(string value) : IElement
{
    public const string Code = "EDR";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 176. Keyless Ignition - A keyless ignition system permits starting a car without a physical key being inserted into an ignition. Instead, a small device known as a "key fob" transmits a code to a computer in the vehicle when the fob is within a certain close range. When the coded signal matches the code embedded in the vehicle's computer, a number of systems within the car are activated, including the starter system. This allows the car to be started by simply pressing a button on the dashboard while the key fob is left in a pocket or a purse. The vehicle is usually shut down by pushing the same button.
/// </summary>
public readonly struct KeylessIgnitionElement(string value) : IElement
{
    public const string Code = "KeylessIgnition";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 177. Daytime Running Light (DRL) - DRL is an automotive lighting system on the front of a vehicle or bicycle, that automatically switches on when the vehicle is in drive, and emits white, yellow, or amber light to increase the conspicuity of the vehicle during daylight conditions.
/// </summary>
public readonly struct DaytimeRunningLightElement(string value) : IElement
{
    public const string Code = "DaytimeRunningLight";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 178. Headlamp Light Source - A headlamp light source provides a distribution of light designed to provide adequate forward and lateral illumination with limits on light directed towards the eyes of other road users, to control glare. This beam is intended for use whenever other vehicles are present ahead. Halogen, high-Intensity discharge (HID), light-emitting diode (LED), and laser are the most common headlights on the market.
/// </summary>
public readonly struct LowerBeamHeadlampLightSourceElement(string value) : IElement
{
    public const string Code = "LowerBeamHeadlampLightSource";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 179. Semiautomatic Headlamp Beam Switching - A semi-automatic headlamp beam switching device provides automatic or manual control of beam switching at the option of the driver. When the control is automatic, the headlamps switch from the upper beam to the lower beam when illuminated by the headlamps on an approaching car and switch back to the upper beam when the road ahead is dark. When the control is manual, the driver may obtain either beam manually regardless of the condition of lights ahead of the vehicle.
/// </summary>
public readonly struct SemiautomaticHeadlampBeamSwitchingElement(string value) : IElement
{
    public const string Code = "SemiautomaticHeadlampBeamSwitching";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 180. Adaptive Driving Beam (ADB) - ADB is a type of front-lighting system that lets upper beam headlamps adapt their beam patterns to create shaded areas around oncoming and preceding vehicles to improve long-range visibility for the driver without causing discomfort, distraction, or glare to other road users.
/// </summary>
public readonly struct AdaptiveDrivingBeamElement(string value) : IElement
{
    public const string Code = "AdaptiveDrivingBeam";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 181. SAE Automation Level From - SAE stands for the Society of Automotive Engineers, which changed its name to SAE International in 2006. This field indicates the lower bound of intelligence level and automation capabilities of vehicles, ranking from 0 to 5, per SAE Standard J3016 2018.
/// </summary>
public readonly struct SaeAutomationLevelElement(int value) : IElement
{
    public const string Code = "SAEAutomationLevel";
    public int Value { get; init; } = value;

    public SaeAutomationLevelElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 182. SAE Automation Level To - SAE stands for the Society of Automotive Engineers, which changed its name to SAE International in 2006. This field indicates the higher bound of intelligence level and automation capabilities of vehicles, ranking from 0 to 5, per SAE Standard J3016 2018.
/// </summary>
public readonly struct SaeAutomationLevelToElement(int value) : IElement
{
    public const string Code = "SAEAutomationLevel_to";
    public int Value { get; init; } = value;

    public SaeAutomationLevelToElement(string value) : this(int.Parse(value))
    {
    }
}

/// <summary>
/// Id: 183. Rear Cross Traffic Alert - A rear cross traffic alert system warns the driver of a potential collision, while in reverse, which may be outside the view of the backup camera.
/// </summary>
public readonly struct RearCrossTrafficAlertElement(string value) : IElement
{
    public const string Code = "RearCrossTrafficAlert";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 184. Gross Combination Weight Rating From - Gross combination weight rating (GCWR) is the maximum allowable combined mass of a road vehicle, the passengers and cargo in the tow vehicle, plus the mass of the trailer and cargo in the trailer. This rating is set by the vehicle manufacturer. This field captures the lower bound of GCWR range for the vehicle.
/// </summary>
public readonly struct GcwrElement(string value) : IElement
{
    public const string Code = "GCWR";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 185. Gross Combination Weight Rating To - Gross combination weight rating (GCWR) is the maximum allowable combined mass of a road vehicle, the passengers and cargo in the tow vehicle, plus the mass of the trailer and cargo in the trailer. This rating is set by the vehicle manufacturer. This field captures the higher bound of GCWR range for the vehicle.
/// </summary>
public readonly struct GcwrToElement(string value) : IElement
{
    public const string Code = "GCWR_to";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 186. NCSA Note - This internal field is to note the logic behind the NCSA mapping in special cases.
/// </summary>
public readonly struct NcsaNoteElement(string value) : IElement
{
    public const string Code = "NCSANote";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 187. NCSA Mapping Exception - This internal field is to capture the reason of exception for special NCSA mapping.
/// </summary>
public readonly struct NcsaMappingExceptionElement(string value) : IElement
{
    public const string Code = "NCSAMappingException";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 188. NCSA Mapping Exception Approved On - The date when the NCSA mapping exception is approved on.
/// </summary>
public readonly struct NcsaMapExcApprovedOnElement(string value) : IElement
{
    public const string Code = "NCSAMapExcApprovedOn";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 189. NCSA Mapping Exception Approved By - This field captures the name of the person who approved the NCSA mapping exception.
/// </summary>
public readonly struct NcsaMapExcApprovedByElement(string value) : IElement
{
    public const string Code = "NCSAMapExcApprovedBy";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 190. Gross Vehicle Weight Rating To - Gross vehicle weight rating (GVWR) is the maximum operating weight of a vehicle including the vehicle's chassis, body, engine, engine fluids, fuel, accessories, driver, passengers and cargo, but excluding that of the trailers. Per 49 CFR 565.15, Class 1 is further broken down to Class A-D; Class 2 is further broken down to Class E-H. This field captures the higher bound of GVWR range for the vehicle.
/// </summary>
public readonly struct GvwrToElement(string value) : IElement
{
    public const string Code = "GVWR_to";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 191. Error Text - Error Text
/// </summary>
public readonly struct ErrorTextElement(string value) : IElement
{
    public const string Code = "ErrorText";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 192. Rear Automatic Emergency Braking - A rear automatic braking system uses sensors, like parking sensors and the backup camera, to detect objects behind the vehicle. If the system detects a potential collision while in reverse, it automatically applies the brakes if a crash is imminent.
/// </summary>
public readonly struct RearAutomaticEmergencyBrakingElement(string value) : IElement
{
    public const string Code = "RearAutomaticEmergencyBraking";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 193. Blind Spot Intervention (BSI) - BSI helps prevent a collision with a vehicle in the driver's blind spot. If the driver ignores the blind spot warning and starts to change to a lane where there's a vehicle, the system activates and automatically applies light braking pressure, or provides steering input, to guide the vehicle back into the original lane. The system monitors for vehicles in the driver's blind spot using rear-facing cameras or proximity sensors.
/// </summary>
public readonly struct BlindSpotInterventionElement(string value) : IElement
{
    public const string Code = "BlindSpotIntervention";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 194. Lane Centering Assistance - A lane centering assistance system utilizes a camera-based vision system designed to monitor the vehicle's lane position and automatically and continuously apply steering inputs needed to keep the vehicle centered within its lane.
/// </summary>
public readonly struct LaneCenteringAssistanceElement(string value) : IElement
{
    public const string Code = "LaneCenteringAssistance";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 195. Non-Land Use - Non-Land Use data element identifies the non-land use of the vehicle when a vehicle is designed to be used off land (e.g., an amphibious vehicle).<ul><li>Air: identifies vehicles that can be driven on land and in the air</li><li>Air and Water: identifies vehicles that can be driven on land, in the air and on or under water</li><li>Water: identifies vehicles that can be driven on land and on or under water</li></ul><br>
/// </summary>
public readonly struct NonLandUseElement(string value) : IElement
{
    public const string Code = "NonLandUse";
    public string Value { get; init; } = value;
}

/// <summary>
/// Id: 196. Vehicle Descriptor - Vehicle Descriptor is a string that can be decoded like a VIN but does not include information to identify an individual vehicle. The sequential numbers and the check digit are replaced by asterisks to avoid any personally identifiable information that would be present in the VIN.
/// </summary>
public readonly struct VehicleDescriptorElement(string value) : IElement
{
    public const string Code = "VehicleDescriptor";
    public string Value { get; init; } = value;
}