using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleSearchRequest")]
public class VehicleSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public VehicleUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public VehicleDatasources Datasources { get; set; }
}
