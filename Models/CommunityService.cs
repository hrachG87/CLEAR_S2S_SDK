using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CommunityService")]
public class CommunityService
{
    [XmlElement("CommunityServiceCounty")]
    public string CommunityServiceCounty { get; set; }

    [XmlElement("DurationOfTime")]
    public CriminalDataDurationOfTime DurationOfTime { get; set; }
}
