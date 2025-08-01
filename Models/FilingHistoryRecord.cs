using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FilingHistoryRecord")]
public class FilingHistoryRecord
{
    [XmlElement("DocPages")]
    public string DocPages { get; set; }

    [XmlElement("DocumentCode")]
    public string DocumentCode { get; set; }

    [XmlElement("DomesticationPages")]
    public string DomesticationPages { get; set; }

    [XmlElement("EffectiveDate")]
    public string EffectiveDate { get; set; }

    [XmlElement("FilingDateTime")]
    public string FilingDateTime { get; set; }

    [XmlElement("FilingStatus")]
    public string FilingStatus { get; set; }

    [XmlElement("FilingYear")]
    public string FilingYear { get; set; }

    [XmlElement("MergerType")]
    public string MergerType { get; set; }

    [XmlElement("FormerName")]
    public string FormerName { get; set; }
}
