using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIBusinessReportFlagInfo")]
public class RIBusinessReportFlagInfo
{
    [XmlElement("FlagName")]
    public string FlagName { get; set; }

    [XmlElement("FlagDescription")]
    public string FlagDescription { get; set; }

    [XmlElement("FlagScore")]
    public string FlagScore { get; set; }
}
