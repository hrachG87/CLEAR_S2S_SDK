using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CorporateLinkageSection")]
public class CorporateLinkageSection
{
    [XmlElement("CorporateLinkageRecord")]
    public List<CorporateLinkageRecord> CorporateLinkageRecord { get; set; }

}