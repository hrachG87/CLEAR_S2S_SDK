using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CorpNameHistory")]
public class CorpNameHistory
{
    [XmlElement("CancellationDate")]
    public string CancellationDate { get; set; }

    [XmlElement("InitialDate")]
    public string InitialDate { get; set; }

    [XmlElement("NameType")]
    public string NameType { get; set; }

    [XmlElement("RenewalDate")]
    public string RenewalDate { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }
}
