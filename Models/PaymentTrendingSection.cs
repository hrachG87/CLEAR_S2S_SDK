using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PaymentTrendingSection")]
public class PaymentTrendingSection
{
    [XmlElement("PaymentTrendingRecord")]
    public List<PaymentTrendingRecord> PaymentTrendingRecord { get; set; }

}
}