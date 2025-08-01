using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CIDCInternationalPersonEntities")]
public class CIDCInternationalPersonEntities
{
    [XmlElement("InternationalPersonEntity")]
    public List<CIDCInternationalPersonEntity> InternationalPersonEntity { get; set; }

}