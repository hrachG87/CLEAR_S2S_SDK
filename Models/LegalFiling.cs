using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LegalFiling")]
public class LegalFiling
{
    [XmlElement("FileDate")]
    public string FileDate { get; set; }

    [XmlElement("FilingType")]
    public string FilingType { get; set; }

    [XmlElement("FiledBy")]
    public string FiledBy { get; set; }

    [XmlElement("Plaintiff")]
    public string Plaintiff { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("Amount")]
    public int Amount { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

    [XmlElement("Jurisdiction")]
    public string Jurisdiction { get; set; }

}