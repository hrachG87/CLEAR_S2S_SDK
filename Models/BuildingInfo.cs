using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BuildingInfo")]
public class BuildingInfo
{
    [XmlElement("AirConditioning")]
    public string AirConditioning { get; set; }

    [XmlElement("BasementFinish")]
    public string BasementFinish { get; set; }

    [XmlElement("BasementSqFt")]
    public string BasementSqFt { get; set; }

    [XmlElement("BuildingCode")]
    public string BuildingCode { get; set; }

    [XmlElement("BuildingImprovCode")]
    public string BuildingImprovCode { get; set; }

    [XmlElement("BuildingStyle")]
    public string BuildingStyle { get; set; }

    [XmlElement("ConstructionQuality")]
    public string ConstructionQuality { get; set; }

    [XmlElement("ExteriorWallsDesc")]
    public string ExteriorWallsDesc { get; set; }

    [XmlElement("GarageDescription")]
    public string GarageDescription { get; set; }

    [XmlElement("HasFireplace")]
    public string HasFireplace { get; set; }

    [XmlElement("HasPool")]
    public string HasPool { get; set; }

    [XmlElement("LivingSpaceSquareFt")]
    public string LivingSpaceSquareFt { get; set; }

    [XmlElement("LotArea")]
    public string LotArea { get; set; }

    [XmlElement("NumberBaths")]
    public string NumberBaths { get; set; }

    [XmlElement("NumberBedrooms")]
    public string NumberBedrooms { get; set; }

    [XmlElement("NumberBuildings")]
    public string NumberBuildings { get; set; }

    [XmlElement("NumberFullBaths")]
    public string NumberFullBaths { get; set; }

    [XmlElement("NumberParkingSpaces")]
    public string NumberParkingSpaces { get; set; }

    [XmlElement("NumberRooms")]
    public string NumberRooms { get; set; }

    [XmlElement("NumberStoriesHigh")]
    public string NumberStoriesHigh { get; set; }

    [XmlElement("NumberUnits")]
    public string NumberUnits { get; set; }

    [XmlElement("PoolCode")]
    public string PoolCode { get; set; }

    [XmlElement("TypeOfConstruction")]
    public string TypeOfConstruction { get; set; }

    [XmlElement("TypeOfElectric")]
    public string TypeOfElectric { get; set; }

    [XmlElement("TypeOfFoundation")]
    public string TypeOfFoundation { get; set; }

    [XmlElement("TypeOfFuel")]
    public string TypeOfFuel { get; set; }

    [XmlElement("TypeOfHeat")]
    public string TypeOfHeat { get; set; }

    [XmlElement("TypeOfRoof")]
    public string TypeOfRoof { get; set; }

    [XmlElement("TypeOfSewer")]
    public string TypeOfSewer { get; set; }

    [XmlElement("TypeOfWater")]
    public string TypeOfWater { get; set; }

    [XmlElement("YearBuilt")]
    public string YearBuilt { get; set; }
}
