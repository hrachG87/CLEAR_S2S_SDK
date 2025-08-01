using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GeneralInfoRecord")]
public class GeneralInfoRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

    [XmlElement("CorpKind")]
    public string CorpKind { get; set; }

    [XmlElement("CorpStatus")]
    public string CorpStatus { get; set; }

    [XmlElement("CorpType")]
    public string CorpType { get; set; }

    [XmlElement("ExpDate")]
    public string ExpDate { get; set; }

    [XmlElement("ForeignIncInfo")]
    public ForeignIncInfo ForeignIncInfo { get; set; }

    [XmlElement("IncDate")]
    public string IncDate { get; set; }

    [XmlElement("IncState")]
    public string IncState { get; set; }

    [XmlElement("MergedToNum")]
    public string MergedToNum { get; set; }

    [XmlElement("RenewalDate")]
    public string RenewalDate { get; set; }

    [XmlElement("Residency")]
    public string Residency { get; set; }

    [XmlElement("StatusDate")]
    public string StatusDate { get; set; }

    [XmlElement("StockComp")]
    public string StockComp { get; set; }
}
