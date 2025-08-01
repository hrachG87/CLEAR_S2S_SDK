using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIBusinessSearchIncludeAdditionalSearches")]
public class RIBusinessSearchIncludeAdditionalSearches
{
    [XmlElement("WebAnalyticsSearch")]
    public bool WebAnalyticsSearch { get; set; }

}