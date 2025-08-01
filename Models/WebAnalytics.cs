using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebAnalytics")]
public class WebAnalytics
{
    [XmlElement("WebResult")]
    public List<RiskInformBusinessWebResult> WebResult { get; set; }
}
