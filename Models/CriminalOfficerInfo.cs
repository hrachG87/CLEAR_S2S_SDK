using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalOfficerInfo")]
public class CriminalOfficerInfo
{
    [XmlElement("OfficerBadge")]
    public string OfficerBadge { get; set; }

    [XmlElement("OfficerName")]
    public string OfficerName { get; set; }

}