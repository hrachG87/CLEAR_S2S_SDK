using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIBusinessSearchSectionDetails")]
public class RIBusinessSearchSectionDetails
{
    [XmlElement("SingleRiskIndicators")]
    public SingleRiskIndicators SingleRiskIndicators { get; set; }

    [XmlElement("AddressFlags")]
    public AddressFlags AddressFlags { get; set; }

    [XmlElement("CompanyDetailsStructure")]
    public CompanyDetailsStructure CompanyDetailsStructure { get; set; }

    [XmlElement("PrincipalsExecutivesTiedToBusiness")]
    public PrincipalsExecutivesTiedToBusiness PrincipalsExecutivesTiedToBusiness { get; set; }

    [XmlElement("BusinessFlags")]
    public BusinessFlags BusinessFlags { get; set; }

    [XmlElement("News")]
    public RIBusinessSearchNews News { get; set; }

    [XmlElement("WebAnalytics")]
    public WebAnalytics WebAnalytics { get; set; }

}
}