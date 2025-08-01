using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CollectionExperience")]
public class CollectionExperience
{
    [XmlElement("DatePlaced")]
    public string DatePlaced { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("OriginalBalance")]
    public int OriginalBalance { get; set; }

    [XmlElement("OutstandingBalance")]
    public int OutstandingBalance { get; set; }

    [XmlElement("DateClosed")]
    public string DateClosed { get; set; }

    [XmlElement("Agency")]
    public string Agency { get; set; }

    [XmlElement("AgencyPhoneNumber")]
    public string AgencyPhoneNumber { get; set; }
}
