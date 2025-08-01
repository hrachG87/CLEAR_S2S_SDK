using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OriginalLoanInfo")]
public class OriginalLoanInfo
{
    [XmlElement("DocumentNum")]
    public string DocumentNum { get; set; }

    [XmlElement("LoanAmount")]
    public string LoanAmount { get; set; }

    [XmlElement("LoanDate")]
    public string LoanDate { get; set; }

    [XmlElement("SalesTransactionInfo")]
    public SalesTransactionInfo SalesTransactionInfo { get; set; }

}
}