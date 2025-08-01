using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PaymentTrendingRecord")]
public class PaymentTrendingRecord
{
    [XmlElement("MonthlyPaymentTrends")]
    public MonthlyPaymentTrends MonthlyPaymentTrends { get; set; }

    [XmlElement("QuarterlyPaymentTrends")]
    public QuarterlyPaymentTrends QuarterlyPaymentTrends { get; set; }

    [XmlElement("SICInfo")]
    public SICInfo SICInfo { get; set; }

}
}