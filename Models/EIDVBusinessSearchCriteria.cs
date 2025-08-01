using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EIDVBusinessSearchCriteria")]
public class EIDVBusinessSearchCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("FeinNumber")]
    public string FeinNumber { get; set; }

    [XmlElement("CorporationId")]
    public string CorporationId { get; set; }

    [XmlElement("DunsNumber")]
    public string DunsNumber { get; set; }

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

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("PhoneCountryCode")]
    public string PhoneCountryCode { get; set; }

    [XmlElement("OfficerAgentFirstName")]
    public string OfficerAgentFirstName { get; set; }

    [XmlElement("OfficerAgentMiddleName")]
    public string OfficerAgentMiddleName { get; set; }

    [XmlElement("OfficerAgentLastName")]
    public string OfficerAgentLastName { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

}