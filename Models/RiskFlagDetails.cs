using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskFlagDetails")]
public class RiskFlagDetails
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("IncorporationDate")]
    public string IncorporationDate { get; set; }

    [XmlElement("TickerSymbol")]
    public string TickerSymbol { get; set; }

    [XmlElement("ExchangeName")]
    public string ExchangeName { get; set; }

    [XmlElement("Address")]
    public RiskFlagsAddress Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("URL")]
    public List<string> URL { get; set; }

    [XmlElement("OfficerAgentInfo")]
    public List<OfficerAgentInfo> OfficerAgentInfo { get; set; }

    [XmlElement("NumberEmployees")]
    public string NumberEmployees { get; set; }

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

    [XmlElement("SICAndNAICSInfo")]
    public SICAndNAICSInfo SICAndNAICSInfo { get; set; }

}
}