using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BankingRelationship")]
public class BankingRelationship
{
    [XmlElement("FinancialInstitution")]
    public string FinancialInstitution { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("AccountType")]
    public string AccountType { get; set; }

    [XmlElement("DateOpened")]
    public string DateOpened { get; set; }

    [XmlElement("AccountRating")]
    public string AccountRating { get; set; }

    [XmlElement("ProfileDate")]
    public string ProfileDate { get; set; }

    [XmlElement("AccountBalance")]
    public int AccountBalance { get; set; }

}
}