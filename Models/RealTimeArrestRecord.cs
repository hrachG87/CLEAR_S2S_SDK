using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealTimeArrestRecord")]
public class RealTimeArrestRecord
{
    [XmlElement("AddressInfo")]
    public List<CriminalDataAddressInfo> AddressInfo { get; set; }

    [XmlElement("BookingInfo")]
    public BookingInfo BookingInfo { get; set; }

    [XmlElement("ChargesInfo")]
    public List<CriminalDataChargesInfo> ChargesInfo { get; set; }

    [XmlElement("EmploymentInfo")]
    public List<EmploymentInfo> EmploymentInfo { get; set; }

    [XmlElement("PersonDetails")]
    public PersonDetails PersonDetails { get; set; }

    [XmlElement("ProfileInfo")]
    public ProfileInfo ProfileInfo { get; set; }

    [XmlElement("WarningInfo")]
    public WarningInfo WarningInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("PhotoURL")]
    public List<string> PhotoURL { get; set; }

}
}