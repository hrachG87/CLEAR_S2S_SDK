using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("QuarterlyPaymentTrends")]
public class QuarterlyPaymentTrends
{
    [XmlElement("QuarterlyPaymentDetail")]
    public List<QuarterlyPaymentDetail> QuarterlyPaymentDetail { get; set; }
}
