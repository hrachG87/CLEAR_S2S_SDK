using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ProviderInfo")]
public class ProviderInfo
{
    [XmlElement("ProviderType")]
    public string ProviderType { get; set; }

    [XmlElement("ProviderCategory")]
    public string ProviderCategory { get; set; }

}