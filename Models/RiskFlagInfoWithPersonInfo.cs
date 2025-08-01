using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskFlagInfoWithPersonInfo")]
public class RiskFlagInfoWithPersonInfo
{
    [XmlElement("RiskFlagName")]
    public string RiskFlagName { get; set; }

    [XmlElement("RiskFlagScore")]
    public string RiskFlagScore { get; set; }

    [XmlElement("RiskFlagHitIndicator")]
    public string RiskFlagHitIndicator { get; set; }

    [XmlElement("RiskFlagCrimeType")]
    public string RiskFlagCrimeType { get; set; }

    [XmlElement("RiskFlagCaseSubCategory")]
    public string RiskFlagCaseSubCategory { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<RiskFlagsDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }

    [XmlElement("RiskAddressInfo")]
    public List<PersonRiskAddressInfo> RiskAddressInfo { get; set; }

    [XmlElement("PersonInfo")]
    public List<RiskFlagsPersonInfo> PersonInfo { get; set; }

}
}