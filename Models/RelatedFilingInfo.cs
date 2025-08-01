using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RelatedFilingInfo")]
public class RelatedFilingInfo
{
    [XmlElement("RelatedFilingDate")]
    public string RelatedFilingDate { get; set; }

    [XmlElement("RelatedFilingDocumentNumber")]
    public string RelatedFilingDocumentNumber { get; set; }

    [XmlElement("RelatedFilingNumber")]
    public string RelatedFilingNumber { get; set; }

    [XmlElement("RelatedFilingPageCount")]
    public string RelatedFilingPageCount { get; set; }

    [XmlElement("RelatedFilingTime")]
    public string RelatedFilingTime { get; set; }

    [XmlElement("RelatedFilingType")]
    public string RelatedFilingType { get; set; }
}
