using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WatercraftCriteria")]
public class WatercraftCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("NameCriteria")]
    public WatercraftNameCriteria NameCriteria { get; set; }

    [XmlElement("Address")]
    public WatercraftAddressCriteria Address { get; set; }

    [XmlElement("VesselName")]
    public string VesselName { get; set; }

    [XmlElement("VesselID")]
    public string VesselID { get; set; }

    [XmlElement("HullID")]
    public string HullID { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }
}
