using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonReportCategoryInfo")]
public class RIPersonReportCategoryInfo
{
    [XmlElement("CategoryName")]
    public string CategoryName { get; set; }

    [XmlElement("flagInfo")]
    public List<RIPersonReportFlagInfo> flagInfo { get; set; }
}
