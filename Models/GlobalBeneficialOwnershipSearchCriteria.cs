using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GlobalBeneficialOwnershipSearchCriteria")]
public class GlobalBeneficialOwnershipSearchCriteria
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleInitial")]
    public string MiddleInitial { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("SecondaryLastName")]
    public string SecondaryLastName { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("BusinessPurpose")]
    public string BusinessPurpose { get; set; }

    [XmlElement("CorporationID")]
    public string CorporationID { get; set; }

    [XmlElement("DUNS")]
    public string DUNS { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("IdNumber")]
    public string IdNumber { get; set; }

    [XmlElement("Email")]
    public string Email { get; set; }

    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("Province")]
    public string Province { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

}
}