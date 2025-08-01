using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MonthlyPaymentDetail")]
public class MonthlyPaymentDetail
{
    [XmlElement("DateReported")]
    public string DateReported { get; set; }

    [XmlElement("IndustryCurrentPercentage")]
    public int IndustryCurrentPercentage { get; set; }

    [XmlElement("IndustryDBT")]
    public int IndustryDBT { get; set; }

    [XmlElement("DBTPaymentDetail")]
    public DBTPaymentDetail DBTPaymentDetail { get; set; }
}
