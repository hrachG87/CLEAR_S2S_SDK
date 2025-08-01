using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DMVHistory")]
public class DMVHistory
{
    [XmlElement("TitleTransferDate")]
    public string TitleTransferDate { get; set; }

    [XmlElement("VehicleInfo")]
    public VehicleInfo VehicleInfo { get; set; }

    [XmlElement("DMVInfo")]
    public DMVInfo DMVInfo { get; set; }
}
