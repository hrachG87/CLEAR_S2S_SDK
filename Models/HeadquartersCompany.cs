using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HeadquartersCompany")]
public class HeadquartersCompany
{
    [XmlElement("HeadquartersDUNSNumber")]
    public string HeadquartersDUNSNumber { get; set; }

    [XmlElement("HeadquartersCompanyName")]
    public string HeadquartersCompanyName { get; set; }

    [XmlElement("HeadquartersCompanyAddress")]
    public CommonDataAddress HeadquartersCompanyAddress { get; set; }

    [XmlElement("TotalNumberOfFamilyMembers")]
    public string TotalNumberOfFamilyMembers { get; set; }

}
}