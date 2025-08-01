using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EIDVBusinessSearch")]
public class EIDVBusinessSearch
{
    [XmlElement("PermissiblePurpose")]
    public EidvBusinessPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("EIDVBusinessSearchRequest")]
    public EIDVBusinessSearchRequest EIDVBusinessSearchRequest { get; set; }

}