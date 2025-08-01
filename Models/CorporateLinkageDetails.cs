using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CorporateLinkageDetails")]
public class CorporateLinkageDetails
{
    [XmlElement("CorporateLinkageDetail")]
    public List<CorporateLinkageDetail> CorporateLinkageDetail { get; set; }

}