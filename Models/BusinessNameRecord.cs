using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessNameRecord")]
public class BusinessNameRecord
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("BusinessIDNumber")]
    public int BusinessIDNumber { get; set; }

    [XmlElement("DoingBusinessAs")]
    public string DoingBusinessAs { get; set; }

    [XmlElement("WebsiteURL")]
    public string WebsiteURL { get; set; }

    [XmlElement("PrimaryAddress")]
    public Address PrimaryAddress { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("TaxID")]
    public string TaxID { get; set; }

    [XmlElement("PossibleOFACOrVictimStatement")]
    public bool PossibleOFACOrVictimStatement { get; set; }

    [XmlElement("MatchingBranchAddress")]
    public Address MatchingBranchAddress { get; set; }

    [XmlElement("MatchingBranchBIN")]
    public int MatchingBranchBIN { get; set; }

    [XmlElement("CorporateLinkageType")]
    public string CorporateLinkageType { get; set; }

}