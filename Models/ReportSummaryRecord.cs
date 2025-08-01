using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ReportSummaryRecord")]
public class ReportSummaryRecord
{
    [XmlElement("PremierProfile")]
    public string PremierProfile { get; set; }

    [XmlElement("Subcode")]
    public string Subcode { get; set; }

    [XmlElement("TransactionNumber")]
    public string TransactionNumber { get; set; }

    [XmlElement("SearchInquiry")]
    public string SearchInquiry { get; set; }

}
}