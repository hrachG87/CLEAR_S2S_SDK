using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PaymentAndLegalFilingsSummarySection")]
public class PaymentAndLegalFilingsSummarySection
{
    [XmlElement("PaymentAndLegalFilingsSummaryRecord")]
    public List<PaymentAndLegalFilingsSummaryRecord> PaymentAndLegalFilingsSummaryRecord { get; set; }

}