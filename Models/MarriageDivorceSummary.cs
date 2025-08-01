using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MarriageDivorceSummary")]
public class MarriageDivorceSummary
{
    [XmlElement("MarriageInfo")]
    public List<PersonSummaryInfo> MarriageInfo { get; set; }

    [XmlElement("DivorceInfo")]
    public List<PersonSummaryInfo> DivorceInfo { get; set; }
}
