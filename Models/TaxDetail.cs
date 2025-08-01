using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TaxDetail")]
public class TaxDetail
{
    [XmlElement("TotalUnpaidBalance")]
    public string TotalUnpaidBalance { get; set; }

    [XmlElement("FilingFee")]
    public string FilingFee { get; set; }

    [XmlElement("TotalInterest")]
    public string TotalInterest { get; set; }

    [XmlElement("TotalOther")]
    public string TotalOther { get; set; }

    [XmlElement("TotalPaid")]
    public string TotalPaid { get; set; }

    [XmlElement("TotalPenalty")]
    public string TotalPenalty { get; set; }

    [XmlElement("TaxYear")]
    public string TaxYear { get; set; }

    [XmlElement("TotalTaxes")]
    public string TotalTaxes { get; set; }
}
