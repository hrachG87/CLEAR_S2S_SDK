using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIBusinessReportCategoryInfo")]
public class RIBusinessReportCategoryInfo
{
    [XmlElement("CategoryName")]
    public string CategoryName { get; set; }

    [XmlElement("FlagInfo")]
    public List<RIBusinessReportFlagInfo> FlagInfo { get; set; }

}