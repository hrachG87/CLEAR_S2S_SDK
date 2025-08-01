using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MonthlyPaymentTrends")]
public class MonthlyPaymentTrends
{
    [XmlElement("MonthlyPaymentDetail")]
    public List<MonthlyPaymentDetail> MonthlyPaymentDetail { get; set; }
}
