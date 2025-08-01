using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PaymentExperiencesAndAccountStatusDetails")]
public class PaymentExperiencesAndAccountStatusDetails
{
    [XmlElement("BusinessCategory")]
    public string BusinessCategory { get; set; }

    [XmlElement("DateReported")]
    public string DateReported { get; set; }

    [XmlElement("NewlyReported")]
    public bool NewlyReported { get; set; }

    [XmlElement("LastSale")]
    public string LastSale { get; set; }

    [XmlElement("PaymentTerms")]
    public string PaymentTerms { get; set; }

    [XmlElement("RecentHighCredit")]
    public int RecentHighCredit { get; set; }

    [XmlElement("RecentHighCreditTrend")]
    public string RecentHighCreditTrend { get; set; }

    [XmlElement("Comment")]
    public string Comment { get; set; }

    [XmlElement("DBTPaymentDetail")]
    public DBTPaymentDetail DBTPaymentDetail { get; set; }

}
}