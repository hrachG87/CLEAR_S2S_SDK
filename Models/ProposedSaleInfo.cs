using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ProposedSaleInfo")]
public class ProposedSaleInfo
{
    [XmlElement("BrokerName")]
    public string BrokerName { get; set; }

    [XmlElement("NatureOfAcquisition")]
    public string NatureOfAcquisition { get; set; }

    [XmlElement("NumberOfSharesAdjusted")]
    public string NumberOfSharesAdjusted { get; set; }

    [XmlElement("ProposedNumberOfShares")]
    public string ProposedNumberOfShares { get; set; }

    [XmlElement("ProposedSaleDate")]
    public string ProposedSaleDate { get; set; }

    [XmlElement("SequenceNumber")]
    public string SequenceNumber { get; set; }

    [XmlElement("ItemValue")]
    public string ItemValue { get; set; }
}
