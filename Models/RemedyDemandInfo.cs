using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RemedyDemandInfo")]
public class RemedyDemandInfo
{
    [XmlElement("PlaintiffRemedyAmount")]
    public string PlaintiffRemedyAmount { get; set; }

    [XmlElement("PlaintiffRemedyDesc")]
    public string PlaintiffRemedyDesc { get; set; }

    [XmlElement("PlaintiffRemedyPrereq")]
    public string PlaintiffRemedyPrereq { get; set; }

}