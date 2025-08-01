using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ShareholderRecord")]
public class ShareholderRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("CUSIP")]
    public string CUSIP { get; set; }

    [XmlElement("DerivativeInfo")]
    public List<DerivativeInfo> DerivativeInfo { get; set; }

    [XmlElement("FormType")]
    public string FormType { get; set; }

    [XmlElement("NonDerivativeInfo")]
    public List<NonDerivativeInfo> NonDerivativeInfo { get; set; }

    [XmlElement("OwnerRoles")]
    public List<OwnerRoles> OwnerRoles { get; set; }

    [XmlElement("ProposedSaleInfo")]
    public List<ProposedSaleInfo> ProposedSaleInfo { get; set; }

    [XmlElement("RoleClass")]
    public string RoleClass { get; set; }

    [XmlElement("SignatureDate")]
    public string SignatureDate { get; set; }

    [XmlElement("TickerSymbol")]
    public string TickerSymbol { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SECReceiptDate")]
    public string SECReceiptDate { get; set; }
}
