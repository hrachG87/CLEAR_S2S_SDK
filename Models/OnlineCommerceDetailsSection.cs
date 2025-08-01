using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("OnlineCommerceDetailsSection")]
public class OnlineCommerceDetailsSection
{
    [XmlElement("OnlineCommerceDetailsRecord")]
    public List<WebAndSocialMediaRecord> OnlineCommerceDetailsRecord { get; set; }
}
