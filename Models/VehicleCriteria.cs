using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleCriteria")]
public class VehicleCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public VehicleNameCriteria PersonName { get; set; }

    [XmlElement("Address")]
    public VehicleAddressCriteria Address { get; set; }

    [XmlElement("VehicleID")]
    public string VehicleID { get; set; }

    [XmlElement("LicensePlateNumber")]
    public string LicensePlateNumber { get; set; }

    [XmlElement("LicensePlateOptions")]
    public string LicensePlateOptions { get; set; }

    [XmlElement("VehicleMake")]
    public string VehicleMake { get; set; }

    [XmlElement("VehicleModel")]
    public string VehicleModel { get; set; }

    [XmlElement("VehicleModelYear")]
    public string VehicleModelYear { get; set; }

    [XmlElement("VehicleTitleNumber")]
    public string VehicleTitleNumber { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }
}
