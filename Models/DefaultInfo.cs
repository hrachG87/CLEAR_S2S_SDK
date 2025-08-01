using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DefaultInfo")]
public class DefaultInfo
{
    [XmlElement("AuctionCallLocation")]
    public CommonDataAddress AuctionCallLocation { get; set; }

    [XmlElement("AuctionInfo")]
    public AuctionInfo AuctionInfo { get; set; }

    [XmlElement("DefaultOnLoanAmount")]
    public string DefaultOnLoanAmount { get; set; }

    [XmlElement("DefaultOnLoanDate")]
    public string DefaultOnLoanDate { get; set; }

    [XmlElement("TotalAmountDueLender")]
    public string TotalAmountDueLender { get; set; }

    [XmlElement("TrusteeInfo")]
    public TrusteeInfo TrusteeInfo { get; set; }
}
