using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseDataBusinessInfo")]
public class LicenseDataBusinessInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("BusinessName")]
    public List<string> BusinessName { get; set; }

    [XmlElement("OtherBusinessName")]
    public List<string> OtherBusinessName { get; set; }

    [XmlElement("DoingBusinessAs")]
    public List<string> DoingBusinessAs { get; set; }

    [XmlElement("OwnerName")]
    public List<string> OwnerName { get; set; }

    [XmlElement("FederalEmpID")]
    public string FederalEmpID { get; set; }

    [XmlElement("TaxID")]
    public string TaxID { get; set; }

}
}