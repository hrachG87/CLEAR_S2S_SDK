using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonRiskAddressInfo")]
public class PersonRiskAddressInfo
{
    [XmlElement("RiskCounty")]
    public string RiskCounty { get; set; }

    [XmlElement("DateOfIncident")]
    public string DateOfIncident { get; set; }

    [XmlElement("RiskRegion")]
    public string RiskRegion { get; set; }

    [XmlElement("SiteName")]
    public string SiteName { get; set; }

    [XmlElement("SiteEPAId")]
    public string SiteEPAId { get; set; }

    [XmlElement("SiteScore")]
    public string SiteScore { get; set; }

    [XmlElement("FederalFacility")]
    public string FederalFacility { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("ListingDate")]
    public string ListingDate { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("Address")]
    public List<RiskFlagsAddress> Address { get; set; }

}