using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LeasingDetails")]
public class LeasingDetails
{
    [XmlElement("LeasingCompany")]
    public string LeasingCompany { get; set; }

    [XmlElement("Address")]
    public Address Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("OriginationDate")]
    public string OriginationDate { get; set; }

    [XmlElement("OriginalLeaseAmount")]
    public int OriginalLeaseAmount { get; set; }

    [XmlElement("LeaseProductType")]
    public string LeaseProductType { get; set; }

    [XmlElement("LeaseCloseDate")]
    public string LeaseCloseDate { get; set; }

    [XmlElement("LeaseTermMonths")]
    public int LeaseTermMonths { get; set; }

    [XmlElement("PaymentsPerYear")]
    public int PaymentsPerYear { get; set; }

    [XmlElement("PaymentType")]
    public string PaymentType { get; set; }

    [XmlElement("CurrentScheduledAmountDue")]
    public int CurrentScheduledAmountDue { get; set; }

    [XmlElement("PaymentsOverdue")]
    public int PaymentsOverdue { get; set; }

    [XmlElement("AmountOfOverduePayments")]
    public int AmountOfOverduePayments { get; set; }

    [XmlElement("RemainingBalance")]
    public int RemainingBalance { get; set; }

    [XmlElement("CurrentPayments")]
    public int CurrentPayments { get; set; }

    [XmlElement("LatePayments")]
    public int LatePayments { get; set; }

}