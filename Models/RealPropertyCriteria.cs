using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RealPropertyCriteria")]
public class RealPropertyCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public RealPropertyNameCriteria PersonName { get; set; }

    [XmlElement("ParcelNumber")]
    public string ParcelNumber { get; set; }

    [XmlElement("Address")]
    public RealPropertyAddressCriteria Address { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }

}