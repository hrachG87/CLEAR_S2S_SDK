using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GeoSocialNetworksDetailsSection")]
public class GeoSocialNetworksDetailsSection
{
    [XmlElement("GeoSocialNetworksDetailsRecord")]
    public List<WebAndSocialMediaRecord> GeoSocialNetworksDetailsRecord { get; set; }

}
}