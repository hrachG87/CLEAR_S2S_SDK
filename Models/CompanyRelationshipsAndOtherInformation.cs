using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyRelationshipsAndOtherInformation")]
public class CompanyRelationshipsAndOtherInformation
{
    [XmlElement("ThisCompanySpecifics")]
    public ThisCompanySpecifics ThisCompanySpecifics { get; set; }

    [XmlElement("ParentCompany")]
    public ParentCompany ParentCompany { get; set; }

    [XmlElement("UltimateCompany")]
    public UltimateCompany UltimateCompany { get; set; }

    [XmlElement("HeadquartersCompany")]
    public HeadquartersCompany HeadquartersCompany { get; set; }

}
}