using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MonthlyPaymentTrends")]
public class MonthlyPaymentTrends
{
    [XmlElement("MonthlyPaymentDetail")]
    public List<MonthlyPaymentDetail> MonthlyPaymentDetail { get; set; }

}
}