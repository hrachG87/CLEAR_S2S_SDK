using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RealTimeVehicleRecord")]
public class RealTimeVehicleRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("RegisteredOwner")]
    public OwnerInfo RegisteredOwner { get; set; }

    [XmlElement("SecondaryOwner")]
    public OwnerInfo SecondaryOwner { get; set; }

    [XmlElement("VehicleInfo")]
    public VehicleInfo VehicleInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("StockVehicleImage")]
    public StockVehicleImage StockVehicleImage { get; set; }

    [XmlElement("AdditionalOwner")]
    public OwnerInfo AdditionalOwner { get; set; }

    [XmlElement("BrandedInfo1")]
    public BrandedInfo BrandedInfo1 { get; set; }

    [XmlElement("BrandedInfo2")]
    public BrandedInfo BrandedInfo2 { get; set; }

    [XmlElement("BrandedInfo3")]
    public BrandedInfo BrandedInfo3 { get; set; }

}