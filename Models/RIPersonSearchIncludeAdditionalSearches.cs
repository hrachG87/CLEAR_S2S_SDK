using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonSearchIncludeAdditionalSearches")]
public class RIPersonSearchIncludeAdditionalSearches
{
    [XmlElement("WebAnalyticsSearch")]
    public bool WebAnalyticsSearch { get; set; }
}
