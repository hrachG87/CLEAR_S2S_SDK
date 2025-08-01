using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessCriteria")]
public class BusinessCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("CorporationInfo")]
    public CorporationCriteria CorporationInfo { get; set; }

    [XmlElement("NameInfo")]
    public BusinessNameCriteria NameInfo { get; set; }

    [XmlElement("AddressInfo")]
    public BusinessSearchAddressCriteria AddressInfo { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("CompanyEntityId")]
    public string CompanyEntityId { get; set; }

    [XmlElement("IndustryCodes")]
    public IndustryCodes IndustryCodes { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

}
}