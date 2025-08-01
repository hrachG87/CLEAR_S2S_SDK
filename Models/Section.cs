using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Section")]
public class Section
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("CategoryInfo")]
    public List<RIBusinessReportCategoryInfo> CategoryInfo { get; set; }

    [XmlElement("FlagInfo")]
    public List<RIBusinessReportFlagInfo> FlagInfo { get; set; }
}
