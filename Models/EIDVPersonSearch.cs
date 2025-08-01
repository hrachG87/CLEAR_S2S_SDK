using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EIDVPersonSearch")]
public class EIDVPersonSearch
{
    [XmlElement("PermissiblePurpose")]
    public EidvPermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("eidvpersonSearchRequest")]
    public EIDVPersonSearchRequest eidvpersonSearchRequest { get; set; }

}