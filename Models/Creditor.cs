using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Creditor")]
public class Creditor
{
    [XmlElement("PartyInfo")]
    public CourtPartyInfo PartyInfo { get; set; }

    [XmlElement("CreditHolderLevelDesc")]
    public string CreditHolderLevelDesc { get; set; }

    [XmlElement("CreditHolderSerialNumber")]
    public string CreditHolderSerialNumber { get; set; }

    [XmlElement("CreditHolder")]
    public string CreditHolder { get; set; }

    [XmlElement("CreditHolderLevel")]
    public string CreditHolderLevel { get; set; }

    [XmlElement("ForeignRegion")]
    public string ForeignRegion { get; set; }

    [XmlElement("ClaimDescription")]
    public string ClaimDescription { get; set; }

    [XmlElement("OtherClaim")]
    public string OtherClaim { get; set; }

    [XmlElement("SecuredClaim")]
    public string SecuredClaim { get; set; }

    [XmlElement("UnsecuredClaim")]
    public string UnsecuredClaim { get; set; }

    [XmlElement("DUNSNumber")]
    public string DUNSNumber { get; set; }

}
}