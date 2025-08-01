using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PassportInfo")]
public class PassportInfo
{
    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("Gender")]
    public string Gender { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("PassportNumber")]
    public string PassportNumber { get; set; }

    [XmlElement("IssuingState")]
    public string IssuingState { get; set; }

    [XmlElement("Nationality")]
    public string Nationality { get; set; }

    [XmlElement("ExpiryDate")]
    public string ExpiryDate { get; set; }

}
}