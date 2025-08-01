using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TaxInfoRecord")]
public class TaxInfoRecord
{
    [XmlElement("LastAnnualReportYear")]
    public string LastAnnualReportYear { get; set; }

    [XmlElement("QuarterlyFlag")]
    public string QuarterlyFlag { get; set; }

    [XmlElement("TaxBalance")]
    public string TaxBalance { get; set; }

    [XmlElement("TaxDetail")]
    public List<TaxDetail> TaxDetail { get; set; }

    [XmlElement("TaxType")]
    public string TaxType { get; set; }
}
