using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformCompanyDetailsAndStructureDetails")]
public class RiskInformCompanyDetailsAndStructureDetails
{
    [XmlElement("CompanyDetailsStructureRecord")]
    public CompanyDetailsStructureRecord CompanyDetailsStructureRecord { get; set; }

}
}