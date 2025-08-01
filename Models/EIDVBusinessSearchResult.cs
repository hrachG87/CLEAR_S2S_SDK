using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EIDVBusinessSearchResult")]
public class EIDVBusinessSearchResult
{
    [XmlElement("NormalizedCriteria")]
    public EidBusinessNormalizedCriteria NormalizedCriteria { get; set; }

    [XmlElement("ServiceErrors")]
    public EidvBusinessServiceErrors ServiceErrors { get; set; }

    [XmlElement("CompanyEntites")]
    public CompanyEntities CompanyEntites { get; set; }

    [XmlElement("phoneAttributes")]
    public IDConfirmPhoneAttributes phoneAttributes { get; set; }

    [XmlElement("EIDVBusinessSearchRequest")]
    public EIDVBusinessSearchRequest EIDVBusinessSearchRequest { get; set; }

}
}