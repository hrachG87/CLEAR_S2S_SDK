using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CorporationInfo")]
public class CorporationInfo
{
    [XmlElement("CorporationNumber")]
    public string CorporationNumber { get; set; }

    [XmlElement("StateOfIncorporation")]
    public string StateOfIncorporation { get; set; }

    [XmlElement("DateIncorporated")]
    public string DateIncorporated { get; set; }
}
