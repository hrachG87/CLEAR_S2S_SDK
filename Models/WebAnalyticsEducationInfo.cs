using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebAnalyticsEducationInfo")]
public class WebAnalyticsEducationInfo
{
    [XmlElement("Education")]
    public List<string> Education { get; set; }
}
