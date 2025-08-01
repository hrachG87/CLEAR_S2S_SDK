using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebAndSocialMediaSearchCriteria")]
public class WebAndSocialMediaSearchCriteria
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("MiddleNameOrInitial")]
    public string MiddleNameOrInitial { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("Phone")]
    public string Phone { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("Username")]
    public string Username { get; set; }

    [XmlElement("Employer")]
    public string Employer { get; set; }

    [XmlElement("School")]
    public string School { get; set; }

    [XmlElement("Address")]
    public string Address { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("Territory")]
    public string Territory { get; set; }

    [XmlElement("AdditionalCriteria")]
    public AdditionalCriteria AdditionalCriteria { get; set; }
}
