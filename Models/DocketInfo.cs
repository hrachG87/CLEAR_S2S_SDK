using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocketInfo")]
public class DocketInfo
{
    [XmlElement("DocketTitle")]
    public string DocketTitle { get; set; }

    [XmlElement("DocketNumber")]
    public string DocketNumber { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("Court")]
    public string Court { get; set; }

    [XmlElement("NatureOfSuit")]
    public string NatureOfSuit { get; set; }

    [XmlElement("CompanyInterest")]
    public string CompanyInterest { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}