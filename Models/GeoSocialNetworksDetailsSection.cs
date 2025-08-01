using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GeoSocialNetworksDetailsSection")]
public class GeoSocialNetworksDetailsSection
{
    [XmlElement("GeoSocialNetworksDetailsRecord")]
    public List<WebAndSocialMediaRecord> GeoSocialNetworksDetailsRecord { get; set; }
}
